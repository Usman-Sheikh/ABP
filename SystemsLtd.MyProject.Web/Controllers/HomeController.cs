using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace SystemsLtd.MyProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}