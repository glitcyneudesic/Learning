using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using AndroidCustomAdapterListView.Resources;

namespace AndroidCustomAdapterListView
{
    [Activity(Label = "AndroidCustomAdapterListView", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var lstdata = FindViewById<ListView>(Resource.Id.listView);
            var btnshow = FindViewById<Button>(Resource.Id.btnShow);
            btnshow.Click += delegate
            {

                List<Person> lstSource = new List<Person>();
                for (int i = 0; i < 20; i++)
                {
                    Person per = new Person()
                    {
                        Id = i,
                        Name = "name" + i,
                        Age = 2,
                        Email = "email" + i
                    };
                    lstSource.Add(per);
                }
                var adapter = new CustomAdapter(this, lstSource);
                lstdata.Adapter = adapter;

            };

        }
    }
}

