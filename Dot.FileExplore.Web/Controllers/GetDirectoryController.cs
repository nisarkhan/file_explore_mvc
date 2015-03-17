using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Configuration;

namespace Dot.FileExplore.Web.Controllers
{
    public class GetDirectoryController : Controller
    {
        //
        // GET: /GetDirectory/

        public ActionResult Index()
        {
            string extractedDealerURL = Request.QueryString["aspxerrorpath"].ToString().TrimStart('/');
            string folderPath = ConfigurationManager.AppSettings["FolderLocation"].ToString();
            folderPath += "\\" + extractedDealerURL.Replace("/","\\");
            if (Directory.Exists(folderPath))
            {
                return RedirectToAction("Index", "FileExplore", new { id = extractedDealerURL });
            }
            ViewBag.Message = "Not able to find directory!";
            return View();
        }

    }
}
