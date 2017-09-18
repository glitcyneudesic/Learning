using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Lists.ViewModel;
using Lists.Model;

namespace Lists
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm;
        public MainPage()
        {
            vm = new MainPageViewModel();
            BindingContext = vm;
            InitializeComponent();
        }

        private void EmployeeList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var per = e.Item as Person;
            DisplayAlert("ItemTapped", "You are " + per.FirstName,"OK");

        }
    }
}
