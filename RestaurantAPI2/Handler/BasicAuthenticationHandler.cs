using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Text.Encodings.Web;
using System.Net.Http.Headers;
using System.Text;
using RestaurantAPI2.Data;
using System.Security.Claims;

namespace RestaurantAPI2.Handler
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly DataContext _context;
        public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> option,ILoggerFactory logger,UrlEncoder encoder, ISystemClock clock, DataContext context):base(option, logger, encoder, clock)
        {
            _context = context;
        }
        protected async override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if(!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("No header found");

            var _headervalue = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
            var bytes = Convert.FromBase64String(_headervalue.Parameter);
            string credentials = Encoding.UTF8.GetString(bytes);
            if(!string.IsNullOrEmpty(credentials))
            {
                string[] array = credentials.Split(":");
                string username = array[0];
                string password = array[1];
                var user = this._context.Users.FirstOrDefault(item => item.Userid == username && item.Password == password);
                if(user != null)
                    return AuthenticateResult.Fail("UnAuthorized");

                var claim = new[] { new Claim(ClaimTypes.Name, username) };
                var identity = new ClaimsIdentity(claim,Scheme.Name);
                var principal = new ClaimsPrincipal(identity);
                var ticket = new AuthenticationTicket(principal,Scheme.Name);
                return AuthenticateResult.Success(ticket);

            }
            else
            {
                return AuthenticateResult.Fail("UnAuthorized");
            }
        }
    }
}
