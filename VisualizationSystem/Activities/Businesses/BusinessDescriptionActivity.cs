using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace VisualizationSystem.Activities.Businesses
{
    [Activity(Label = "Описание бизнеса")]
    public class BusinessDescriptionActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var layout = new LinearLayout(this) { Orientation = Orientation.Vertical };
            var aLabel = new TextView(this);
            aLabel.Text = Intent.GetStringExtra("BusinessDescription");
            layout.AddView(aLabel);
            SetContentView(layout);
        }
    }
}