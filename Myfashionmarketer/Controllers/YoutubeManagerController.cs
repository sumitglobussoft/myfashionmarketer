﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using log4net;
using System.Web.Security;
using System.Text.RegularExpressions;
using Api.Myfashionmarketer.Models;
using Myfashionmarketer.App_Start;
using Api.Myfashionmarketer.Services;
using Myfashionmarketer.Helper;

namespace Myfashionmarketer.Controllers
{

    public class YoutubeManagerController : Controller
    {
        //
        // GET: /YoutubeManager/

        ILog logger = LogManager.GetLogger(typeof(YoutubeManagerController));
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Youtube()
        {
            string AddYoutubeAccount = string.Empty;
            string status = "";
            string AddGPlusAccount = string.Empty;
            Domain.Myfashion.Domain.User objUser = (Domain.Myfashion.Domain.User)Session["User"];
            Domain.Myfashion.Domain.User checkuserexist = (Domain.Myfashion.Domain.User)Session["User"];
            string code = (String)Request.QueryString["code"];
            Api.Youtube.Youtube apiobjYoutube = new Api.Youtube.Youtube();
            Api.GooglePlus.GooglePlus ApiobjGooglePlus = new Api.GooglePlus.GooglePlus();
            Api.User.User ApiobjUser = new Api.User.User();

            if (Session["googlepluslogin"] != null)
            {
                if (!string.IsNullOrEmpty(code))
                {
                    if (Session["googlepluslogin"].ToString() == "googlepluslogin")
                    {
                        //objUser = (Domain.Myfashion.Domain.User)(new JavaScriptSerializer().Deserialize(apiobjYoutube.GoogleLogin(code), typeof(Domain.Myfashion.Domain.User)));
                        string Googleloginreturn = apiobjYoutube.GoogleLogin(code);
                        string[] arrgoogleloginreturn = Regex.Split(Googleloginreturn, "_#_");
                        objUser = (Domain.Myfashion.Domain.User)(new JavaScriptSerializer().Deserialize(arrgoogleloginreturn[0], typeof(Domain.Myfashion.Domain.User)));
                        Session["AccesstokenFblogin"] = arrgoogleloginreturn[1];
                        Session["googlepluslogin"] = "googlelogin";
                        checkuserexist = (Domain.Myfashion.Domain.User)(new JavaScriptSerializer().Deserialize(ApiobjUser.getUserInfoByEmail(objUser.EmailId.ToString()), typeof(Domain.Myfashion.Domain.User)));
                        string pid = checkuserexist.PuId;
                        string puid = pid.Substring(36, pid.Length - 36);
                        SortedDictionary<string, string> strdic = new SortedDictionary<string, string>();
                        strdic.Add("username", checkuserexist.EmailId);
                        strdic.Add("password", puid);
                        string data = CustomHttpWebRequest.HttpWebRequest("GET", "myfashion/loginService.action", strdic);
                        data = data.Replace("func({", "{");
                        data = data.Replace("});", "}");
                        JObject jo = JObject.Parse(data);
                        status = Server.UrlDecode((string)jo["code"]);

                        if (checkuserexist != null)
                        {
                            Session["User"] = checkuserexist;
                            int daysremaining = 0;

                            daysremaining = (checkuserexist.ExpiryDate.Date - DateTime.Now.Date).Days;
                            if (daysremaining > 0)
                            {
                                #region Count Used Accounts
                                try
                                {
                                    Session["Paid_User"] = "Paid";
                                    Api.SocialProfile.SocialProfile apiobjSocialProfile = new Api.SocialProfile.SocialProfile();
                                    //Session["ProfileCount"] = Convert.ToInt32(apiobjSocialProfile.GetAllSocialProfilesOfUserCount(objUser.Id.ToString()).ToString());
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                #endregion
                            }
                            else
                            {
                                Session["Paid_User"] = "Unpaid";
                            }
                            FormsAuthentication.SetAuthCookie(objUser.UserName, false);
                            //ApiobjUser.UpdateLastLoginTime(checkuserexist.Id.ToString());
                            if (status == "101")
                            {
                                return RedirectToAction("Index", "Home");
                            }
                            else
                            {
                                return RedirectToAction("Index", "Index");
                            }
                        }
                        else
                        {
                            objUser.ActivationStatus = "1";
                            Session["User"] = objUser;
                            return RedirectToAction("SignUp", "Index");
                        }
                    }
                    else if (Session["googlepluslogin"].ToString() == "gplus")
                    {
                        AddGPlusAccount = ApiobjGooglePlus.AddGPlusAccount(ConfigurationManager.AppSettings["YtconsumerKey"], ConfigurationManager.AppSettings["YtconsumerSecret"], ConfigurationManager.AppSettings["Ytredirect_uri"], objUser.Id.ToString(), Session["group"].ToString(), code);
                        if (AddGPlusAccount == "Refresh Token Not Found")
                        {
                            AuthenticateYoutube(Session["googlepluslogin"].ToString());
                        }
                        else
                        {
                            Session["SocialManagerInfo"] = AddGPlusAccount;
                        }
                    }
                }
                else
                {
                    return RedirectToAction("SocialMedia", "Index");
                }
            }
            else
            {
                try
                {
                    AddYoutubeAccount = apiobjYoutube.AddYoutubeAccount(ConfigurationManager.AppSettings["YtconsumerKey"], ConfigurationManager.AppSettings["YtconsumerSecret"], ConfigurationManager.AppSettings["Ytredirect_uri"], objUser.Id.ToString(), Session["group"].ToString(), code);
                    if (AddYoutubeAccount == "Refresh Token Not Found")
                    {
                        AuthenticateYoutube("");
                    }
                    else
                    {
                        Session["SocialManagerInfo"] = AddYoutubeAccount;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return RedirectToAction("SocialMedia", "Home");
        }
        public ActionResult AuthenticateYoutube(string op)
        {
            string googleurl = string.Empty;
            if (!string.IsNullOrEmpty(op))
            {
                if (op == "googlepluslogin")
                {
                    Session["googlepluslogin"] = op;
                    googleurl = "https://accounts.google.com/o/oauth2/auth?client_id=" + ConfigurationManager.AppSettings["YtconsumerKey"] + "&redirect_uri=" + ConfigurationManager.AppSettings["Ytredirect_uri"] + "&scope=https://www.googleapis.com/auth/youtube+https://www.googleapis.com/auth/youtube.readonly+https://www.googleapis.com/auth/youtubepartner+https://www.googleapis.com/auth/youtubepartner-channel-audit+https://www.googleapis.com/auth/userinfo.email+https://www.googleapis.com/auth/userinfo.profile+https://www.googleapis.com/auth/plus.me&response_type=code&access_type=offline";
                }
                else if (op == "gplus")
                {
                    Session["googlepluslogin"] = op;
                    try
                    {
                        try
                        {
                            Api.Groups.Groups objApiGroups = new Api.Groups.Groups();
                            JObject group = JObject.Parse(objApiGroups.GetGroupDetailsByGroupId(Session["group"].ToString().ToString()));
                            int profilecount = 0;
                            int totalaccount = 0;
                            try
                            {
                                profilecount = (Int16)(Session["ProfileCount"]);
                                totalaccount = (Int16)Session["TotalAccount"];
                            }
                            catch (Exception ex)
                            {
                                logger.Error("ex.Message : " + ex.Message);
                                logger.Error("ex.StackTrace : " + ex.StackTrace);
                            }
                            {
                                if (profilecount < totalaccount)
                                {
                                    Response.Redirect("https://accounts.google.com/o/oauth2/auth?client_id=" + ConfigurationManager.AppSettings["YtconsumerKey"] + "&redirect_uri=" + ConfigurationManager.AppSettings["Ytredirect_uri"] + "&scope=https://www.googleapis.com/auth/plus.login+https://www.googleapis.com/auth/plus.profile.emails.read+https://www.googleapis.com/auth/plus.stream.write+https://www.googleapis.com/auth/plus.stream.read+https://www.googleapis.com/auth/plus.circles.read+https://www.googleapis.com/auth/plus.circles.write+https://www.googleapis.com/auth/plus.profiles.read+https://www.googleapis.com/auth/plus.media.upload+https://www.googleapis.com/auth/userinfo.email+https://www.googleapis.com/auth/userinfo.profile+https://www.googleapis.com/auth/plus.me&response_type=code&access_type=offline");
                                }
                                else if (profilecount == 0 || totalaccount == 0)
                                {
                                    Response.Redirect("https://accounts.google.com/o/oauth2/auth?client_id=" + ConfigurationManager.AppSettings["YtconsumerKey"] + "&redirect_uri=" + ConfigurationManager.AppSettings["Ytredirect_uri"] + "&scope=https://www.googleapis.com/auth/plus.login+https://www.googleapis.com/auth/plus.profile.emails.read+https://www.googleapis.com/auth/plus.stream.write+https://www.googleapis.com/auth/plus.stream.read+https://www.googleapis.com/auth/plus.circles.read+https://www.googleapis.com/auth/plus.circles.write+https://www.googleapis.com/auth/plus.profiles.read+https://www.googleapis.com/auth/plus.media.upload+https://www.googleapis.com/auth/userinfo.email+https://www.googleapis.com/auth/userinfo.profile+https://www.googleapis.com/auth/plus.me&response_type=code&access_type=offline");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    catch (Exception ex)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }

            }

            else
            {
                try
                {
                    try
                    {
                        Api.Groups.Groups objApiGroups = new Api.Groups.Groups();
                        JObject group = JObject.Parse(objApiGroups.GetGroupDetailsByGroupId(Session["group"].ToString().ToString()));
                        int profilecount = 0;
                        int totalaccount = 0;
                        try
                        {
                            profilecount = (Int16)(Session["ProfileCount"]);
                            totalaccount = (Int16)Session["TotalAccount"];
                        }
                        catch (Exception ex)
                        {
                            logger.Error("ex.Message : " + ex.Message);
                            logger.Error("ex.StackTrace : " + ex.StackTrace);
                        }
                        {
                            if (profilecount < totalaccount)
                            {
                                //string redirect = "https://accounts.google.com/o/oauth2/auth?client_id=" + ConfigurationManager.AppSettings["YtconsumerKey"] + "&redirect_uri=" + ConfigurationManager.AppSettings["Ytredirect_uri"] + "&scope=https://www.googleapis.com/auth/youtube+https://www.googleapis.com/auth/youtube.readonly+https://www.googleapis.com/auth/youtubepartner+https://www.googleapis.com/auth/youtubepartner-channel-audit+https://www.googleapis.com/auth/userinfo.email+https://www.googleapis.com/auth/userinfo.profile+https://www.googleapis.com/auth/plus.me&response_type=code&access_type=offline";
                                Response.Redirect("https://accounts.google.com/o/oauth2/auth?client_id=" + ConfigurationManager.AppSettings["YtconsumerKey"] + "&redirect_uri=" + ConfigurationManager.AppSettings["Ytredirect_uri"] + "&scope=https://www.googleapis.com/auth/youtube+https://www.googleapis.com/auth/youtube.readonly+https://www.googleapis.com/auth/youtubepartner+https://www.googleapis.com/auth/youtubepartner-channel-audit+https://www.googleapis.com/auth/userinfo.email+https://www.googleapis.com/auth/userinfo.profile+https://www.googleapis.com/auth/plus.me&response_type=code&access_type=offline");
                            }
                            else if (profilecount == 0 || totalaccount == 0)
                            {
                                Response.Redirect("https://accounts.google.com/o/oauth2/auth?client_id=" + ConfigurationManager.AppSettings["YtconsumerKey"] + "&redirect_uri=" + ConfigurationManager.AppSettings["Ytredirect_uri"] + "&scope=https://www.googleapis.com/auth/youtube+https://www.googleapis.com/auth/youtube.readonly+https://www.googleapis.com/auth/youtubepartner+https://www.googleapis.com/auth/youtubepartner-channel-audit+https://www.googleapis.com/auth/userinfo.email+https://www.googleapis.com/auth/userinfo.profile+https://www.googleapis.com/auth/plus.me&response_type=code&access_type=offline");
                            }
                            else
                            {
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
                catch (Exception ex)
                {
                }
            }
            return Content(googleurl);
        }




    }
}
