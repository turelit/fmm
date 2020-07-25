using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using sampleApp.Services;
using sampleApp.Views;
using sampleApp.Views.Forms;

namespace sampleApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new backdrop();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
