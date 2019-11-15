using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AutomapperIssue.Controllers;

namespace AutomapperIssue.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AutomapperIssueControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
