using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.Widget;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Support.V7.AppCompat;
using Sample.Core.ViewModels;
using System.Collections.Generic;

namespace Sample.Droid.Views
{
    [Activity(Label = "Employee Detail", Theme = "@style/HoloTheme")]
    public class EmployeeDetailView : MvxCachingFragmentCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.EmployeeDetailView);

            var toolbar = FindViewById<Toolbar>(Resource.Id.myToolbar);

            if(toolbar != null)
            {
                SetSupportActionBar(toolbar);
            }
            // View Pager
            var viewPager = FindViewById<ViewPager>(Resource.Id.viewpager);
            if (viewPager != null)
            {
                // Add tabs in view pager

                var fragments = new List<MvxFragmentStatePagerAdapter.FragmentInfo>
                {
                    new MvxFragmentStatePagerAdapter.FragmentInfo("EmpDetail", typeof(Tab_EmployeeDetail), typeof(EmployeeDetailViewModel)),
                    new MvxFragmentStatePagerAdapter.FragmentInfo("Address", typeof(Tab_EmployeeAddress),typeof(EmployeeDetailViewModel))
                    //new MvxFragmentStatePagerAdapter.FragmentInfo(TAB_LOCATION, typeof(Tab_CustomerLocation),typeof(EmployeeEditorViewModel)),
                    //new MvxFragmentStatePagerAdapter.FragmentInfo(TAB_CONTRACT, typeof(Tab_CustomerContract),typeof(EmployeeEditorViewModel))
                };
                viewPager.Adapter = new MvxFragmentStatePagerAdapter(this, SupportFragmentManager, fragments);
            }

            var tabLayout = FindViewById<TabLayout>(Resource.Id.tabs);
            tabLayout.SetupWithViewPager(viewPager);
        }
                
    }
}