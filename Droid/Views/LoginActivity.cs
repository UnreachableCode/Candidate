using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using Candidate.Core.ViewModels;

namespace Candidate.Droid.Views
{
    [Activity(Label = "Candidate", MainLauncher = true, Icon = "@mipmap/icon")]
    public class LoginActivity : MvxActivity<LoginViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnViewModelSet();
            SetContentView(Resource.Layout.Login);
        }
    }
}

