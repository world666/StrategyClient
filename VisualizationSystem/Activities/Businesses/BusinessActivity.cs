using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Configuration;
using VisualizationSystem.WebReference5;


namespace VisualizationSystem.Activities.Businesses
{
    [Activity(Label = "Бизнес")]
    public class BusinessActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var programConfig = ProgramConfig.CreateInstance();

            var businessService = new BusinessService();
            var layout = new LinearLayout(this) { Orientation = Orientation.Vertical };
            bool lang = true;
            bool id = true;
            int regionId = Intent.GetIntExtra("RegionId", -1);
            var businesses = businessService.GetBusinesses((Language)programConfig.GeneralSection.LanguageId, lang, regionId, id);
            foreach (var business in businesses)
            {
                var businessButton = new Button(this) { Text = business.BusinessesNames, Tag = business.Descriptions };
                businessButton.Click += BusinessClick;
                layout.AddView(businessButton);
            }
            SetContentView(layout);// Create your application here
        }

        private void BusinessClick(object Sender, EventArgs e)
        {
            var businessButton = Sender as Button;
            var activity = new Intent(this, typeof(BusinessDescriptionActivity));
            activity.PutExtra("BusinessDescription", businessButton.Tag.ToString());
            StartActivity(activity);
        }
    }
}