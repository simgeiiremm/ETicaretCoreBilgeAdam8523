using Business.Models;
using Business.Services.Bases;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class KategorilerController : Controller
    {
        private readonly IKategoriService _kategoriService;

        public KategorilerController(IKategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }

        public IActionResult Index() // ~/Kategoriler/Index
        {
            List<KategoriModel> model =_kategoriService.Query().ToList();
            return View(model); //Views/Kategoriler/Index.cshtml
        }

        public IActionResult OlusturGetir() // ~/Kategoriler/OlusturGetir
        {
            return View("OlusturHtml");
        }

        public IActionResult OlusturGonder(string Adi, string Aciklamasi)
        {
            KategoriModel model = new KategoriModel()
            {
                Adi = Adi,
                Aciklamasi = Aciklamasi
            };
            var result = _kategoriService.Add(model);
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
