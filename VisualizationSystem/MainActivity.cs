using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Configuration;
using VisualizationSystem.WebReference;

namespace VisualizationSystem
{
    [Activity(Label = "Стратегия", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var programConfig = ProgramConfig.CreateInstance();
            programConfig.Load();
            if (programConfig.UserSection != null)
            {
                UserService userService = new UserService();
                AuthorizationState retState;
                bool rez;
                string sessionCode;
                userService.Authorization(programConfig.UserSection.Login, programConfig.UserSection.Password, out retState, out rez, out sessionCode);
                if (retState == AuthorizationState.Success)
                {
                    programConfig.UserSection.SessionCode = sessionCode;
                    programConfig.Save();
                    StartActivity(typeof (AutorizedActivity));
                }
            }
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

