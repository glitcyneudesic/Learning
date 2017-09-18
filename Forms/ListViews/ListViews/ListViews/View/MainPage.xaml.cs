using ListViews.Model;
using ListViews.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViews
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        //private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    if(e.SelectedItem==null)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        Person p = e.SelectedItem as Person;
        //        DisplayAlert("Selected ",p.FirstName, "Ok");
        //    }
        //}
    }
}
