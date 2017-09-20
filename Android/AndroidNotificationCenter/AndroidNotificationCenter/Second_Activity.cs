using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidNotificationCenter
{
    [Activity(Label = "Second_Activity")]
    public class Second_Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SecondActivity);

            string sendContent = Intent.Extras.GetString("SendContent");
            var txtContent = FindViewById<TextView>(Resource.Id.textView1);
            txtContent.Text = sendContent;
            // Create your application here
        }
    }
}