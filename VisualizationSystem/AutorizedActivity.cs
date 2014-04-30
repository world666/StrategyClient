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
using Configuration;

namespace VisualizationSystem
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

            var programConfig = ProgramConfig.CreateInstance();
            text.Text = programConfig.UserSection.SessionCode;

            unAutorizeButton.Click += delegate
                {
                    programConfig.UserSection = null;
                    programConfig.Save();
                    StartActivity(typeof(MainActivity));
                };
        }
    }
}