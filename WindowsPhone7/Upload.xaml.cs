using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using FlickrNet;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Info;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace WindowsPhone7
{
    public partial class Upload : PhoneApplicationPage
    {
        private string _photoFilename;
        private Stream _photoStream;
        private readonly PhotoChooserTask _photoChooserTask;
        private long _startingMemoryUsage;

        public Upload()
        {
            _photoChooserTask = new PhotoChooserTask();
            _photoChooserTask.ShowCamera = true;
            _photoChooserTask.Completed += PhotoChosen;
            InitializeComponent();
        }

        private void UploadButton_OnClick(object sender, RoutedEventArgs e)
        {
            var f = FlickrManager.GetAuthInstance();
            //Stream fileStream = new FileStream(_photoFilename, FileMode.Open);
            _startingMemoryUsage = DeviceStatus.ApplicationCurrentMemoryUsage;
            f.UploadPictureAsync(_photoStream, "photo.jpg", Title.Text, null, null, false, false, false, ContentType.Photo, SafetyLevel.None, HiddenFromSearch.None, UploadComplete);
        }

        private void UploadComplete(FlickrResult<string> flickrResult)
        {
            if (flickrResult.HasError)
            {
                Dispatcher.BeginInvoke(() => MessageBox.Show("An error occurred uploading: " +
                                                             flickrResult.ErrorMessage));
            }
            else
            {
                var currentMemoryUsage = DeviceStatus.ApplicationCurrentMemoryUsage;
                var totalMemoryUsage = currentMemoryUsage - _startingMemoryUsage;

                Debug.WriteLine("Start Memory: " + (_startingMemoryUsage / 1024 / 1024));
                Debug.WriteLine("Current Memory: " + (currentMemoryUsage / 1024 / 1024));
                Debug.WriteLine("Total Memory: " + (totalMemoryUsage / 1024 / 1024));
                Dispatcher.BeginInvoke(
                    () => MessageBox.Show("Photo uploaded successfully. Memory increase = " + totalMemoryUsage));

            }
        }

        private void PickImageButton_OnClick(object sender, RoutedEventArgs e)
        {
            _photoChooserTask.Show();
        }

        private void PhotoChosen(object sender, PhotoResult photoResult)
        {
            _photoFilename = photoResult.OriginalFileName;
            _photoStream = photoResult.ChosenPhoto;
        }
    }
}