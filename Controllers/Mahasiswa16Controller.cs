using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P6_1_0320190016.Controllers
{
    public class Mahasiswa16Controller : Controller
    {
        // GET: Mahasiswa16
        public ActionResult Index()
        {
            //instantiasi data context ke linq yg baru dibuat
            var db = new LINQ016DataContext();

            //select tabel
            var listMhs = from Mahasiswa in db.Mahasiswas select Mahasiswa;

            //membuat list

            var mhs = new List<P6_1_0320190016.Models.Mahasiswa16>();

            if (listMhs.Any())
            {
                foreach (var eachMhs in listMhs)
                {
                    mhs.Add(new P6_1_0320190016.Models.Mahasiswa16() 
                    {
                        nim = eachMhs.nim,
                        nama = eachMhs.nama,
                        alamat = eachMhs.alamat,
                        email = eachMhs.email,
                        tgl_lahir = eachMhs.tgl_lahir
                    });
                }
            }
            return View(mhs);
        }

        public ActionResult Create(Mahasiswa mahasiswa)
        {
            try
            {
                var db = new LINQ016DataContext();
                db.Mahasiswas.InsertOnSubmit(mahasiswa);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Edit(string id, Mahasiswa dtlMhs)
        {
            try
            {
                var db = new LINQ016DataContext();
                var mhs = db.Mahasiswas.FirstOrDefault(mhsId => mhsId.nim == id);

                if (mhs != null)
                {
                    mhs.nim = dtlMhs.nim;
                    mhs.nama = dtlMhs.nama;
                    mhs.alamat = dtlMhs.alamat;
                    mhs.email = dtlMhs.email;
                    mhs.tgl_lahir = dtlMhs.tgl_lahir;

                    db.SubmitChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        public ActionResult Edit(string id)
        {
            var db = new LINQ016DataContext();
            var dtlMhs = db.Mahasiswas.FirstOrDefault(mhsId => mhsId.nim == id);
            var mhs = new P6_1_0320190016.Models.Mahasiswa16();

            if(dtlMhs != null)
            {
                mhs.nim = dtlMhs.nim;
                mhs.nama = dtlMhs.nama;
                mhs.alamat = dtlMhs.alamat;
                mhs.email = dtlMhs.email;
                mhs.tgl_lahir = dtlMhs.tgl_lahir;
            }

            return View(mhs);
        }

        public ActionResult Details(string id)
        {
            var db = new LINQ016DataContext();
            var dtlMhs = db.Mahasiswas.FirstOrDefault(mhsId => mhsId.nim == id);
            var mhs = new P6_1_0320190016.Models.Mahasiswa16();

            if (dtlMhs != null)
            {
                mhs.nim = dtlMhs.nim;
                mhs.nama = dtlMhs.nama;
                mhs.alamat = dtlMhs.alamat;
                mhs.email = dtlMhs.email;
                mhs.tgl_lahir = dtlMhs.tgl_lahir;
            }

            return View(mhs);
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            var db = new LINQ016DataContext();
            var dtlMhs = db.Mahasiswas.FirstOrDefault(mhsId => mhsId.nim == id);
            var mhs = new P6_1_0320190016.Models.Mahasiswa16();

            if (dtlMhs != null)
            {
                mhs.nim = dtlMhs.nim;
                mhs.nama = dtlMhs.nama;
                mhs.alamat = dtlMhs.alamat;
                mhs.email = dtlMhs.email;
                mhs.tgl_lahir = dtlMhs.tgl_lahir;
            }

            return View(mhs);
        }

        public ActionResult Delete(string id, Mahasiswa dtlMhs)
        {
            try
            {
                var db = new LINQ016DataContext();
                var mhs = db.Mahasiswas.FirstOrDefault(mhsId => mhsId.nim == id);
                db.Mahasiswas.DeleteOnSubmit(mhs);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }
    }
}