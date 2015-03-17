using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dot.FileExplore.Web.Models
{
    public class FileExploreModel
    {
        public string FileTitle { get; set; }
        public string RootPath { get; set; }
        public string CurrentPath { get; set; }
    }
}