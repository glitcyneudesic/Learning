using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;
using System.Collections.Generic;

namespace phonebook
{
    [Activity(Label = "phonebook", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button btn = null;
        AlertDialog.Builder builder = null;
        EditText etxt = null;
        TextView txtView = null;
        EditText phoneNumberText = null;
        Button translateButton = null;
        Button callButton = null;
        static readonly List<string> phoneNumbers = new List<string>();
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            btn = FindViewById<Button>(Resource.Id.button1);
            etxt = FindViewById<EditText>(Resource.Id.editText1);
            txtView = FindViewById<TextView>(Resource.Id.textView1);
            Button callHistoryButton = FindViewById<Button>(Resource.Id.btnCallHistory);

            btn.Click += Btn_Click;
            callHistoryButton.Click += CallHistoryButton_Click;

                         phoneNumberText = FindViewById<EditText>(Resource.Id.PhoneNumberText);
             translateButton = FindViewById<Button>(Resource.Id.TranslateButton);
             callButton = FindViewById<Button>(Resource.Id.callButton);
            // Disable the "Call" button
            callButton.Enabled = false;

            // Add code to translate number
            string translatedNumber = string.Empty;

            {
                // Translate user's alphanumeric phone number to numeric
                translatedNumber = Core.PhoneTranslator.ToNumber(phoneNumberText.Text);
                if (String.IsNullOrWhiteSpace(translatedNumber))
                {
                    callButton.Text = "Call";
                    callButton.Enabled = false;
                }
                else
                {
                    callButton.Text = "Call " + translatedNumber;
                    callButton.Enabled = true;
                }
            };



            callButton.Click += (object sender, EventArgs e) =>
            {
                // On "Call" button click, try to dial phone number.
                var callDialog = new AlertDialog.Builder(this);
                callDialog.SetMessage("Call " + translatedNumber + "?");
                callDialog.SetNeutralButton("Call", delegate
                {
                    // add dialed number to list of called numbers.
                    phoneNumbers.Add(translatedNumber);
                    // enable the Call History button
                    callHistoryButton.Enabled = true;
                    // Create intent to dial phone
                    var callIntent = new Intent(Intent.ActionDial);
                    callIntent.SetData(Android.Net.Uri.Parse("tel:" + translatedNumber));
                    StartActivity(callIntent);
                });


                callDialog.SetNegativeButton("Cancel", delegate { });

                // Show the alert dialog to the user and wait for response.
                callDialog.Show();
            };


        }

        private void CallHistoryButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(CallHistoryActivity));
            intent.PutStringArrayListExtra("phone_numbers", phoneNumbers);
            StartActivity(intent);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //txtView.Text = "hi " + etxt.Text;
            //throw new System.NotImplementedException();
            builder = new AlertDialog.Builder(this);
            AlertDialog alrtdiaobjt = builder.Create();
            alrtdiaobjt.SetTitle("Hi");
            alrtdiaobjt.SetMessage("Are you?");
            alrtdiaobjt.SetButton("Abort", (s, ev) =>
            {
                txtView.Text = "Abort Pressed";
            }
            );
            alrtdiaobjt.SetButton2("Retry", (s, ev) =>
            {
                txtView.Text = "Retry Pressed";
            }
            );
            alrtdiaobjt.SetButton3("Cancel", (s, ev) =>
            {
                txtView.Text = "Cancel Pressed";
            }
           );
            alrtdiaobjt.Show();

        }
       
    }
}

