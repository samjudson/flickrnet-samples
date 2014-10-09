/*
 * This class is designed to give you an example of how you might store the authentication token for a user.
 * You might choose to use a Cookie (as in this example), or perhaps simply store it in Session.
 * Alternatively you might store it store it in a database instead, and authenticate the user using your own username/password scheme.
 * */
using System;
using System.Web;
using FlickrNet;

namespace WebApp
{
    public class FlickrManager
    {
        /// <summary>
        /// This is a sample API Key I created just for these samples. Please don't use elsewhere.
        /// </summary>
        public const string ApiKey = "3a68f22971d8d66b521b362c312c175c";
        public const string SharedSecret = "b2acf0fb7910be24";

        public static Flickr GetInstance()
        {
            return new Flickr(ApiKey, SharedSecret);
        }

        public static Flickr GetAuthInstance()
        {
            var f = new Flickr(ApiKey, SharedSecret);
            if (OAuthToken != null)
            {
                f.OAuthAccessToken = OAuthToken.Token;
                f.OAuthAccessTokenSecret = OAuthToken.TokenSecret;
            }
            return f;
        }

        public static OAuthAccessToken OAuthToken
        {
            get
            {
                if (HttpContext.Current.Request.Cookies["OAuthToken"] == null)
                {
                    return null;
                }
                var values = HttpContext.Current.Request.Cookies["OAuthToken"].Values;
                return new OAuthAccessToken
                           {
                               FullName = values["FullName"],
                               Token = values["Token"],
                               TokenSecret = values["TokenSecret"],
                               UserId = values["UserId"],
                               Username = values["Username"]
                           };
            }
            set
            {
                // Stores the authentication token in a cookie which will expire in 1 hour
                var cookie = new HttpCookie("OAuthToken")
                {
                    Expires = DateTime.UtcNow.AddHours(1),
                };
                cookie.Values["FullName"] = value.FullName;
                cookie.Values["Token"] = value.Token;
                cookie.Values["TokenSecret"] = value.TokenSecret;
                cookie.Values["UserId"] = value.UserId;
                cookie.Values["Username"] = value.Username;
                HttpContext.Current.Response.AppendCookie(cookie);
            }
        }
    }
}
