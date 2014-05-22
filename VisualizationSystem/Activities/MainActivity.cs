using Android.App;
using Android.OS;
using Android.Widget;
using Configuration;
using VisualizationSystem.WebReference;
using VisualizationSystem.WebReference1;

namespace VisualizationSystem.Activities
{
    [Activity(Label = "Стратегия", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var programConfig = ProgramConfig.CreateInstance();
            programConfig.Load();

            var versionService = new VersionService();
            VersionState versionState;
            bool rez;
            versionService.VerifyUserAppVersion(programConfig.VersionSection.CurrentVersion, out versionState,out rez); //check current version
            if (versionState == VersionState.OutDated)
                StartActivity(typeof(OutDatedVersionActivity));
            if (programConfig.UserSection != null)
            {
                var userService = new UserService();
                AuthorizationState retState;
                string sessionCode;
                userService.Authorization(programConfig.UserSection.Login, programConfig.UserSection.Password, out retState, out rez, out sessionCode); //try autorize user
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
            var logInButton = FindViewById<Button>(Resource.Id.log_in_button);
            var signUpButton = FindViewById<Button>(Resource.Id.sign_up_button);

            logInButton.Click += delegate { StartActivity(typeof(AutorizationActivity));};
            signUpButton.Click += delegate { StartActivity(typeof(RegistrationActivity)); };
        }
    }
}

