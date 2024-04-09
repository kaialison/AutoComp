using demo3.Common;
using demo3.Models;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Reflection.Metadata;
using System.Text;

namespace demo3.Areas.admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        XehoifinalContext db = new XehoifinalContext();

        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("username") == null)
            {
                return RedirectToAction("login");
            }
            else
            {
                var q = db.Xses.Select(t => t);
                return View(q);
            }
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "admin123!@#")
            {
                HttpContext.Session.SetString("username", username);
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Tài khoản hoặc mật khẩu chưa chính xác";
                return View();
            }
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            Response.Cookies.Delete("AuthenticationCookieName");
            return RedirectToAction("Login");
        }
        public ActionResult Them()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Them(Xse x)
        {
            var xtim = db.Xses.FirstOrDefault(a => a.Maxe == x.Maxe);
            if(xtim == null)
            {
                db.Xses.Add(x);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Mã xe đã tồn tại";
                return View();

            }
        }
        [HttpGet]
        public ActionResult Sua(int maxe)
        {
            var x = db.Xses.First(a => a.Maxe == maxe);
            return View(x);
        }
        [HttpPost]

        public ActionResult Sua(int maxe, IFormCollection f)
        {
            var xtim = db.Xses.First(a => a.Maxe == maxe);
            xtim.Hopso = f["Hopso"];
            xtim.Kickthuoc = f["Kickthuoc"];
            xtim.Phankhuc = f["Phankhuc"];
            xtim.Tenhang = f["Tenhang"];
            xtim.Phienban = f["Phienban"];
            xtim.Loaixe = f["Loaixe"];
            xtim.Kieudongco = f["Kieudongco"];
            xtim.Dungtich = f["Dungtich"];
            xtim.Congsuat = int.Parse(f["Congsuat"]);
            xtim.Momen = int.Parse(f["Momen"]);
            xtim.Soghe = int.Parse(f["Soghe"]);
            xtim.Kickthuoc = f["Kickthuoc"];
            xtim.Cieudaicoso = int.Parse(f["Cieudaicoso"]);
            xtim.Khoangsanggam = int.Parse(f["Khoangsanggam"]);
            xtim.Sotuikhi = int.Parse(f["Sotuikhi"]);
            xtim.Giathamkhao = int.Parse(f["Giathamkhao"]);
            xtim.Anhxe = Encoding.ASCII.GetBytes(f["Anhxe"]);

            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Xoa(int maxe)
        {
            Xse x = db.Xses.FirstOrDefault(a => a.Maxe == maxe);
            db.Xses.Remove(x);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Thongke() { return View(); }
        public ActionResult Tim(string tenhang)
        {
            var q = from b in db.Xses select b;
            var t = q.Where(x => x.Tenhang.Contains(tenhang));
            return View(t);
        }

    }
    }

