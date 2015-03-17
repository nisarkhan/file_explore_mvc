using Dot.FileExplore.Web.Helper;
using Dot.FileExplore.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Dot.FileExplore.Web.Controllers
{
    public class FileExploreController : Controller
    {
        //
        // GET: /FileExplore/
        private bool HasSubfolders(string path)
        {
            IEnumerable<string> subfolders = null;
            try
            {
                subfolders = Directory.EnumerateDirectories(path);
            }
            catch (UnauthorizedAccessException)
            {

            }
            return subfolders != null && subfolders.Any();
        }

        public ActionResult Index(string id)
        {
            //Display Title
            FileExploreModel explore = new FileExploreModel();
            explore.FileTitle = ConfigurationManager.AppSettings["FileTitle"].ToString();
            if (!string.IsNullOrEmpty(id))
            {
                explore.CurrentPath = ConfigurationManager.AppSettings["FolderLocation"].ToString() + "\\" + Server.UrlDecode(id).Replace("/", "\\");
            }
            else
            {
                explore.RootPath = ConfigurationManager.AppSettings["FolderLocation"].ToString();
                explore.CurrentPath = explore.RootPath;
            }
            return View(explore);
        }
        private void PopulateTree(string dir, FolderModel node, bool flag)
        {
            try
            {
                string path = ConfigurationManager.AppSettings["FolderLocation"].ToString();
                string str = dir;
                var error = str.LastIndexOf(".");
                if (error == -1 && !string.IsNullOrEmpty(str) && str.Length >= path.Length)
                {
                    if (node.children == null)
                    {
                        node.children = new List<FolderModel>();
                    }

                    // get the information of the directory
                    DirectoryInfo directory = new DirectoryInfo(dir);

                    var folders = directory.GetDirectories();
                    // loop through each subdirectory
                    foreach (DirectoryInfo d in folders)
                    {
                        if (d != null && d.Attributes != null && !d.Attributes.HasFlag(FileAttributes.System) && !d.Attributes.HasFlag(FileAttributes.Hidden))
                        {
                            // create a new node
                            FolderModel t = new FolderModel();
                            t.id = d.FullName;
                            t.text = d.Name.ToString();
                            t.date = d.LastAccessTime.ToString();
                            t.type = "folder";
                            // populate the new node recursively
                            //PopulateTree(d.FullName, t ,flag);
                            node.children.Add(t); // add the node to the "master" node
                        }
                    }
                    // lastly, loop through each file in the directory, and add these as nodes
                    if (flag)
                    {
                        var file = directory.GetFiles();
                        foreach (FileInfo f in file)
                        {
                            if (f != null && f.Attributes != null && !f.Attributes.HasFlag(FileAttributes.System) && !f.Attributes.HasFlag(FileAttributes.Hidden))
                            {
                                // create a new node
                                FolderModel t = new FolderModel();
                                t.id = f.FullName;
                                t.text = f.Name.ToString();
                                t.size = f.Length.ToString();
                                t.date = f.LastAccessTime.ToString();
                                t.type = "file";
                                // add it to the "master"
                                node.children.Add(t);
                            }
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException) { }
        }


        [HttpGet]
        public JsonResult FolderInfo(string id)
        {

            JsTreeModel rootNode = new JsTreeModel();

            string rootPath = string.Empty;
            if (!string.IsNullOrEmpty(id) && id != "#")
            {
                rootPath = Server.UrlDecode(id).Replace("/", "\\");
            }
            else
            {
                rootPath = ConfigurationManager.AppSettings["FolderLocation"].ToString();
            }
            rootNode.text = rootPath;
            rootNode.id = rootPath;
            rootNode.children = true;

            return Json(rootNode, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult SubFolderInfo(string id)
        {

            List<JsTreeModel> rootNode = new List<JsTreeModel>();
            //rootNode.text = "ROOT";

            DirectoryInfo directory = new DirectoryInfo(Server.UrlDecode(id));

            var folders = directory.GetDirectories();
            foreach (DirectoryInfo d in folders)
            {
                if (d != null && d.Attributes != null && !d.Attributes.HasFlag(FileAttributes.System) && !d.Attributes.HasFlag(FileAttributes.Hidden))
                {
                    if (!d.Name.Contains("Program Files") && !d.Name.Contains("Program Files (x86)") && !d.Name.Contains("$Recycle.Bin") && !d.Name.Contains("$RECYCLE.BIN"))//if the directory contains specific keywords skip that file.
                    {
                        JsTreeModel subNode = new JsTreeModel();
                        subNode.text = d.Name;
                        subNode.id = d.FullName;
                        subNode.children = HasSubfolders(d.FullName);
                        rootNode.Add(subNode);
                    }
                }
            }

            return Json(rootNode, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult RightSide(string path)
        {

            FolderModel rootNode = new FolderModel();
            rootNode.text = "ROOT";
            rootNode.id = path;
            PopulateTree(path, rootNode, true);

            return Json(rootNode, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public ActionResult SearchFile(string url)
        {
            try
            {
                List<FolderModel> folder = new List<FolderModel>();
                // Create a request for the URL. 
                WebRequest request = WebRequest.Create(url);
                // If required by the server, set the credentials.
                request.Credentials = CredentialCache.DefaultCredentials;
                // Get the response.
                WebResponse response = request.GetResponse();
                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();

                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                if (responseFromServer.IndexOf("<pre>") != -1)
                {
                    if (responseFromServer.IndexOf("dir") != -1 || responseFromServer.IndexOf("Parent") != -1)
                    {
                        //Remove unwanted string
                        responseFromServer = responseFromServer.Substring(responseFromServer.IndexOf("<pre>") + 5, (responseFromServer.LastIndexOf("<br>") - responseFromServer.IndexOf("<pre>") - 5));
                        //Replace all html character
                        responseFromServer = responseFromServer.Replace("&lt;", "<").Replace("&gt;", ">").Replace("</A>", "");
                        //Remove anchor tag
                        responseFromServer = System.Text.RegularExpressions.Regex.Replace(responseFromServer, "</?(a|A).*?>", "");
                        responseFromServer = System.Text.RegularExpressions.Regex.Replace(responseFromServer, "(<[a|A][^>]*>|)", "");
                        //Remove double space
                        responseFromServer = System.Text.RegularExpressions.Regex.Replace(responseFromServer, @"\s+", " ");
                        string[] data = responseFromServer.Split(new string[] { "<br>" }, StringSplitOptions.None);

                        foreach (string s in data)
                        {
                            if (!string.IsNullOrEmpty(s) && s.IndexOf("Parent") == -1)
                            {
                                string[] file = s.Trim().Split(' ');
                                FolderModel t = new FolderModel();
                                t.date = file[0] + " " + file[1] + " " + file[2];
                                t.type = file[3] == "<dir>" ? "folder" : "file";

                                for (int j = 4; j < file.Length; j++)
                                {
                                    t.text += " " + file[j];
                                }
                                if (t.text != null)
                                {
                                    t.text = t.text.Trim();
                                    t.id = t.text;
                                }
                                //t.children = new List<FolderModel>();
                                if (t.type == "file")
                                {
                                    t.size = file[3];
                                }
                                folder.Add(t);
                            }

                            // Display the content.
                            //responseFromServer = System.Text.RegularExpressions.Regex.Replace(responseFromServer,  "(<[a|A][^>]*>|)", "");
                        }
                    }
                    // Clean up the streams and the response.
                    reader.Close();
                    response.Close();
                }
                return Json(folder, JsonRequestBehavior.AllowGet);
            }
            catch (WebException e)
            {
                using (WebResponse response = e.Response)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)response;
                    return new HttpStatusCodeResult(httpResponse.StatusCode);
                }
            }
        }

        public ActionResult DownloadFile(string path)
        {
            string newPath = Server.MapPath(ConfigurationManager.AppSettings["TempStore"].ToString());
            string fileName = System.IO.Path.GetFileName(path);
            string json = string.Empty;

            newPath = newPath + fileName;
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Copy(path, newPath, true);
                json = "{\"path\":\"" + fileName + "\"}";
            }

            return Json(json);
        }

        public ActionResult Download(string name)
        {
            return new DownloadResult(name);
        }
    }
}
