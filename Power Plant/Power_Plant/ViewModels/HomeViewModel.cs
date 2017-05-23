using Power_Plant.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Power_Plant.ViewModels
{
    class HomeViewModel : BaseViewModel
    {
        private INavigation Navigation;
        public HomeViewModel(INavigation _Navigation)
        {
            PlantACommand = new Command(PlantAPage);
            PlantBCommand = new Command(PlantBPage);

            Navigation = _Navigation;
        }
        public ICommand PlantACommand { private get; set; }
        public ICommand PlantBCommand { private get; set; }

        public void PlantAPage()
        {
            Navigation.PushAsync(new PlantA());
        }
        public void PlantBPage()
        {
            Navigation.PushAsync(new PlantB());
        }

    }
}
