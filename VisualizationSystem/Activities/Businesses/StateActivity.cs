using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Configuration;
using VisualizationSystem.WebReference3;

namespace VisualizationSystem.Activities.Businesses
{
    [Activity(Label = "Государства")]
    public class StateActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var programConfig = ProgramConfig.CreateInstance();

            // Create your application here
            var layout = new LinearLayout(this) {Orientation = Orientation.Vertical};

            var stateService = new StateService();

            bool lang = true;
            var states = stateService.GetStates((Language)programConfig.GeneralSection.LanguageId, lang);
            foreach (var state in states)
            {
                var statesButton = new Button(this) { Text = state.StatesNames, Tag = state.Id};
                statesButton.Click += StateClick;
                layout.AddView(statesButton);
            }
            SetContentView(layout);
        }

        private void StateClick(object Sender, EventArgs e)
        {
            var stateButton = Sender as Button;
            var activity = new Intent(this, typeof (RegionActivity));
            activity.PutExtra("StateId", (int)stateButton.Tag);
            StartActivity(activity);
        }
    }
}