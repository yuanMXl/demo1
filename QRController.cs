using System.IO;
using System.Text;
using System.Web;
using System.Web.Mvc;


namespace demo.Controllers
{
    public class QrController : Controller
    {
        // GET: QR
        public ActionResult index()
        {
            erweima.Generate("http://2e4v704989.qicp.vip:55447/QR/uploadimg");
            return View();
        }
        //[HttpPost]
        public ActionResult uploadimg()
        {
            if (Request.Files.Count > 0)
            {
                HttpPostedFileBase f = Request.Files["file1"];
                f.SaveAs(@"C:\Users\Administrator\source\repos\demo\demo\ymx\" + f.FileName);
            }
            return View();
        }
        public string browseimg()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string img in Directory.GetFiles(Server.MapPath("/ymx/")))
            {
                string file = img.Substring(img.LastIndexOf("\\") + 1);
                sb.Append("<img src='../../ymx/" + file + "' ><br/>");
                
            }
            return sb.ToString();
        }
    }
}