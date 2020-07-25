using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Syncfusion.XForms.Backdrop;

namespace sampleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class backdrop : SfBackdropPage
    {
        public backdrop()
        {
            InitializeComponent();
            this.Title = "title";

            this.BackLayer = new BackdropBackLayer
            {
                Content = new StackLayout
                {
                    Children =
            {
            new ListView
                {
                    ItemsSource = new string[] { "Warszawa", "Bydgoszcz", "Dabrowa Gornicza" ,"Pierdziszewo Dolne"}
                }
            }
                }
            };
            this.FrontLayer = new BackdropFrontLayer()
            {
                Content = new Grid
                {
                    BackgroundColor = Color.WhiteSmoke,
                    VerticalOptions = LayoutOptions.FillAndExpand
                }
            };
        }

    }

}