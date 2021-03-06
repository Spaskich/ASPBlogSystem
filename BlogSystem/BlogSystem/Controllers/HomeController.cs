﻿using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogSystem.Models;

namespace BlogSystem.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Posts
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Posts()
        {
            var posts = db.Posts
                .Include(p => p.Author)
                .OrderByDescending(p => p.Date)
                .Take(4);
            
            return View(posts.ToList());
        }
    }
}