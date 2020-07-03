using System;

using sampleApp.Models;

namespace sampleApp.ViewModels
{
    public class DreamDetailViewModel : BaseViewModel
    {
        public Dream Dream { get; set; }
        public DreamDetailViewModel(Dream dream = null)
        {
            Title = dream?.Title;
            Dream = dream;
        }
    }
}
