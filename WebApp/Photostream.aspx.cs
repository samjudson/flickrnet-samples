using System;
using System.Collections.Generic;
using System.Linq;
using FlickrNet;

namespace WebApp
{
    public partial class Photostream : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (FlickrManager.OAuthToken != null)
            {
                UserIdTextBox.Text = FlickrManager.OAuthToken.UserId;
            }
        }

        public static List<Photo> GetPhotostream(string userId)
        {
            Flickr f = FlickrManager.GetAuthInstance();
            PhotoCollection photos = f.PeopleGetPublicPhotos(userId, 0, 12, SafetyLevel.None, PhotoSearchExtras.PathAlias);
            return photos.ToList();
        }
    }
}