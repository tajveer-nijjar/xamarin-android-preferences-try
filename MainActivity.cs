using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Snackbar;
using Xamarin.Essentials;
using static PreferencesTry.Settings;
using Android.Widget;

namespace PreferencesTry
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button _getAllSettingsButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Title = "Preference Try";

            SupportFragmentManager
                .BeginTransaction()
                .Replace(Resource.Id.settings_container, new SettingsFragment())
                .Commit();

            _getAllSettingsButton = FindViewById<Button>(Resource.Id.getAllSettingsButton);

            _getAllSettingsButton.Click += GetAllSettingsButton_Click;
        }

        private void GetAllSettingsButton_Click(object sender, EventArgs e)
        {
            var x = IsMediusInstalled;
            var y = CompanyTag;
        }
    }
}
