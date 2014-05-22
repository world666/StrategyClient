using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Configuration;
using VisualizationSystem.WebReference4;

namespace VisualizationSystem.Activities.Businesses
{
    [Activity(Label = "Регионы")]
    public class RegionActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var programConfig = ProgramConfig.CreateInstance();

            var regionService = new RegionService();
            var layout = new LinearLayout(this) { Orientation = Orientation.Vertical };
            bool lang = true;
            bool id = true;
            int stateId = Intent.GetIntExtra("StateId", 1);
            var regions = regionService.GetRegions((Language) programConfig.GeneralSection.LanguageId, lang, stateId, id);
            foreach (var region in regions)
            {
                var regionsButton = new Button(this) { Text = region.RegionsNames, Tag = region.Id };
                regionsButton.Click += RegionClick;
                layout.AddView(regionsButton);
            }
            SetContentView(layout);
        }
        private void RegionClick(object Sender, EventArgs e)
        {
            var regionButton = Sender as Button;
            var activity = new Intent(this, typeof(BusinessActivity));
            activity.PutExtra("RegionId", (int)regionButton.Tag);
            StartActivity(activity);  
        }
    }
}