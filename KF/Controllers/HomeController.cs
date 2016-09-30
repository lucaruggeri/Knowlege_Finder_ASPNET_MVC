using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using KF.Models;

namespace KF.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            KF kf = new KF();           
            List<string> localVideosFound = kf.SearchLocalVideos();

            ViewBag.videosFound = localVideosFound;

            return View();
        }
    }
}