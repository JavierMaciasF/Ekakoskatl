using Ekakoskatl.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ekakoskatl.Web.Controllers
{
    public class VideoController : Controller
    {
        private readonly IVideoServices videoService;

        public VideoController(IVideoServices videoService)
        {
            this.videoService = videoService;
        }
        // GET: Video
        public ActionResult Video()
        {
            videoService.PanelVideo();
            return View();
        }
    }
}