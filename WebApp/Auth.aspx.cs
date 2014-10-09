using System;
using FlickrNet;

namespace WebApp
{
    public partial class Auth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // The request token is stored in session - if it isn't present then we do nothing
            if (Request.QueryString["oauth_verifier"] != null && Session["RequestToken"] != null)
            {
                Flickr f = FlickrManager.GetInstance();
                OAuthRequestToken requestToken = Session["RequestToken"] as OAuthRequestToken;
                try
                {
                    OAuthAccessToken accessToken = f.OAuthGetAccessToken(requestToken,
                        Request.QueryString["oauth_verifier"]);
                    FlickrManager.OAuthToken = accessToken;

                    ResultsLabel.Text = "You successfully authenticated as " + accessToken.FullName;
                    ResultPanel.CssClass = "alert alert-success"; 
                    ResultPanel.Visible = true;
                }
                catch (OAuthException ex)
                {
                    ResultsLabel.Text = "An error occurred retrieving the token : " + ex.Message;
                    ResultPanel.CssClass = "alert alert-danger";
                    ResultPanel.Visible = true;

                }
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