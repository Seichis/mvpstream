﻿using Microsoft.AspNetCore.Mvc;

namespace MVPStream.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error404()
        {
            return View();
        }
        public IActionResult Error500()
        {
            return View();
        }
    }
}