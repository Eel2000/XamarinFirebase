using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFirebase.Services;

namespace XamarinFirebase.ViewModels
{
    public class EnfantPageViewModel
    {


        public EnfantPageViewModel()
        {
            AddCommand = new Command(async () => await Add());
        }

        public string Nom { get; set; }
        public string Prenom { get; set; }



        public ICommand AddCommand { get; set; }


        private async Task Add()
        {
            var response = await MainService.mainService.AddEnfant(Nom, Prenom);

            if (response == true)
            {
                await App.Current.MainPage.DisplayAlert("Alert", "User Created Sucessfully", "Ok");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Alert", "User Created Sucessfully", "Ok");
            }
        }
    }
}
