using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using static Android.Views.View;
using static Android.Locations.GpsStatus;

namespace Playfie.Droid
{
    [Activity(Label = "Playfie", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        TextView t;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            t = (TextView)FindViewById(Resource.Id.registrText);
            t.Click += goRegistr;
        }

        private void goRegistr(object sender, System.EventArgs e)
        {
            t = (TextView)FindViewById(Resource.Id.registrText);
            SetContentView(Resource.Layout.registration);
        }
    }
}

