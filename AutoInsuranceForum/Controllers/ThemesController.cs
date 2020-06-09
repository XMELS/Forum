using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoInsuranceForum.Data;
using AutoInsuranceForum.Models;
using AutoInsuranceForum.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoInsuranceForum.Controllers
{
    public class ThemesController : Controller
    {
        private readonly ForumDBContext _context;
        private readonly UsersViewModel _user;
        private readonly UserServices _services;
        public ThemesController(ForumDBContext context)//, UserServices services
        {
            
            _context = context;
            //_services = services;
            List<CommentsViewModel> comments = _context.Comments.ToList();
            List<ThemesViewModel> themes = _context.Themes.ToList();
            List<UsersViewModel> users = _context.Users.ToList();
            _user = _context.Users.First();
        }
        
        public IActionResult Comment_Add(string Comment, int Comment_Theme_Id)
        {
            var comment = new CommentsViewModel();
            comment.Comment_Content = Comment;
            comment.Comment_Theme_Id = Comment_Theme_Id;
            comment.Comment_Date = DateTime.Now;
            comment.Comment_Files = "/";
            comment.Comment_Creator = _user.Users_Id;
            comment.User_Comment = _user;
            _context.Comments.Add(comment);
            _context.SaveChanges();
            return RedirectToAction("Theme", new {id = Comment_Theme_Id});
        }
        // GET: Themes
        public ActionResult Themes()
        {
            //if (_services.GetLogin("Admin", "110101")== null) 
            //{
            //    RedirectToAction("Auth");
            //}
            return View(_context.Themes.ToList());
        }
        public IActionResult Theme(int id)
        {
            //if (!TempData.ContainsKey("Id"))
            //    TempData["Id"] = id;
            //else
            //{
            //    id = (int)TempData["Id"];
            //    TempData.Remove("Id");
            //}
            return View(_context.Themes.FirstOrDefault(r=>r.Themes_Id == id));
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateGood(string Theme_Name, string Content)
        {
            var theme = new ThemesViewModel();
            theme.Themes_Date = DateTime.Now;
            theme.Themes_Name = Theme_Name;
            theme.Themes_Content = Content;
            theme.Themes_Creator = _user.Users_Id;
            theme.User = _user;
            _context.Themes.Add(theme);
            _context.SaveChanges();
            return RedirectToAction("Themes");
        }

    }
}