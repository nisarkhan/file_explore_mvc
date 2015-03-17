using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dot.FileExplore.Web.Models
{
    public class FolderModel
    {
        public string text { get; set; }
        public string id { get; set; }
        public string size { get; set; }
        public string date { get; set; }
        public string type { get; set; }
        public List<FolderModel> children { get; set; }
    }
}