using demo3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using System.Web;
using Microsoft.AspNetCore.Http.Connections;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Data.SqlTypes;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace demo3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public ActionResult Homepage() { return View(); }
        public ActionResult Choice2()
        {

            return View();
        }
        public ActionResult Choice2a()
        {
            return View();
        }
        public ActionResult Choice2gui(Se xe)
        {
            XehoifinalContext db = new XehoifinalContext();
            List<Xse> list = new List<Xse>();
            var q = from a in db.Xses
                    select a;
            list = q.ToList();
            int cs1 = 0, cs2 = 0;
            int mm1 = 0, mm2 = 0;
            double cd1 = 0, cd2 = 0, gam1 = 0, gam2 = 0, tui1 = 0, tui2 = 0, cn1 = 0, cn2 = 0;
            double t1 = 0, t2 = 0;
            string phienban1 = Request.Form["mySelect1"];
            foreach (var item in list)
            {
                if (item.Phienban == phienban1)
                {
                    ViewBag.phienban1 = item.Phienban;
                    ViewBag.hangsx1 = item.Tenhang;
                    ViewBag.momen1 = item.Momen;
                    ViewBag.congsuat1 = item.Congsuat;
                    ViewBag.dungtich1 = item.Dungtich;
                    ViewBag.hopso1 = item.Hopso;
                    ViewBag.phankhuc1 = item.Phankhuc;
                    ViewBag.loaixe1 = item.Loaixe;
                    ViewBag.dongco1 = item.Kieudongco;
                    ViewBag.ghe1 = item.Soghe;
                    ViewBag.kichthuoc1 = item.Kickthuoc;
                    ViewBag.dai1 = item.Cieudaicoso;
                    ViewBag.gam1 = item.Khoangsanggam;
                    ViewBag.tuikhi1 = item.Sotuikhi;
                    ViewBag.gia1 = item.Giathamkhao;
                    cs1 = item.Congsuat;
                    mm1 = item.Momen;
                    cn1 = item.Soghe;
                    cd1 = item.Cieudaicoso;
                    gam1 = item.Khoangsanggam;
                    tui1 = item.Sotuikhi;
                    t1 = item.Giathamkhao;
                    ViewBag.anh1 = item.Anhxe;

                }
            }
            string phienban2 = Request.Form["mySelect2"];
            foreach (var item in list)
            {
                if (item.Phienban == phienban2)
                {
                    ViewBag.phienban2 = item.Phienban;
                    ViewBag.hangsx2 = item.Tenhang;
                    ViewBag.momen2 = item.Momen;
                    ViewBag.congsuat2 = item.Congsuat;
                    ViewBag.dungtich2 = item.Dungtich;
                    ViewBag.hopso2 = item.Hopso;
                    ViewBag.phankhuc2 = item.Phankhuc;
                    ViewBag.loaixe2 = item.Loaixe;
                    ViewBag.dongco2 = item.Kieudongco;
                    ViewBag.ghe2 = item.Soghe;
                    ViewBag.kichthuoc2 = item.Kickthuoc;
                    ViewBag.dai2 = item.Cieudaicoso;
                    ViewBag.gam2 = item.Khoangsanggam;
                    ViewBag.tuikhi2 = item.Sotuikhi;
                    ViewBag.gia2 = item.Giathamkhao;
                    cs2 = item.Congsuat;
                    mm2 = item.Momen;
                    cn2 = item.Soghe;
                    cd2 = item.Cieudaicoso;
                    gam2 = item.Khoangsanggam;
                    tui2 = item.Sotuikhi;
                    t2 = item.Giathamkhao;
                    ViewBag.anh2 = item.Anhxe;

                }
            }

            int maxcs = Math.Max(cs1, cs2);
            int maxmm = Math.Max(mm1, mm2);
            double maxcn = Math.Max(cn1, cn2);
            double maxcd = Math.Max(cd1, cd2);
            double maxgam = Math.Max(gam1, gam2);
            double maxtui = Math.Max(tui1, tui2);
            double maxtien = Math.Max(t1, t2);
            ViewBag.maxcs = maxcs;
            ViewBag.maxmm = maxmm;
            ViewBag.maxcn = maxcn;
            ViewBag.maxcd = maxcd;
            ViewBag.maxgam = maxgam;
            ViewBag.maxtui = maxtui;
            return View("Choice2a", xe);
        }
        /*public ActionResult Choice2gui2(Xe xe2)
        {
            Xehoi3Context db = new Xehoi3Context();
            List<Xe> list = new List<Xe>();
            var q = from a in db.Ses
                    select a;
            list = q.ToList();


            return View("Choice2", xe2);
        }*/
        public ActionResult Choice3a()
        {
            return View();
        }
        public ActionResult Choice3() { return View(); }
        public ActionResult Choice3gui(Se xe)
        {
            int cs1 = 0, cs2 = 0, cs3 = 0, cs4 = 0;
            int mm1 = 0, mm2 = 0, mm3 = 0, mm4 = 0, cn1 = 0, cn2 = 0, cn3 = 0, cn4 = 0;
            double cd1 = 0, cd2 = 0, cd3 = 0, cd4 = 0, gam1 = 0, gam2 = 0, gam3 = 0, gam4 = 0, tui1 = 0, tui2 = 0, tui3 = 0, tui4 = 0;
            double t1 = 0, t2 = 0, t3 = 0, t4 = 0;
            XehoifinalContext db = new XehoifinalContext();
            List<Xse> list = new List<Xse>();
            var q = from a in db.Xses
                    select a;
            list = q.ToList();
            string phienban1 = Request.Form["mySelect1"];
            foreach (var item in list)
            {
                if (item.Phienban == phienban1)
                {
                    ViewBag.phienban1 = item.Phienban;
                    ViewBag.hangsx1 = item.Tenhang;
                    ViewBag.momen1 = item.Momen;
                    ViewBag.congsuat1 = item.Congsuat;
                    ViewBag.dungtich1 = item.Dungtich;
                    ViewBag.hopso1 = item.Hopso;
                    ViewBag.phankhuc1 = item.Phankhuc;
                    ViewBag.loaixe1 = item.Loaixe;
                    ViewBag.dongco1 = item.Kieudongco;
                    ViewBag.ghe1 = item.Soghe;
                    ViewBag.kichthuoc1 = item.Kickthuoc;
                    ViewBag.dai1 = item.Cieudaicoso;
                    ViewBag.gam1 = item.Khoangsanggam;
                    ViewBag.tuikhi1 = item.Sotuikhi;
                    ViewBag.gia1 = item.Giathamkhao;
                    cs1 = item.Congsuat;
                    mm1 = item.Momen;
                    cn1 = item.Soghe;
                    cd1 = item.Cieudaicoso;
                    gam1 = item.Khoangsanggam;
                    tui1 = item.Sotuikhi;
                    t1 = item.Giathamkhao;
                    ViewBag.anh1 = item.Anhxe;

                }
            }
            string phienban2 = Request.Form["mySelect2"];
            foreach (var item in list)
            {
                if (item.Phienban == phienban2)
                {
                    ViewBag.phienban2 = item.Phienban;
                    ViewBag.hangsx2 = item.Tenhang;
                    ViewBag.momen2 = item.Momen;
                    ViewBag.congsuat2 = item.Congsuat;
                    ViewBag.dungtich2 = item.Dungtich;
                    ViewBag.hopso2 = item.Hopso;
                    ViewBag.phankhuc2 = item.Phankhuc;
                    ViewBag.loaixe2 = item.Loaixe;
                    ViewBag.dongco2 = item.Kieudongco;
                    ViewBag.ghe2 = item.Soghe;
                    ViewBag.kichthuoc2 = item.Kickthuoc;
                    ViewBag.dai2 = item.Cieudaicoso;
                    ViewBag.gam2 = item.Khoangsanggam;
                    ViewBag.tuikhi2 = item.Sotuikhi;
                    ViewBag.gia2 = item.Giathamkhao;
                    cs2 = item.Congsuat;
                    mm2 = item.Momen;
                    cn2 = item.Soghe;
                    cd2 = item.Cieudaicoso;
                    gam2 = item.Khoangsanggam;
                    tui2 = item.Sotuikhi;
                    t2 = item.Giathamkhao;
                    ViewBag.anh2 = item.Anhxe;


                }
            }
            string phienban3 = Request.Form["mySelect3"];
            foreach (var item in list)
            {
                if (item.Phienban == phienban3)
                {
                    ViewBag.phienban3 = item.Phienban;
                    ViewBag.hangsx3 = item.Tenhang;
                    ViewBag.momen3 = item.Momen;
                    ViewBag.congsuat3 = item.Congsuat;
                    ViewBag.dungtich3 = item.Dungtich;
                    ViewBag.hopso3 = item.Hopso;
                    ViewBag.phankhuc3 = item.Phankhuc;
                    ViewBag.loaixe3 = item.Loaixe;
                    ViewBag.dongco3 = item.Kieudongco;
                    ViewBag.ghe3 = item.Soghe;
                    ViewBag.kichthuoc3 = item.Kickthuoc;
                    ViewBag.dai3 = item.Cieudaicoso;
                    ViewBag.gam3 = item.Khoangsanggam;
                    ViewBag.tuikhi3 = item.Sotuikhi;
                    ViewBag.gia3 = item.Giathamkhao;
                    cs3 = item.Congsuat;
                    mm3 = item.Momen;
                    cn3 = item.Soghe;
                    cd3 = item.Cieudaicoso;
                    gam3 = item.Khoangsanggam;
                    tui3 = item.Sotuikhi;
                    t3 = item.Giathamkhao;
                    ViewBag.anh3 = item.Anhxe;



                }
            }

            return View("Choice3a", xe);
        }
        public ActionResult Choice4() {
            
            return View(); 
        }
        
        public ActionResult Choice4gui(Se xe)
        {
            int cs1=0, cs2=0, cs3 = 0, cs4 = 0;
            int mm1 = 0, mm2 = 0, mm3 = 0, mm4 = 0,cn1=0,cn2=0,cn3=0,cn4=0;
            double cd1 = 0, cd2 = 0, cd3 = 0, cd4 = 0, gam1 = 0, gam2 = 0, gam3 = 0, gam4 = 0, tui1 = 0,tui2 = 0,tui3 = 0,tui4 = 0;
            double t1 = 0,t2=0,t3=0,t4=0;
            XehoifinalContext db = new XehoifinalContext();
            List<Xse> list = new List<Xse>();
            var q = from a in db.Xses
                    select a;
            list = q.ToList();
            string phienban1 = Request.Form["mySelect1"];
            foreach (var item in list)
            {
                if (item.Phienban == phienban1)
                {
                    ViewBag.phienban1 = item.Phienban;
                    ViewBag.hangsx1 = item.Tenhang;
                    ViewBag.momen1 = item.Momen;
                    ViewBag.congsuat1 = item.Congsuat;
                    ViewBag.dungtich1 = item.Dungtich;
                    ViewBag.hopso1 = item.Hopso;
                    ViewBag.phankhuc1 = item.Phankhuc;
                    ViewBag.loaixe1 = item.Loaixe;
                    ViewBag.dongco1 = item.Kieudongco;
                    ViewBag.ghe1 = item.Soghe;
                    ViewBag.kichthuoc1 = item.Kickthuoc;
                    ViewBag.dai1 = item.Cieudaicoso;
                    ViewBag.gam1 = item.Khoangsanggam;
                    ViewBag.tuikhi1 = item.Sotuikhi;
                    ViewBag.gia1 = item.Giathamkhao;
                    cs1 = item.Congsuat;
                    mm1 = item.Momen;
                    cn1 = item.Soghe;
                    cd1 = item.Cieudaicoso;
                    gam1 = item.Khoangsanggam;
                    tui1 = item.Sotuikhi;
                    t1 = item.Giathamkhao;
                    ViewBag.anh1 = item.Anhxe;

                }
            }
            string phienban2 = Request.Form["mySelect2"];
            foreach (var item in list)
            {
                if (item.Phienban == phienban2)
                {
                    ViewBag.phienban2 = item.Phienban;
                    ViewBag.hangsx2 = item.Tenhang;
                    ViewBag.momen2 = item.Momen;
                    ViewBag.congsuat2 = item.Congsuat;
                    ViewBag.dungtich2 = item.Dungtich;
                    ViewBag.hopso2 = item.Hopso;
                    ViewBag.phankhuc2 = item.Phankhuc;
                    ViewBag.loaixe2 = item.Loaixe;
                    ViewBag.dongco2 = item.Kieudongco;
                    ViewBag.ghe2 = item.Soghe;
                    ViewBag.kichthuoc2 = item.Kickthuoc;
                    ViewBag.dai2 = item.Cieudaicoso;
                    ViewBag.gam2 = item.Khoangsanggam;
                    ViewBag.tuikhi2 = item.Sotuikhi;
                    ViewBag.gia2 = item.Giathamkhao;
                    cs2 = item.Congsuat;
                    mm2 = item.Momen;
                    cn2 = item.Soghe;
                    cd2 = item.Cieudaicoso;
                    gam2 = item.Khoangsanggam;
                    tui2 = item.Sotuikhi;
                    t2 = item.Giathamkhao;
                    ViewBag.anh2 = item.Anhxe;


                }
            }
            string phienban3 = Request.Form["mySelect3"];
            foreach (var item in list)
            {
                if (item.Phienban == phienban3)
                {
                    ViewBag.phienban3 = item.Phienban;
                    ViewBag.hangsx3 = item.Tenhang;
                    ViewBag.momen3 = item.Momen;
                    ViewBag.congsuat3 = item.Congsuat;
                    ViewBag.dungtich3 = item.Dungtich;
                    ViewBag.hopso3 = item.Hopso;
                    ViewBag.phankhuc3 = item.Phankhuc;
                    ViewBag.loaixe3 = item.Loaixe;
                    ViewBag.dongco3 = item.Kieudongco;
                    ViewBag.ghe3 = item.Soghe;
                    ViewBag.kichthuoc3 = item.Kickthuoc;
                    ViewBag.dai3 = item.Cieudaicoso;
                    ViewBag.gam3 = item.Khoangsanggam;
                    ViewBag.tuikhi3 = item.Sotuikhi;
                    ViewBag.gia3 = item.Giathamkhao;
                    cs3 = item.Congsuat;
                    mm3 = item.Momen;
                    cn3 = item.Soghe;
                    cd3 = item.Cieudaicoso;
                    gam3 = item.Khoangsanggam;
                    tui3 = item.Sotuikhi;
                    t3 = item.Giathamkhao;
                    ViewBag.anh3 = item.Anhxe;


                }
            }
            string phienban4 = Request.Form["mySelect4"];
            foreach (var item in list)
            {
                if (item.Phienban == phienban4)
                {
                    ViewBag.phienban4 = item.Phienban;
                    ViewBag.hangsx4 = item.Tenhang;
                    ViewBag.momen4 = item.Momen;
                    ViewBag.congsuat4 = item.Congsuat;
                    ViewBag.dungtich4 = item.Dungtich;
                    ViewBag.hopso4 = item.Hopso;
                    ViewBag.phankhuc4 = item.Phankhuc;
                    ViewBag.loaixe4 = item.Loaixe;
                    ViewBag.dongco4 = item.Kieudongco;
                    ViewBag.ghe4 = item.Soghe;
                    ViewBag.kichthuoc4 = item.Kickthuoc;
                    ViewBag.dai4 = item.Cieudaicoso;
                    ViewBag.gam4 = item.Khoangsanggam;
                    ViewBag.tuikhi4 = item.Sotuikhi;
                    ViewBag.gia4 = item.Giathamkhao;
                    cs4 = item.Congsuat;
                    mm4 = item.Momen;
                    cn4 = item.Soghe;
                    cd4 = item.Cieudaicoso;
                    gam4 = item.Khoangsanggam;
                    tui4 = item.Sotuikhi;
                    t4 = item.Giathamkhao;
                    ViewBag.anh4 = item.Anhxe;

                }
            }
            int maxcs = Math.Max(Math.Max(Math.Max(cs1, cs2), cs3), cs4);
            int maxmm = Math.Max(Math.Max(Math.Max(mm1, mm2), mm3), mm4);
            int maxcn = Math.Max(Math.Max(Math.Max(cn1, cn2), cn3), cn4);
            double maxcd = Math.Max(Math.Max(Math.Max(cd1, cd2), cd3), cd4);
            double maxgam = Math.Max(Math.Max(Math.Max(gam1, gam2), gam3), gam4);
            double maxtui = Math.Max(Math.Max(Math.Max(tui1, tui2), tui3), tui4);
            double maxtien = Math.Max(Math.Max(Math.Max(t1, t2), t3), t4);


            /*           SqlMoney maxtien = Math.Max(Math.Max(Math.Max(t1, t2), t3), t4);
            */
            ViewBag.maxcs=maxcs;
            ViewBag.maxmm = maxmm; 
            ViewBag.maxcn=maxcn; 
            ViewBag.maxcd=maxcd; 
            ViewBag.maxgam=maxgam;
            ViewBag.maxtui=maxtui;
            ViewBag.maxtien = maxtien;
            return View("Choice4a", xe);
        }
        
        public ActionResult Viral1()
        {
            int cs1 = 0, cs2 = 0;
            int mm1 = 0, mm2 = 0;
            double cd1 = 0, cd2 = 0, gam1 = 0, gam2 = 0, tui1 = 0, tui2 = 0, cn1=0,cn2=0;
            double t1 = 0, t2 = 0;
            XehoifinalContext db = new XehoifinalContext();
            List<Xse> list = new List<Xse>();
            var q = from a in db.Xses
                    select a;
            list = q.ToList();
            string phienban1 = "Accent 1.4AT";
            foreach (var item in list)
            {
                if (item.Phienban == phienban1)
                {
                    ViewBag.phienban1 = item.Phienban;
                    ViewBag.hangsx1 = item.Tenhang;
                    ViewBag.momen1 = item.Momen;
                    ViewBag.congsuat1 = item.Congsuat;
                    ViewBag.dungtich1 = item.Dungtich;
                    ViewBag.hopso1 = item.Hopso;
                    ViewBag.phankhuc1 = item.Phankhuc;
                    ViewBag.loaixe1 = item.Loaixe;
                    ViewBag.dongco1 = item.Kieudongco;
                    ViewBag.ghe1 = item.Soghe;
                    ViewBag.kichthuoc1 = item.Kickthuoc;
                    ViewBag.dai1 = item.Cieudaicoso;
                    ViewBag.gam1 = item.Khoangsanggam;
                    ViewBag.tuikhi1 = item.Sotuikhi;
                    ViewBag.gia1 = item.Giathamkhao;
                    cs1 = item.Congsuat;
                    mm1 = item.Momen;
                    cn1 = item.Soghe;
                    cd1 = item.Cieudaicoso;
                    gam1 = item.Khoangsanggam;
                    tui1 = item.Sotuikhi;
                    t1 = item.Giathamkhao;
                    ViewBag.anh1 = item.Anhxe;

                }
            }
            string phienban2 = "Vios G";
            foreach (var item in list)
            {
                if (item.Phienban == phienban2)
                {
                    ViewBag.phienban2 = item.Phienban;
                    ViewBag.hangsx2 = item.Tenhang;
                    ViewBag.momen2 = item.Momen;
                    ViewBag.congsuat2 = item.Congsuat;
                    ViewBag.dungtich2 = item.Dungtich;
                    ViewBag.hopso2 = item.Hopso;
                    ViewBag.phankhuc2 = item.Phankhuc;
                    ViewBag.loaixe2 = item.Loaixe;
                    ViewBag.dongco2 = item.Kieudongco;
                    ViewBag.ghe2 = item.Soghe;
                    ViewBag.kichthuoc2 = item.Kickthuoc;
                    ViewBag.dai2 = item.Cieudaicoso;
                    ViewBag.gam2 = item.Khoangsanggam;
                    ViewBag.tuikhi2 = item.Sotuikhi;
                    ViewBag.gia2 = item.Giathamkhao;
                    cs2 = item.Congsuat;
                    mm2 = item.Momen;
                    cn2 = item.Soghe;
                    cd2 = item.Cieudaicoso;
                    gam2 = item.Khoangsanggam;
                    tui2 = item.Sotuikhi;
                    t2 = item.Giathamkhao;
                    ViewBag.anh2 = item.Anhxe;


                }
            }
            
            int maxcs = Math.Max(cs1, cs2);
            int maxmm = Math.Max(mm1, mm2);
            double maxcn = Math.Max(cn1, cn2);
            double maxcd = Math.Max(cd1, cd2);
            double maxgam = Math.Max(gam1, gam2);
            double maxtui = Math.Max(tui1, tui2);
            double maxtien = Math.Max(t1, t2);
            ViewBag.maxcs = maxcs;
            ViewBag.maxmm = maxmm;
            ViewBag.maxcn = maxcn;
            ViewBag.maxcd = maxcd;
            ViewBag.maxgam = maxgam;
            ViewBag.maxtui = maxtui;
            ViewBag.maxtien = maxtien;
            return View("Viral1");
        }

        public ActionResult Viral2()
        {
            int cs1 = 0, cs2 = 0;
            int mm1 = 0, mm2 = 0;
            double cd1 = 0, cd2 = 0, gam1 = 0, gam2 = 0, tui1 = 0, tui2 = 0, cn1 = 0, cn2 = 0;
            double t1 = 0, t2 = 0;
            XehoifinalContext db = new XehoifinalContext();
            List<Xse> list = new List<Xse>();
            var q = from a in db.Xses
                    select a;
            list = q.ToList();
            string phienban1 = "Attrage CVT";
            foreach (var item in list)
            {
                if (item.Phienban == phienban1)
                {
                    ViewBag.phienban1 = item.Phienban;
                    ViewBag.hangsx1 = item.Tenhang;
                    ViewBag.momen1 = item.Momen;
                    ViewBag.congsuat1 = item.Congsuat;
                    ViewBag.dungtich1 = item.Dungtich;
                    ViewBag.hopso1 = item.Hopso;
                    ViewBag.phankhuc1 = item.Phankhuc;
                    ViewBag.loaixe1 = item.Loaixe;
                    ViewBag.dongco1 = item.Kieudongco;
                    ViewBag.ghe1 = item.Soghe;
                    ViewBag.kichthuoc1 = item.Kickthuoc;
                    ViewBag.dai1 = item.Cieudaicoso;
                    ViewBag.gam1 = item.Khoangsanggam;
                    ViewBag.tuikhi1 = item.Sotuikhi;
                    ViewBag.gia1 = item.Giathamkhao;
                    cs1 = item.Congsuat;
                    mm1 = item.Momen;
                    cn1 = item.Soghe;
                    cd1 = item.Cieudaicoso;
                    gam1 = item.Khoangsanggam;
                    tui1 = item.Sotuikhi;
                    t1 = item.Giathamkhao;
                    ViewBag.anh1 = item.Anhxe;

                }
            }
            string phienban2 = "Almera EL";
            foreach (var item in list)
            {
                if (item.Phienban == phienban2)
                {
                    ViewBag.phienban2 = item.Phienban;
                    ViewBag.hangsx2 = item.Tenhang;
                    ViewBag.momen2 = item.Momen;
                    ViewBag.congsuat2 = item.Congsuat;
                    ViewBag.dungtich2 = item.Dungtich;
                    ViewBag.hopso2 = item.Hopso;
                    ViewBag.phankhuc2 = item.Phankhuc;
                    ViewBag.loaixe2 = item.Loaixe;
                    ViewBag.dongco2 = item.Kieudongco;
                    ViewBag.ghe2 = item.Soghe;
                    ViewBag.kichthuoc2 = item.Kickthuoc;
                    ViewBag.dai2 = item.Cieudaicoso;
                    ViewBag.gam2 = item.Khoangsanggam;
                    ViewBag.tuikhi2 = item.Sotuikhi;
                    ViewBag.gia2 = item.Giathamkhao;
                    cs2 = item.Congsuat;
                    mm2 = item.Momen;
                    cn2 = item.Soghe;
                    cd2 = item.Cieudaicoso;
                    gam2 = item.Khoangsanggam;
                    tui2 = item.Sotuikhi;
                    t2 = item.Giathamkhao;
                    ViewBag.anh2 = item.Anhxe;


                }
            }

            int maxcs = Math.Max(cs1, cs2);
            int maxmm = Math.Max(mm1, mm2);
            double maxcn = Math.Max(cn1, cn2);
            double maxcd = Math.Max(cd1, cd2);
            double maxgam = Math.Max(gam1, gam2);
            double maxtui = Math.Max(tui1, tui2);
            double maxtien = Math.Max(t1, t2);
            ViewBag.maxcs = maxcs;
            ViewBag.maxmm = maxmm;
            ViewBag.maxcn = maxcn;
            ViewBag.maxcd = maxcd;
            ViewBag.maxgam = maxgam;
            ViewBag.maxtui = maxtui;
            ViewBag.maxtien = maxtien;
            return View("Viral1");
        }
        public ActionResult Viral3()
        {
            int cs1 = 0, cs2 = 0;
            int mm1 = 0, mm2 = 0;
            double cd1 = 0, cd2 = 0, gam1 = 0, gam2 = 0, tui1 = 0, tui2 = 0, cn1 = 0, cn2 = 0;
            double t1 = 0, t2 = 0;
            XehoifinalContext db = new XehoifinalContext();
            List<Xse> list = new List<Xse>();
            var q = from a in db.Xses
                    select a;
            list = q.ToList();
            string phienban1 = "C200 Avantgarde";
            foreach (var item in list)
            {
                if (item.Phienban == phienban1)
                {
                    ViewBag.phienban1 = item.Phienban;
                    ViewBag.hangsx1 = item.Tenhang;
                    ViewBag.momen1 = item.Momen;
                    ViewBag.congsuat1 = item.Congsuat;
                    ViewBag.dungtich1 = item.Dungtich;
                    ViewBag.hopso1 = item.Hopso;
                    ViewBag.phankhuc1 = item.Phankhuc;
                    ViewBag.loaixe1 = item.Loaixe;
                    ViewBag.dongco1 = item.Kieudongco;
                    ViewBag.ghe1 = item.Soghe;
                    ViewBag.kichthuoc1 = item.Kickthuoc;
                    ViewBag.dai1 = item.Cieudaicoso;
                    ViewBag.gam1 = item.Khoangsanggam;
                    ViewBag.tuikhi1 = item.Sotuikhi;
                    ViewBag.gia1 = item.Giathamkhao;
                    cs1 = item.Congsuat;
                    mm1 = item.Momen;
                    cn1 = item.Soghe;
                    cd1 = item.Cieudaicoso;
                    gam1 = item.Khoangsanggam;
                    tui1 = item.Sotuikhi;
                    t1 = item.Giathamkhao;
                    ViewBag.anh1 = item.Anhxe;

                }
            }
            string phienban2 = "320i Sport Line";
            foreach (var item in list)
            {
                if (item.Phienban == phienban2)
                {
                    ViewBag.phienban2 = item.Phienban;
                    ViewBag.hangsx2 = item.Tenhang;
                    ViewBag.momen2 = item.Momen;
                    ViewBag.congsuat2 = item.Congsuat;
                    ViewBag.dungtich2 = item.Dungtich;
                    ViewBag.hopso2 = item.Hopso;
                    ViewBag.phankhuc2 = item.Phankhuc;
                    ViewBag.loaixe2 = item.Loaixe;
                    ViewBag.dongco2 = item.Kieudongco;
                    ViewBag.ghe2 = item.Soghe;
                    ViewBag.kichthuoc2 = item.Kickthuoc;
                    ViewBag.dai2 = item.Cieudaicoso;
                    ViewBag.gam2 = item.Khoangsanggam;
                    ViewBag.tuikhi2 = item.Sotuikhi;
                    ViewBag.gia2 = item.Giathamkhao;
                    cs2 = item.Congsuat;
                    mm2 = item.Momen;
                    cn2 = item.Soghe;
                    cd2 = item.Cieudaicoso;
                    gam2 = item.Khoangsanggam;
                    tui2 = item.Sotuikhi;
                    t2 = item.Giathamkhao;
                    ViewBag.anh2 = item.Anhxe;


                }
            }

            int maxcs = Math.Max(cs1, cs2);
            int maxmm = Math.Max(mm1, mm2);
            double maxcn = Math.Max(cn1, cn2);
            double maxcd = Math.Max(cd1, cd2);
            double maxgam = Math.Max(gam1, gam2);
            double maxtui = Math.Max(tui1, tui2);
            double maxtien = Math.Max(t1, t2);
            ViewBag.maxcs = maxcs;
            ViewBag.maxmm = maxmm;
            ViewBag.maxcn = maxcn;
            ViewBag.maxcd = maxcd;
            ViewBag.maxgam = maxgam;
            ViewBag.maxtui = maxtui;
            ViewBag.maxtien = maxtien;
            return View("Viral1");
        }
        public ActionResult Viral4()
        {
            int cs1 = 0, cs2 = 0;
            int mm1 = 0, mm2 = 0;
            double cd1 = 0, cd2 = 0, gam1 = 0, gam2 = 0, tui1 = 0, tui2 = 0, cn1 = 0, cn2 = 0;
            double t1 = 0, t2 = 0;
            XehoifinalContext db = new XehoifinalContext();
            List<Xse> list = new List<Xse>();
            var q = from a in db.Xses
                    select a;
            list = q.ToList();
            string phienban1 = "Everest Titanium 2.0 AT 4x2";
            foreach (var item in list)
            {
                if (item.Phienban == phienban1)
                {
                    ViewBag.phienban1 = item.Phienban;
                    ViewBag.hangsx1 = item.Tenhang;
                    ViewBag.momen1 = item.Momen;
                    ViewBag.congsuat1 = item.Congsuat;
                    ViewBag.dungtich1 = item.Dungtich;
                    ViewBag.hopso1 = item.Hopso;
                    ViewBag.phankhuc1 = item.Phankhuc;
                    ViewBag.loaixe1 = item.Loaixe;
                    ViewBag.dongco1 = item.Kieudongco;
                    ViewBag.ghe1 = item.Soghe;
                    ViewBag.kichthuoc1 = item.Kickthuoc;
                    ViewBag.dai1 = item.Cieudaicoso;
                    ViewBag.gam1 = item.Khoangsanggam;
                    ViewBag.tuikhi1 = item.Sotuikhi;
                    ViewBag.gia1 = item.Giathamkhao;
                    cs1 = item.Congsuat;
                    mm1 = item.Momen;
                    cn1 = item.Soghe;
                    cd1 = item.Cieudaicoso;
                    gam1 = item.Khoangsanggam;
                    tui1 = item.Sotuikhi;
                    t1 = item.Giathamkhao;
                    ViewBag.anh1 = item.Anhxe;

                }
            }
            string phienban2 = "VF 8 Eco";
            foreach (var item in list)
            {
                if (item.Phienban == phienban2)
                {
                    ViewBag.phienban2 = item.Phienban;
                    ViewBag.hangsx2 = item.Tenhang;
                    ViewBag.momen2 = item.Momen;
                    ViewBag.congsuat2 = item.Congsuat;
                    ViewBag.dungtich2 = item.Dungtich;
                    ViewBag.hopso2 = item.Hopso;
                    ViewBag.phankhuc2 = item.Phankhuc;
                    ViewBag.loaixe2 = item.Loaixe;
                    ViewBag.dongco2 = item.Kieudongco;
                    ViewBag.ghe2 = item.Soghe;
                    ViewBag.kichthuoc2 = item.Kickthuoc;
                    ViewBag.dai2 = item.Cieudaicoso;
                    ViewBag.gam2 = item.Khoangsanggam;
                    ViewBag.tuikhi2 = item.Sotuikhi;
                    ViewBag.gia2 = item.Giathamkhao;
                    cs2 = item.Congsuat;
                    mm2 = item.Momen;
                    cn2 = item.Soghe;
                    cd2 = item.Cieudaicoso;
                    gam2 = item.Khoangsanggam;
                    tui2 = item.Sotuikhi;
                    t2 = item.Giathamkhao;
                    ViewBag.anh2 = item.Anhxe;


                }
            }

            int maxcs = Math.Max(cs1, cs2);
            int maxmm = Math.Max(mm1, mm2);
            double maxcn = Math.Max(cn1, cn2);
            double maxcd = Math.Max(cd1, cd2);
            double maxgam = Math.Max(gam1, gam2);
            double maxtui = Math.Max(tui1, tui2);
            double maxtien = Math.Max(t1, t2);
            ViewBag.maxcs = maxcs;
            ViewBag.maxmm = maxmm;
            ViewBag.maxcn = maxcn;
            ViewBag.maxcd = maxcd;
            ViewBag.maxgam = maxgam;
            ViewBag.maxtui = maxtui;
            ViewBag.maxtien = maxtien;
            return View("Viral1");
        }
        public ActionResult Choice4a() { return View(); }
        public ActionResult Search() { return View(); }
        public ActionResult Search2() { return View(); }
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}