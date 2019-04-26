using System.Web.Mvc;

namespace demo.Controllers
{
    public class QrController : Controller
    {
        // GET: QR
        public ActionResult index()
        {
            erweima.Generate("http://baidu.com/");
            return View();
        }
    }
}