﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormMVVMDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuoteView : ContentView
    {
        public QuoteView()
        {
            InitializeComponent();
        }
    }
}