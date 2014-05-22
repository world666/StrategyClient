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

namespace VisualizationSystem.Activities
{
    [Activity(Label = "Настройки")]
    public class SettingsActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var programConfig = ProgramConfig.CreateInstance();

            var layout = new LinearLayout(this) { Orientation = Orientation.Vertical };


            var radioGroup = new RadioGroup(this);
            var englishRadio = new RadioButton(this) { Text = "English" , Tag = 0};
            var russianRadio = new RadioButton(this) { Text = "Русский" , Tag = 1};

            englishRadio.CheckedChange += RadioClick;
            russianRadio.CheckedChange += RadioClick;
            radioGroup.AddView(englishRadio);
            radioGroup.AddView(russianRadio);

            if (programConfig.GeneralSection.LanguageId == 0)
                englishRadio.Checked = true;
            else
                russianRadio.Checked = true;

            
            layout.AddView(radioGroup);

            // Create your application here
            SetContentView(layout);
        }

        private void RadioClick(object Sender, EventArgs e)
        {
            var radioButton = Sender as RadioButton;
            if(!radioButton.Checked)
                return;
            var programConfig = ProgramConfig.CreateInstance();  
            programConfig.GeneralSection.LanguageId = (int)radioButton.Tag;
            programConfig.Save();
        }
    }
}