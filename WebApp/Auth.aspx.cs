using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlickrNet;

namespace WebApp
{
    public partial class Auth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["oauth_verifier"] != null && Session["RequestToken"] != null)
            {
                Flickr f = FlickrManager.GetInstance();
                OAuthRequestToken requestToken = Session["RequestToken"] as OAuthRequestToken;
                OAuthAccessToken accessToken = f.OAuthGetAccessToken(requestToken, Request.QueryString["oauth_verifier"]);

                FlickrManager.OAuthToken = accessToken;

                ResultsLabel.Text = "You successfully authenticated as " + accessToken.FullName;
            }
        }

        protected void AuthenticateButton_Click(object sender, EventArgs e)
        {
            Flickr f = FlickrManager.GetInstance();
            OAuthRequestToken token = f.OAuthGetRequestToken(Request.Url.AbsoluteUri);

            Session["RequestToken"] = token;

            string url = f.OAuthCalculateAuthorizationUrl(token.Token, AuthLevel.Read);
            Response.Redirect(url);
        }
    }
}