using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using Sample.Core.ViewModels;

namespace Sample.Droid.Views
{
    [Activity(Label = "Employee List", Theme = "@style/HoloTheme")]
    public class EmployeeView : MvxAppCompatActivity<EmployeeViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.EmployeeView);
        }
    }
}