using System;
using System.Net;
using System.Web;
using System.Linq;
using FlickrNet;

namespace WebApp
{
    public class FlickrManager
    {
        public const string ApiKey = "3a68f22971d8d66b521b362c312c175c";
        public const string SharedSecret = "b2acf0fb7910be24";

        public static Flickr GetInstance()
        {
            return new Flickr(ApiKey, SharedSecret);
        }

        public static Flickr GetAuthInstance()
        {
            var f = new Flickr(ApiKey, SharedSecret);
            f.OAuthAccessToken = OAuthToken;
            f.OAuthAccessTokenSecret = OAuthTokenSecret;
            return f;
        }

        public static string OAuthToken
        {
            get
            {
                if (!HttpContext.Current.Request.Cookies.AllKeys.Contains("OAuthToken"))
                {
                    return null;
                }
                return HttpContext.Current.Request.Cookies["OAuthToken"].Value;
            }
            set
            {
                HttpContext.Current.Response.AppendCookie(new HttpCookie("OAuthToken", value) { Expires = DateTime.UtcNow.AddDays(1)});
            }
        }

        public static string OAuthTokenSecret
        {
            get
            {
                if (!HttpContext.Current.Request.Cookies.AllKeys.Contains("OAuthTokenSecret"))
                {
                    return null;
                }
                return HttpContext.Current.Request.Cookies["OAuthTokenSecret"].Value;
            }
            set
            {
                HttpContext.Current.Response.AppendCookie(new HttpCookie("OAuthTokenSecret", value) { Expires = DateTime.UtcNow.AddDays(1)});
            }
        }
    }
}
