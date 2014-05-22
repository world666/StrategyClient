using Android.App;
using Android.OS;

namespace VisualizationSystem.Activities
{
    [Activity(Label = "Версия")]
    public class OutDatedVersionActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.OutDatedVersion);
            // Create your application here
        }
    }
}