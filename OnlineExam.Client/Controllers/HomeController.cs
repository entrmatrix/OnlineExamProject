﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineExam.Models.Accounting;
using OnlineExam.ServiceLayer.Interfaces;
using OnlineExam.ViewModels;
using OnlineExam.ViewModels.Accounting;

namespace OnlineExam.Client.Controllers
{
    public partial class HomeController : Controller
    {
        
        public virtual ActionResult Index()
        {

            return View();
        }

        public virtual ActionResult About()
        {


            return View();
        }

        public virtual ActionResult Contact()
        {

            return View();
        }

       
    }
}