﻿using Microsoft.AspNetCore.Mvc;

namespace AddMVC.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
