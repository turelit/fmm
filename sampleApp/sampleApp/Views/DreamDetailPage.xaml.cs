using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using sampleApp.Models;
using sampleApp.ViewModels;

namespace sampleApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class DreamDetailPage : ContentPage
    {
        DreamDetailViewModel viewModel;

        public DreamDetailPage(DreamDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public DreamDetailPage()
        {
            InitializeComponent();

            var dream = new Dream
            {
                Title = "Dream 1",
                Description = "This is a dream description."
            };

            viewModel = new DreamDetailViewModel(dream);
            BindingContext = viewModel;
        }
    }
}