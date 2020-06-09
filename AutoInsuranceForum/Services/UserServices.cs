using AutoInsuranceForum.Data;
using AutoInsuranceForum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoInsuranceForum.Services
{
    public class UserServices
    {
        private readonly ForumDBContext _context;
        private readonly UsersViewModel _user;
        public UserServices(ForumDBContext context)
        {
            _context = context;
            List<UsersViewModel> users = _context.Users.ToList();
        }
        public string GetLogin(string login, string password)
        {
            if (_context.Users.FirstOrDefault(_user => _user.Users_Login == login && _user.Users_Password == password)!=null)
            {
                return login;
            }
            return null;
        }
        public bool RegisterService(string login, string password, string name, string city, string email)
        {
            if (_context.Users.Any(_user => _user.Users_Login == login))
            {
                return false;
            }
            else 
            {
                var UserCreat = new UsersViewModel();
                UserCreat.Users_Img = "/images/avatar/0.jpg";
                UserCreat.Users_Login = login;
                UserCreat.Users_Name = name;
                UserCreat.Users_Password = password;
                UserCreat.Users_Email = email;
                UserCreat.Users_City = city;
                _context.Users.Add(UserCreat);
                _context.SaveChanges();
            }
            return true;
        }
    }
}
