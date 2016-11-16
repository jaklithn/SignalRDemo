using System;
using System.Web;
using System.Web.Security;


namespace Demo.Web.Services
{
    public static class AuthenticationHandler
    {
        public static void SetAuthCookie(string userName, bool rememberMe, string[] roles)
        {
            var version = 1;
            var expirationMinutes = 20;
            var authTicket = new FormsAuthenticationTicket(version,
                userName, DateTime.Now, DateTime.Now.AddMinutes(expirationMinutes), rememberMe, string.Join(";", roles)
                );

            var encryptedTicket = FormsAuthentication.Encrypt(authTicket);

            var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            HttpContext.Current.Response.Cookies.Add(authCookie);
        }
    }
}