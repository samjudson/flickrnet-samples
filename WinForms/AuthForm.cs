using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlickrNet;

namespace WinForms
{
    public partial class AuthForm : Form
    {
        private OAuthRequestToken requestToken;

        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthenticateButton_Click(object sender, EventArgs e)
        {
            Flickr f = FlickrManager.GetInstance();
            requestToken = f.OAuthGetRequestToken("oob");

            string url = f.OAuthCalculateAuthorizationUrl(requestToken.Token, AuthLevel.Write);

            System.Diagnostics.Process.Start(url);

            Step2GroupBox.Enabled = true;
        }

        private void CompleteAuthButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(VerifierTextBox.Text))
            {
                MessageBox.Show("You must paste the verifier code into the textbox above.");
                return;
            }

            Flickr f = FlickrManager.GetInstance();
            try
            {
                var accessToken = f.OAuthGetAccessToken(requestToken, VerifierTextBox.Text);
                FlickrManager.OAuthToken = accessToken;
                ResultLabel.Text = "Successfully authenticated as " + accessToken.FullName;
            }
            catch (FlickrApiException ex)
            {
                MessageBox.Show("Failed to get access token. Error message: " + ex.Message);
            }
        }
    }
}
