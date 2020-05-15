using Android.App;
using Android.OS;
using Android.Support.V7.App;

using Java.Lang;
using Android.Util;
using Android.Runtime;
using Com.Badoo.Mobile.Util;


namespace DemoAndroidWeakHandler
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IRunnable
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            new WeakHandler().PostDelayed(this, 1000);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public void Run()
        {
            Log.Debug("MainActivity", "ok");
        }
    }
}