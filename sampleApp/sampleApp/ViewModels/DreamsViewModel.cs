using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using sampleApp.Models;
using sampleApp.Views;

namespace sampleApp.ViewModels
{
    public class DreamsViewModel : BaseViewModel
    {
        public ObservableCollection<Dream> Dreams { get; set; }
        public Command LoadDreamsCommand { get; set; }

        public DreamsViewModel()
        {
            Title = "Browse";
            Dreams = new ObservableCollection<Dream>();
            LoadDreamsCommand = new Command(async () => await ExecuteLoadDreamsCommand());

            MessagingCenter.Subscribe<NewDreamPage, Dream>(this, "AddDream", async (obj, item) =>
            {
                var newDream = item as Dream;
                Dreams.Add(newDream);
                await DataStore.AddItemAsync(newDream);
            });
        }

        async Task ExecuteLoadDreamsCommand()
        {
            IsBusy = true;

            try
            {
                Dreams.Clear();
                var dreams = await DataStore.GetItemsAsync(true);
                foreach (var dream in dreams)
                {
                    Dreams.Add(dream);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}