using Android.App;
using Android.Widget;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCrossFragment.Core.ViewModels;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace MvvmCrossFragment.Droid.Views
{
    [MvxActivityPresentation]
    [Activity(Theme = "@style/AppTheme", Label = "MvvmCross Fragment", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : MvxAppCompatActivity<RootViewModel>
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.RootView);

        }
    }
}

