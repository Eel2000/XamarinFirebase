using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFirebase.Services;
using XamarinFirebase.Views;

namespace XamarinFirebase.ViewModels
{
    public class MainPageViewModel
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        

        public ICommand AddCommand { get; set; }
        public ICommand GoToEnfant { get; set; }
        public ICommand GotToList { get; set; }


        public MainPageViewModel(INavigation navigation)
        {
            navigation1 = navigation;
            AddCommand = new Command(async () => await Add());
            GoToEnfant = new Command(async() => await NavigateToEnfant());
            GotToList = new Command(async () => await NavigateToList());
        }

        private readonly INavigation navigation1;

        private async Task Add()
        {
            var response = await MainService.mainService.AddNew(Nom, Prenom);

            if (response == true)
            {
                await App.Current.MainPage.DisplayAlert("Alert", "User Created Sucessfully", "Ok");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Alert", "User Created Sucessfully", "Ok");
            }
        }

        public async Task NavigateToEnfant()
        {
            await navigation1.PushModalAsync(new EnfantPage());
        }

        private async Task NavigateToList()
        {
            await navigation1.PushModalAsync(new ListPage());
        }
    }
}
