using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using sampleApp.Models;
using sampleApp.Views;
using sampleApp.ViewModels;

namespace sampleApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class DreamsPage : ContentPage
    {
        DreamsViewModel viewModel;

        public DreamsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new DreamsViewModel();
        }

        async void OnItemSelected(object sender, EventArgs args)
        {
            var layout = (BindableObject)sender;
            var dream = (Dream)layout.BindingContext;
            await Navigation.PushAsync(new DreamDetailPage(new DreamDetailViewModel(dream)));
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewDreamPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Dreams.Count == 0)
                viewModel.IsBusy = true;
        }
    }
}