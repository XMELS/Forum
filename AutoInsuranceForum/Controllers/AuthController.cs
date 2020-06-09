using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoInsuranceForum.Models;
using AutoInsuranceForum.Data;
using AutoInsuranceForum.Services;

namespace AutoInsuranceForum.Controllers
{
    public class AuthController : Controller
    {
        private readonly ForumDBContext _context;
        private readonly UserServices _services;
        public AuthController(ForumDBContext context)//,UserServices services
        {
            _context = context;
            //_services = services;
        } 
        public IActionResult Auth()
        {
            return View();
        }
        public ActionResult AuthGood(string login, string password)
        {
            return RedirectToAction("Themes");
        }
        public IActionResult Reg()
        {
            return View();
        }
        
    }
}
