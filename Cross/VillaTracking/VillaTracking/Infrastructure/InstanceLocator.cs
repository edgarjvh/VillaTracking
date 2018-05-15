using VillaTracking.ViewModels;

namespace VillaTracking.Infrastructure
{
    class InstanceLocator
    {
        public InstanceLocator()
        {
            Main = new MainViewModel();
        }

        public MainViewModel Main { get; set; }
    }
}
