using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.WinApp.Extenders
{
    public static class RadioButtonExtender
    {
        /// <summary>
        /// Ensure event is only triggered for check and NOT for uncheck.
        /// </summary>
        public static bool WasChecked(this RadioButton radioButton, object sender)
        {
            var senderButton = sender as RadioButton;
            return senderButton != null && senderButton.Name == radioButton.Name && radioButton.Checked;
        }
    }
}
