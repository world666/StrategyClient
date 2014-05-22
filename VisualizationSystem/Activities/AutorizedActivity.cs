using Android.App;
using Android.OS;
using Android.Widget;
using Configuration;
using VisualizationSystem.Activities.Businesses;

namespace VisualizationSystem.Activities
{
    [Activity(Label = "Стратегия")]
    public class AutorizedActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.Autorized);

            var text = FindViewById<TextView>(Resource.Id.autorizedText);
            var unAutorizeButton = FindViewById<Button>(Resource.Id.unautorize_button);
            var businessButton = FindViewById<Button>(Resource.Id.business_button);
            var settingsButton = FindViewById<Button>(Resource.Id.settings_button);

            var programConfig = ProgramConfig.CreateInstance();
            text.Text = programConfig.UserSection.SessionCode;

            unAutorizeButton.Click += delegate
                {
                    programConfig.UserSection = null;
                    programConfig.Save();
                    StartActivity(typeof(MainActivity));
                };

            businessButton.Click += delegate
            {
                StartActivity(typeof(StateActivity));
            };

            settingsButton.Click += delegate
            {
                StartActivity(typeof(SettingsActivity));
            };
        }
    }
}