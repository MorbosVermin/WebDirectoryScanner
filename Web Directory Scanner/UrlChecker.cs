using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Web_Directory_Scanner
{
    public class UrlChecker
    {
        public static string UserAgent
        {
            get;
            set;
        }

        /// <summary>
        /// Returns a HttpWebResponse for the given URL.
        /// </summary>
        /// <param name="URL">URL</param>
        /// <returns>HttpWebResponse</returns>
        public static HttpWebResponse GetResponse(string URL)
        {
            HttpWebResponse resp = null;
            if (UserAgent == null)
                UserAgent = Properties.Settings.Default.ua_default;

            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(URL);
                req.UserAgent = UserAgent;
                resp = (HttpWebResponse)req.GetResponse();
            }
            catch(Exception e)  
            {
                Console.WriteLine("{0}: {1}", e.GetType(), e.Message);
            }

            return resp;
        }

        /// <summary>
        /// Returns true when the given URL returns a 200 OK. 
        /// </summary>
        /// <param name="URL">URL to check.</param>
        /// <returns>bool</returns>
        public static bool Exists(string URL)
        {
            return (GetStatusCode(URL) == HttpStatusCode.OK);
        }

        /// <summary>
        /// Returns the HTTP code for the given URL.
        /// </summary>
        /// <param name="URL">URL</param>
        /// <returns>HttpStatusCode</returns>
        public static HttpStatusCode GetStatusCode(string URL)
        {
            return GetResponse(URL).StatusCode;
        }
    
    }
}
