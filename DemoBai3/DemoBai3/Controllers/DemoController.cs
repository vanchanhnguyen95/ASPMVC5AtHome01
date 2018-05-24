using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoBai3.Models;

namespace DemoBai3.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Demo()
        {
            //Tạo 1 list về tỉnh thành phố
            List < TinhThanhPho > lstTTP = new List<TinhThanhPho>();
            TinhThanhPho ttp;
            ttp = new TinhThanhPho();
            ttp.MaTinhThanhPho = 1;
            ttp.TenTinhThanhPho = "TP Hồ Chí Minh";
            lstTTP.Add(ttp);
            ttp = new TinhThanhPho();
            ttp.MaTinhThanhPho = 2;
            ttp.TenTinhThanhPho = "Hà Nội";
            lstTTP.Add(ttp);

            //tạo 1 cái ViewBag
            ViewBag.TinhThanhPho = new SelectList
                (lstTTP, "MaTinhThanhPho" , "TenTinhThanhPho");

            return View();
        }

        [HttpPost]
        public ActionResult Demo(FormCollection collection)
        {
            string sValue = collection["TheThao"].ToString();
            return View();
        }

    }
}