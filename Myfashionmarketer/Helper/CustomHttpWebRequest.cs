﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Collections.Specialized;
using System.Text;
using System.IO;
using Myfashionmarketer.ExtensionClasses;


namespace Myfashionmarketer.Helper
{
    public class CustomHttpWebRequest
    {

        private const string BaseURL = "http://tracker.myfashionmarketer.com/";
       

        /// <summary>
        /// Submit a web request using oAuth.
        ///// </summary>
        /// <param name="method">GET or POST</param>
        /// <param name="url">The full url, including the querystring.</param>
        /// <param name="postData">Data to post (querystring format)</param>
        /// <returns>The web server response.</returns>
        public static string HttpWebRequest(string method, string resourceUrl, SortedDictionary<string, string> requestParameters)
        {
            resourceUrl = BaseURL + resourceUrl;

            string resultString = string.Empty;

            try
            {
                ServicePointManager.Expect100Continue = false;
                HttpWebRequest request = null;


                if (method == "POST")
                {
                    var postBody = requestParameters.ToWebString();

                    request = (HttpWebRequest)WebRequest.Create(resourceUrl + "?"
                   + requestParameters.ToWebString());
                    request.Method = method.ToString();
                    //if (resourceUrl == Globals.StatusUpdateUrl)
                    //{
                    //    request.ContentType = "multipart/form-data; type=\"image/jpeg\"; start=\"<media>\";boundary=\"--0246824681357ACXZabcxyz\"";

                    //}
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.Accept = "application/jsonp";
                    request.ProtocolVersion = HttpVersion.Version11;
                    using (var stream = request.GetRequestStream())
                    {
                        byte[] content = Encoding.ASCII.GetBytes(postBody);
                        stream.Write(content, 0, content.Length);
                    }
                }
                else if (method == "GET")
                {
                    request = (HttpWebRequest)WebRequest.Create(resourceUrl + "?"
                    + requestParameters.ToWebString());
                    request.Method = method.ToString();

                }
                else
                {
                    //other verbs can be addressed here...
                }

                if (request != null)
                {

                    //var authHeader = CreateHeader(resourceUrl, method, requestParameters);
                    //request.Headers.Add("Authorization", authHeader);
                    using (var response = request.GetResponse())
                    {
                        //var response = request.GetResponse();

                        using (var sd = new StreamReader(response.GetResponseStream()))
                        {
                            resultString = sd.ReadToEnd();
                            //response.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.StackTrace);
            }

            return resultString;
        }
    }
}