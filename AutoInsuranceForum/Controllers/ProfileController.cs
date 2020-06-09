using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoInsuranceForum.Models;
using AutoInsuranceForum.Data;

namespace AutoInsuranceForum.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ForumDBContext _context;
        private readonly UsersViewModel _user;
        public ProfileController(ForumDBContext context)
        {
            _context = context;
            List<UsersViewModel> users = _context.Users.ToList();
            _user = _context.Users.First();
        }
        public IActionResult Profile()
        {
            return View(_user);
        }
    }
}
