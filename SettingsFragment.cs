using Android.OS;
using AndroidX.Fragment.App;
using AndroidX.Preference;

namespace PreferencesTry
{
    internal class SettingsFragment : PreferenceFragmentCompat
    {
        public override void OnCreatePreferences(Bundle savedInstanceState, string rootKey)
        {
            SetPreferencesFromResource(Resource.Xml.preferences, rootKey);
        }
    }
}