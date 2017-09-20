using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FormMVVMDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var quoteViewModel = new QuoteViewModel();


            var label = new Entry();
            label.SetBinding(Entry.TextProperty, "QuoteName",BindingMode.TwoWay);
            label.HorizontalOptions = LayoutOptions.Center;

            var button = new Button();
            button.SetBinding(Button.CommandProperty, "ResetQuoteName");
            button.Text = "Reset Quote in code";

            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        label,
                        new QuoteView(),
                        button
                        //new Label
                        //{
                        //    XAlign=TextAlignment.Center,
                        //    Text = "Welcome Glitz"
                        //}
                    }
                },
                BindingContext=quoteViewModel
            };
            //MainPage = new FormMVVMDemo.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
