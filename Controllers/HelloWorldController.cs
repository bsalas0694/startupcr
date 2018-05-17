using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using startupcr.Models;

namespace startupcr.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {   
            ViewData["Message"]="Hello, This is my view";
            return View();
        }
        public IActionResult Welcome()
        {
            ViewData["Message"]="Hello, Welcome to HelloWorld Application";
            return View();
        }
    }
}