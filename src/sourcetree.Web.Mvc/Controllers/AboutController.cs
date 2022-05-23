using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using sourcetree.Controllers;

namespace sourcetree.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : sourcetreeControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
