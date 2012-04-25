using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using FlickrNet;
using System.IO.IsolatedStorage;

namespace WindowsPhone7
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
                if (IsolatedStorageSettings.ApplicationSettings.Contains("OAuthToken"))
                    return IsolatedStorageSettings.ApplicationSettings["OAuthToken"] as string;
                else
                    return null;
            }
            set
            {
                IsolatedStorageSettings.ApplicationSettings["OAuthToken"] = value;
            }
        }

        public static string OAuthTokenSecret
        {
            get
            {
                if (IsolatedStorageSettings.ApplicationSettings.Contains("OAuthTokenSecret"))
                    return IsolatedStorageSettings.ApplicationSettings["OAuthTokenSecret"] as string;
                else
                    return null;
            }
            set
            {
                IsolatedStorageSettings.ApplicationSettings["OAuthTokenSecret"] = value;
            }
        }
    }
}
