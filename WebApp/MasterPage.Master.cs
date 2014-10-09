using System;

namespace WebApp
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (FlickrManager.OAuthToken == null)
            {
                LoginLabel.Text = "Not Authenticated";
            }
            else
            {
                LoginLabel.Text = "Authenticated as " + FlickrManager.OAuthToken.FullName;
            }
        }
    }
}