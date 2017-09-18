using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MVVM.ViewModel;
using MVVM.Model;
namespace MVVM
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm;
        public MainPage()
        {
            Person per = MainPageViewModel.GetPerson();
            vm = new MainPageViewModel(per);
            BindingContext = vm;
            InitializeComponent();
        }
    }
}
