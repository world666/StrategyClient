using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace VisualizationSystem
{
    [Activity(Label = "MainActivity", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button logInButton = FindViewById<Button>(Resource.Id.log_in_button);
            Button signUpButton = FindViewById<Button>(Resource.Id.sign_up_button);

            logInButton.Click += delegate { StartActivity(typeof(AutorizationActivity));};
            signUpButton.Click += delegate { StartActivity(typeof(RegistrationActivity)); };
        }
    }
}

