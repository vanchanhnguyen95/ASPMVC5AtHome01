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
            //Cách 1: Lấy dữ liệu là 1 danh sách khách hàng
            //var lstKH = from KH in db.KhachHangs select KH;
            //Cách 2 dùng phương thức hỗ trợ sẵn
            var lstKH = db.KhachHangs;
            return View(lstKH);
        }
        public ActionResult Index1()
        {
            var lstKH = from KH in db.KhachHangs where KH.MaKH == 1 select KH;
            return View(lstKH);
        }

        public ActionResult TruyVan1DoiTuong()
        {

            //Cách 1:Truy vấn 1 đối tượng bằng câu lệnh truy vấn
            //Bước 1:Lấy ra danh sách khách hàng
            var lstKH = from kh in db.KhachHangs  select kh;
            //Bước 2:Lấy ra đối tượng khách hàng
            //KhachHang khang = lstKH.FirstOrDefault();
            //return View(khang);

            //Cách 2: Lấy đối tượng khách hàng dựa trên phương thức hỗ trợ
            KhachHang khang = db.KhachHangs.SingleOrDefault(n=>n.MaKH==2);//trả về đúng dữ liệu ta cần nếu hợp lệ ngược lại trả về null
            return View(khang);
        }

        //Sắp xếp dựa trên phương thức
        public ActionResult SortDuLieu()
        {
            //phương thức sắp xếp dữ liệu
            List<KhachHang> lstKH = db.KhachHangs.OrderByDescending(n => n.TenKH).ToList();
            return View(lstKH);
        }

        //Group Dữ liệu:dùng cách group dữ liệu trên View
        public ActionResult GroupDuLieu()
        {
            //Group dữ liệu
            List<ThanhVien> lstKH = db.ThanhViens.OrderByDescending(n => n.TaiKhoan).ToList();
            return View(lstKH);
        }
    }
}