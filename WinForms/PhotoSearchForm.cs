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
    public partial class PhotoSearchForm : Form
    {
        public PhotoSearchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flickr f = FlickrManager.GetInstance();

            PhotoSearchOptions o = new PhotoSearchOptions();
            o.Extras = PhotoSearchExtras.AllUrls | PhotoSearchExtras.Description | PhotoSearchExtras.OwnerName;
            o.SortOrder = PhotoSearchSortOrder.Relevance;
            o.Tags = textBox1.Text;

            bindingSource1.DataSource = f.PhotosSearch(o);
        }

    }
}
