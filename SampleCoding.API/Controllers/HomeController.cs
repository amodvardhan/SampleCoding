﻿using SampleCoding.DAL.Repositories;
using System.Web.Mvc;

namespace SampleCoding.API.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;

        public HomeController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var userList = _userRepository.GetUserList();
            return View();
        }
    }
}
