using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EchoBox.Models;
using SpotifyAPI.Web; //Base Namespace
using SpotifyAPI.Web.Auth; //All Authentication-related classes
using SpotifyAPI.Web.Enums; //Enums
using SpotifyAPI.Web.Models; //Models for the JSON-responses

namespace EchoBox.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Signup()
        {
            ViewBag.Message = "Sign up here.";
            return View();
        }

        public ActionResult Spotify()
        {
            ViewBag.Message = "Access Spotify's API Here.";
            return View();
        }
        
        
    }
}
//SpotifyAPI-NET URL: https://github.com/JohnnyCrazy/SpotifyAPI-NET
//Getting started: https://johnnycrazy.github.io/SpotifyAPI-NET/SpotifyWebAPI/gettingstarted/
