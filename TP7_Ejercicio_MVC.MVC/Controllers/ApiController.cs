using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace TP7_Ejercicio_MVC.MVC.Controllers
{
    public class ApiController : Controller
    {

        // GET: Api
        public ActionResult Index()
        {
            return View();
        }

        public async System.Threading.Tasks.Task<ActionResult> ApiViewAsync()
        {
            string html = "https://api.thecatapi.com/v1/images/search";
            HttpClient cliente = new HttpClient();
            var webContains = await cliente.GetStringAsync(html);
            var lista = JsonConvert.DeserializeObject<List<DataView>>(webContains);

            return View(lista);

        }

        public ActionResult New()
        {
            return RedirectToAction("Index", "Api");
        }
    }
}