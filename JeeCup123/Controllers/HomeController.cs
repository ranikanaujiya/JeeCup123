using JeeCup123.Models;
using JeeCup123.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JeeCup123.Controllers
{
   
    public class HomeController : Controller

    {
        DBLayer db = new DBLayer();
        // GET: Home
        public ActionResult Registion()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Servic()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveRecord(String Name, String FatherName, String MotherName, String DOB, String Gender)
        {
            RegisterModel model = new RegisterModel();
            model.name = Name;
            model.father_name = FatherName;
            model.mother_name = MotherName;
            model.dob = DOB;
            model.gender = Gender;

            var res = db.InsertData_RegFrom(model);

            return Json(new { message = res.massage, success=true});
        }

        public ActionResult ShowData()
        {

            var abc = db.GetDatafromProc().ToList();
            return View(abc);

        }
    }
}