using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //public string Index()
        //{
        //    return "這是預設Action";
        //}

        //public string Welcome(string name,int age=18)//傳遞參數
        //{
        //    return HttpUtility.HtmlEncode("你好" + name + ",年紀:" + age);
        //}
        public ActionResult Welcome(string name, int numTimes = 1)//傳遞參數
        {
            ViewBag.Message = "你好!" + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }
        public ActionResult Index()//回傳view
        {
            return View();
        }
    }
}