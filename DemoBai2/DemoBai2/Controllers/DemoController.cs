using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoBai2.Models;

namespace DemoBai2.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection f)
        {
            //cách 1 tạo cứng
            //HocSinh hs = new HocSinh();
            //hs.MaHS = 01;
            //hs.TenHS = "Nguyễn Văn A";

            //cách truyền từ ngoài view
            GiaoVien gv = new GiaoVien();
            gv.MaGV = int.Parse(f["txtMaGV"].ToString());
            gv.TenGV = f.Get("txtTenGV").ToString();
            return View(gv);
        }
    }
}