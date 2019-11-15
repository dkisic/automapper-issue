using Microsoft.AspNetCore.Antiforgery;
using AutomapperIssue.Controllers;

namespace AutomapperIssue.Web.Host.Controllers
{
    public class AntiForgeryController : AutomapperIssueControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
