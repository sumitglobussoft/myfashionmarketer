﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.Myfashion.Domain;
using Myfashionmarketer.Api;
using System.Web.Script.Serialization;

namespace Myfashionmarketer.Helper
{
    public class SocialAccountsAPIHelper
    {
        public static FacebookAccount GetFacebookAccount(string FbUserId)
        {
            Api.FacebookAccount.FacebookAccount objApiFacebookAccount = new Api.FacebookAccount.FacebookAccount();

            FacebookAccount objDomainFacebookAccount = (FacebookAccount)new JavaScriptSerializer().Deserialize(objApiFacebookAccount.getUserDetails(FbUserId), typeof(FacebookAccount));

            return objDomainFacebookAccount;
        }

        public static TwitterAccount GetTwitterAccount(string TwtUserId)
        {
            Api.TwitterAccount.TwitterAccount objApiTwitterAccount = new Api.TwitterAccount.TwitterAccount();

            TwitterAccount objDomainFacebookAccount = (TwitterAccount)new JavaScriptSerializer().Deserialize(objApiTwitterAccount.getUserInformation(TwtUserId), typeof(TwitterAccount));

            return objDomainFacebookAccount;
        }
    }
}