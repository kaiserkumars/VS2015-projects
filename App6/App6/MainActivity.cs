using Android.App;
using Android.Widget;
using Android.OS;

namespace App6
{
    [Activity(Label = "StudioApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button button = FindViewById<Button>(Resource.Id.button1);
            var label = FindViewById<TextView>(Resource.Id.textView1);
            button.Click += delegate
            {
                count++;
                label.Text = $"You clicked {count} times!";
                // button.Text = string.Format("{0} clicks!", count++); };
            };
        }
    }
}

