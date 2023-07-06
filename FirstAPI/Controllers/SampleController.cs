using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Web.Http;
using System.Net;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : Controller
    {

        SqlConnection Con = new SqlConnection(@"server=DESKTOP-9R4PCGG\SQLEXPRESS;initial catalog=AndonDB;Integrated Security=true" providerName = "System.Data.SqlClient"


        SqlCommand Cmd;
        SqlDataReader DR;
        // GET: Sample
        public ActionResult Index()
        {
            return View();
        }

        // GET: Sample/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sample/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sample/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sample/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sample/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sample/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sample/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
//hello
            }
        }
    }
}
