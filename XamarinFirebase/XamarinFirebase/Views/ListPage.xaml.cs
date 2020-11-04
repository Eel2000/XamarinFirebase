using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFirebase.Services;
using XamarinFirebase.ViewModels;

namespace XamarinFirebase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
            BindingContext = new ListPageViewModel();
            GetListParent();
        }

        public async void GetListParent()
        {
            var result = await MainService.mainService.GetParents();

            listParents.ItemsSource = result;
        }
    }
}