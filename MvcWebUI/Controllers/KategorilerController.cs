using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class KategorilerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /*
        IActionResult
        ActionResult
        ViewResult (View()) 
        ContentResult (Content()) 
        EmptyResult
        FileContentResult(File())
        HttpResults
        JavaScriptResult (JavaScript())
        JsonResult(Json())
        RedirectResults         
         */
        public ContentResult GetHtmlContent()
        {
            return Content("<b><i>Content result.</i></b>", "text/html");
        }
        public ActionResult GetKategorilerXmlContent()
        {
            string xml = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>";
            xml += "<KategoriModels>";
            xml += "<KategoriModel>";
            xml += "<Id>" + 1 + "</Id>";
            xml += "<Adi>" + "Laptop" + "</Adi>";
            xml += "<Aciklamasi>" + "Dizüstü Bilgisayarlar" + "</Aciklamasi>";
            xml += "</KategoriModel>";
            xml += "</KategoriModels>";
            return Content(xml, "application/xml");
        }
        public string GetString()
        {
            return "String.";
        }
        public EmptyResult GetEmpty()
        {
            return new EmptyResult();
        }
    }
}
