using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFirebase.ViewModels;

namespace XamarinFirebase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnfantPage : ContentPage
    {
        public EnfantPage()
        {
            InitializeComponent();

            BindingContext = new EnfantPageViewModel();
        }
    }
}