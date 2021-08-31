using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace n3108.Controllers
{
    public class GiaiPTController : Controller
    {
        GiaiPT gpt = new GiaiPT();
        // GET: GiaiPT
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TimNghiem(string soA, string soB)
        {
            double soA1 = double.Parse(soA);
            double soB1 = double.Parse(soB);
            ViewBag.nghiempt = gpt.GiaiPhuongTrinhBacNhat(soA1, soB1);
            return View();
        }
    }
}