using System.Web;
using System.Web.Mvc;

namespace demo.Controllers
{
    public class QrController : Controller
    {
        // GET: QR
        public ActionResult index()
        {
            erweima.Generate("http://192.168.124.19/QR/uploadimg");
            return View();
        }
        //[HttpPost]
        public ActionResult uploadimg()
        {
            if (Request.Files.Count > 0)
            {
                HttpPostedFileBase f = Request.Files["file1"];
                f.SaveAs(@"E:\ymx\img" + f.FileName);
            }
            return View();
        }

          
    }
}