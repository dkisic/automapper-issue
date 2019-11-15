using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AutomapperIssue.Controllers;

namespace AutomapperIssue.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : AutomapperIssueControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
