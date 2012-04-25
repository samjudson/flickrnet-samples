using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using FlickrNet;

namespace WindowsPhone7
{
    public partial class Search : PhoneApplicationPage
    {
        public Search()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            Flickr f = FlickrManager.GetAuthInstance();

            PhotoSearchOptions options = new PhotoSearchOptions();
            options.Tags = SearchTextBox.Text;
            options.Extras = PhotoSearchExtras.LargeSquareUrl;

            f.PhotosSearchAsync(options, r =>
            {
                if (r.Error != null)
                {
                    Dispatcher.BeginInvoke(() =>
                    {
                        MessageBox.Show("An error occurred talking to Flickr: " + r.Error.Message);
                    });
                    return;
                }

                PhotoCollection photos = r.Result;

                Dispatcher.BeginInvoke(() =>
                {
                    ResultsListBox.ItemsSource = photos;
                });
            });

        }
    }
}