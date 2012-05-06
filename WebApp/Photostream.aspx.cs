using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlickrNet;

namespace WebApp
{
    public partial class Photostream : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static List<Photo> GetPhotostream(string userId)
        {
            Flickr f = FlickrManager.GetAuthInstance();
            PhotoCollection photos = f.PeopleGetPublicPhotos(userId, 0, 0, SafetyLevel.None, PhotoSearchExtras.PathAlias);
            return photos.ToList();
        }
    }
}