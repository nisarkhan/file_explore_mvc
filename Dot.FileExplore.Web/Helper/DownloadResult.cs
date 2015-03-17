using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dot.FileExplore.Web.Helper
{
    public class DownloadResult : ActionResult
    {
        public DownloadResult()
        {
        }
        public DownloadResult(string fileName)
        {
            this.FileDownloadName = fileName;
        }
        public string VirtualPath { get; set; }
        public string FileDownloadName { get; set; }
        public override void ExecuteResult(ControllerContext context)
        {
           
            this.VirtualPath = ConfigurationManager.AppSettings["TempStore"] + FileDownloadName;

            if (!String.IsNullOrEmpty(FileDownloadName))
            {
                context.HttpContext.Response.AddHeader("content-disposition",
                  "attachment; filename=" + this.FileDownloadName);
            }
            string filePath = context.HttpContext.Server.MapPath(this.VirtualPath);
            context.HttpContext.Response.TransmitFile(filePath);
        }
    }
}