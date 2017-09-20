using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Support.V4.App;

namespace AndroidNotificationCenter
{
    [Activity(Label = "AndroidNotificationCenter", MainLauncher = true)]
    public class MainActivity : Activity
    {

        private static readonly int ButtnClickNotification = 999;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            var btnSend = FindViewById<Button>(Resource.Id.btnSend);
            btnSend.Click += BtnSend_Click;
        }

        private void BtnSend_Click(object sender, System.EventArgs e)
        {
            Bundle valuesend = new Bundle();
            valuesend.PutString("SendContent", "This is the contentsendfrom notification");


            Intent newIntent = new Intent(this, typeof(Second_Activity));
            newIntent.PutExtras(valuesend);

            Android.Support.V4.App.TaskStackBuilder stackBuilder = Android.Support.V4.App.TaskStackBuilder.Create(this);
            stackBuilder.AddParentStack(Java.Lang.Class.FromType(typeof(Second_Activity)));
            stackBuilder.AddNextIntent(newIntent);

            PendingIntent resultPendingIntent = stackBuilder.GetPendingIntent(0, (int)PendingIntentFlags.UpdateCurrent);

            NotificationCompat.Builder builder = new NotificationCompat.Builder(this)
                .SetAutoCancel(true)
                .SetContentIntent(resultPendingIntent)
                .SetContentTitle("My Notifications")
                .SetSmallIcon(Resource.Drawable.Icon)
                .SetContentText("Click here to Next Activity");

            NotificationManager ntm = (NotificationManager)GetSystemService(Context.NotificationService);
            ntm.Notify(ButtnClickNotification, builder.Build());

        }
    }
}

