using Android.App;
using Xamarin.Essentials;

namespace PreferencesTry
{
    public class Settings
    {
        public static bool IsMediusInstalled
        {
            get 
            { 
                return Preferences.Get(Application.Context.GetString(Resource.String.has_medius_installed_key), true);
            }
            //set { myVar = value; }
        }

        public static string CompanyTag
        {
            get
            {
                return Preferences.Get(Application.Context.GetString(Resource.String.company_tag_key), "10");
            }
        }
    }
}
