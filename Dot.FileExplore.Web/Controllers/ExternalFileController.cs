using Dot.FileExplore.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace Dot.FileExplore.Web.Controllers
{
    public class ExternalFileController : Controller
    {
        //
        // GET: /ExternalFile/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            string url = Request["txtHttpUrl"].ToString();
            // Create a request for the URL. 
            WebRequest request = WebRequest.Create(
              "http://localhost:81/");
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            
            responseFromServer = responseFromServer.Substring(91, responseFromServer.Length - 91);
            responseFromServer = responseFromServer.Substring(0, responseFromServer.Length - 29);
            responseFromServer = responseFromServer.Replace("&lt;", "<").Replace("&gt;", ">").Replace("</A>","");
            responseFromServer = System.Text.RegularExpressions.Regex.Replace(responseFromServer, "(<[a|A][^>]*>|)", "");
            responseFromServer = System.Text.RegularExpressions.Regex.Replace(responseFromServer, @"\s+", " ");
            string[] data = responseFromServer.Split(new string[] { "<br>" }, StringSplitOptions.None);
            List<FolderModel> folder = new List<FolderModel>();
            foreach (string s in data)
            {
                string[] file = s.Trim().Split(' ');
                FolderModel t = new FolderModel();
                t.date = file[0] + " " + file[1] + " " + file[2];
                t.type = file[3] == "<dir>" ? "folder" : "file";
                t.text = file[4];
                t.children = new List<FolderModel>();
                if (t.type == "file")
                {
                    t.size = file[3];
                }
                folder.Add(t);
            }
            // Display the content.
            //responseFromServer = System.Text.RegularExpressions.Regex.Replace(responseFromServer,  "(<[a|A][^>]*>|)", "");

            
            // Clean up the streams and the response.
            reader.Close();
            response.Close();
            return View();
        }

    }
}
