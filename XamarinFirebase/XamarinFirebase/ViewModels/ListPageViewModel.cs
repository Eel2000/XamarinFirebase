using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamarinFirebase.Models;
using XamarinFirebase.Services;

namespace XamarinFirebase.ViewModels
{
    public class ListPageViewModel : BindableObject
    {
        ObservableCollection<Parent> _parents;
        public List<Parent> ListOfParents { get; set; }

        public string Nom { get; set; }
        public string Prenom { get; set; }

        public ObservableCollection<Parent> parents
        {
            get { return _parents; }
            set
            {
                _parents = value;
                OnPropertyChanged();
            }
        }

        public ListPageViewModel()
        {
            
        }

    //    private async void GetListOfParent()
    //    {
    //        var result = MainService.mainService.GetParents();

    //       reawait result;
    //    }
    }
}
