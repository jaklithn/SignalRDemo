using System;
using System.Configuration;
using System.Net;
using System.Text;
using System.Web.Security;
using System.Windows.Forms;
using Demo.WinApp.Properties;

namespace Demo.WinApp.Services
{
    public class AuthenticationHandler
    {
        public static Cookie GetCookie(bool isInitialConnect)
        {
            Cookie cookie;
            do
            {
                if (!Login.AllowAutologin)
                {
                    var f = new Login();
                    f.ShowDialog();
                }
                cookie = CreateCookie(isInitialConnect);
                if (cookie == null && isInitialConnect)
                {
                    Login.AllowAutologin = false;
                }
            } while (cookie == null);

            return cookie;
        }

        private static Cookie CreateCookie(bool isInitialConnect)
        {
            try
            {
                var loginUrl = ConfigurationManager.AppSettings["LoginUrl"];

                var request = WebRequest.Create(loginUrl) as HttpWebRequest;
                if (request == null)
                {
                    throw new Exception("Login Url not found");
                }

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.CookieContainer = new CookieContainer();

                var authCredentials = $"UserName={Settings.Default.UserName}&Password={Settings.Default.Password}";
                var bytes = Encoding.UTF8.GetBytes(authCredentials);
                request.ContentLength = bytes.Length;
                using (var requestStream = request.GetRequestStream())
                {
                    requestStream.Write(bytes, 0, bytes.Length);
                }

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    if (response == null)
                    {
                        throw new Exception($"No response from server '{loginUrl}'");
                    }

                    var cookie = response.Cookies[FormsAuthentication.FormsCookieName];

                    if (cookie == null)
                    {
                        throw new Exception("No cookie created");
                    }

                    return cookie;
                }
            }
            catch (Exception ex)
            {
                if(isInitialConnect)
                {
                    MessageBox.Show(ex.Message, "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return null;
        }
    }
}