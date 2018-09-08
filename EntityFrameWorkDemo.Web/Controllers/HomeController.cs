﻿using EntityFrameWorkDemo.Web.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameWorkDemo.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var temp = this.Client.GetCustomers();
            var temp2 = temp.Where(x => x.Id == 2015).FirstOrDefault().CustomerOrders;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}