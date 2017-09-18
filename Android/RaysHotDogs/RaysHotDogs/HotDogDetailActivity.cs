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

namespace RaysHotDogs
{
    [Activity(Label = "HotDogDetailActivity",MainLauncher =true)]
    public class HotDogDetailActivity : Activity
    {

        private ImageView hotDogImageView;
        private TextView hotDogNameTextView;
        private TextView shortDescriptionTextView;
            private TextView DescriptionTextView;
        private TextView priceTextView;
        private EditText amountEditText;
            private Button cancelButton;
        private Button orderButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
    }
}