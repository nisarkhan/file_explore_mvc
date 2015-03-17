using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dot.FileExplore.Web.Models
{
    public class JsTreeModel
    {
        public string text { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public bool children { get; set; }
    }
}