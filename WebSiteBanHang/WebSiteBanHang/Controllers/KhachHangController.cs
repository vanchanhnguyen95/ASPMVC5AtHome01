using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteBanHang.Models;

namespace WebSiteBanHang.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: KhachHang
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        public ActionResult Index()
        {
            //Truy vấn dữ liệu thông qua câu lệnh
            //Đối tượng lstKH sẽ lấy toàn bộ dữ liệu từ bảng KhachHang
            var lstKH = from KH in db.KhachHangs select KH;
            return View(lstKH);
        }
        public ActionResult Index1()
        {
            var lstKH = from KH in db.KhachHangs select KH;
            return View(lstKH);
        }
    }
}