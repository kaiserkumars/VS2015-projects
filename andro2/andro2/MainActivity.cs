using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;


namespace andro2
{
    [Activity(Label = "andro2", MainLauncher = true, Icon = "@drawable/icon",Theme ="@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        Button btnLogin;
        EditText input_email, input_password;
        TextView btnSignUp, btnForgotPassword;
        RelativeLayout activity_main;
        public static FirebaseApp app;
        FirebaseAuth auth; 
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);

            InitFirebaseAuth();
        }

        private void InitFirebaseAuth()
        {
            var options = new FirebaseOptions.Builder()
            .SetApplicationId("1:751090211993:android:1f5f18b0b912f072")
            .SetApiKey("AIzaSyB7r1qu1F9XI3VTRGxs069D8imvs3xkbAg")
            .Build();

            if (app == null)
                app = FirebaseApp.InitializeApp(this, options);
            auth = FirebaseApp.GetInstance(app);
        }
    }
}

