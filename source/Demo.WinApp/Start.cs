using System;
using System.Configuration;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Demo.WinApp.Extenders;
using Demo.WinApp.Properties;
using Demo.WinApp.Services;
using Microsoft.AspNet.SignalR.Client;

namespace Demo.WinApp
{
    public partial class Start : Form
    {
        private HubConnection _connection;
        private IHubProxy _notificationHubProxy;

        private void ConnectHub(bool isInitialAttempt)
        {
            try
            {
                // Setup connection to server
                var serverUrl = ConfigurationManager.AppSettings["ServerUrl"];
                _connection = new HubConnection(serverUrl);

                // Add credentials
                var cookie = AuthenticationHandler.GetCookie(isInitialAttempt);
                _connection.CookieContainer = new CookieContainer();
                _connection.CookieContainer.Add(cookie);

                _notificationHubProxy = _connection.CreateHubProxy("NotificationHub");
                _connection.StateChanged += Connection_StateChanged;
                _connection.Closed += Connection_Closed;

                // Register callback methods
                _notificationHubProxy.On<string, string>("addChatMessage", (name, message) => { this.MyInvoke(() => { AddChatMessage(name, message); }); });

                // Open connection
                _connection.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendChatMessage()
        {
            _notificationHubProxy.Invoke("SendChatMessage", txtChatMessage.Text);
            if (txtSentLog.Visible)
            {
                txtSentLog.Text += DateTime.Now.ToString("HH:mm:ss.fff ") + (Settings.Default.UserName + ":").PadRight(10) + txtChatMessage.Text + Environment.NewLine;
            }
            txtChatMessage.Text = string.Empty;
        }

        private void SendOnline()
        {
            var selectedMachineId = (int)lstMachines.SelectedValue;
            _notificationHubProxy.Invoke("sendActionToSubscribers", selectedMachineId, "online");
        }

        private void SendScreenDump()
        {
            var selectedMachineId = (int)lstMachines.SelectedValue;
            _notificationHubProxy.Invoke("sendActionToSubscribers", selectedMachineId, "screenDumpReady");
        }

        private void SendLunch()
        {
            _notificationHubProxy.Invoke("sendLunch", txtMeat.Text, txtFish.Text, txtVegetarian.Text, txtMeatPrice.Text, txtFishPrice.Text, txtVegetarianPrice.Text);
        }

        private void AddChatMessage(string name, string message)
        {
            var time = txtSentLog.Visible ? DateTime.Now.ToString("HH:mm:ss.fff ") : string.Empty;
            txtChatList.Text += time + (name + ":").PadRight(10) + message + Environment.NewLine;
            txtChatMessage.Focus();
        }


        #region Support Methods

        private void LoadMachines()
        {
            lstMachines.ValueMember = "Id";
            lstMachines.DisplayMember = "Name";
            lstMachines.DataSource = new MachineRepository().GetMachines();
            lstMachines.SelectedIndex = 0;
        }

        private void SetTitle(ConnectionState newState)
        {
            var userName = Settings.Default.UserName.IsSpecified() ? Settings.Default.UserName : "Anonymous";
            this.MyInvoke(() =>
            {
                Text = $"SignalR Demo - {newState.ToString().ToUpper()}" + (newState == ConnectionState.Connected ? $" as {userName}" : string.Empty);
            });
        }

        #endregion


        #region Event Handlers

        private void Start_Load(object sender, EventArgs e)
        {
            ConnectHub(true);
            LoadMachines();
        }

        private void Connection_Closed()
        {
            Thread.Sleep(5000);
            ConnectHub(false);
        }

        private void Connection_StateChanged(StateChange obj)
        {
            SetTitle(obj.NewState);
        }

        private void txtChatList_Enter(object sender, EventArgs e)
        {
            txtChatMessage.Focus();
        }

        private void btnSendChat_Click(object sender, EventArgs e)
        {
            SendChatMessage();
            txtChatMessage.Focus();
        }

        private void btnClearHat_Click(object sender, EventArgs e)
        {
            txtChatList.Text = string.Empty;
            txtSentLog.Text = string.Empty;
            txtChatMessage.Focus();
        }

        private void chkLogChat_CheckedChanged(object sender, EventArgs e)
        {
            txtSentLog.Visible = chkLogChat.Checked;
            txtChatMessage.Focus();
        }

        private void btnSendLunch_Click(object sender, EventArgs e)
        {
            SendLunch();
        }

        private void btnSuggestLunch_Click(object sender, EventArgs e)
        {
            LunchHandler.Suggest(txtMeat, txtFish, txtVegetarian, txtMeatPrice, txtFishPrice, txtVegetarianPrice);
        }

        private void btnSendOnline_Click(object sender, EventArgs e)
        {
            SendOnline();
        }

        private void btnSendScreenDump_Click(object sender, EventArgs e)
        {
            SendScreenDump();
        }

        private void Sensor_CheckedChanged(object sender, EventArgs e)
        {
            if (optSensorSend.WasChecked(sender))
            {
                SensorHandler.Start(_notificationHubProxy);
            }
            else if (optSensorPause.WasChecked(sender))
            {
                SensorHandler.Pause();
            }
            else if (optSensorStop.WasChecked(sender))
            {
                SensorHandler.Stop();
            }
        }

        private void Map_CheckedChanged(object sender, EventArgs e)
        {
            if (optPositionSend.WasChecked(sender))
            {
                MapHandler.Start(_notificationHubProxy);
            }
            else if (optPositionPause.WasChecked(sender))
            {
                MapHandler.Pause();
            }
            else if (optPositionStop.WasChecked(sender))
            {
                MapHandler.Stop();
            }
        }

        #endregion
    }
}