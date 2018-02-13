using Android.App;
using Android.Content.PM;
using Android.OS;
using Candidate.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace Candidate.Droid.Views
{
    [Activity(Label = "Candidate", LaunchMode = LaunchMode.SingleTop, Theme = "@style/Theme.AppCompat.NoActionBar")]
    public class ResultsContainerActivity : MvxAppCompatActivity<MainResultsViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ResultsContainerActivity);
        }
    }
}

