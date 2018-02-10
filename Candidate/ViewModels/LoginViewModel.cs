using Mobile.Core.ViewModels;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace Candidate.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        readonly IMvxNavigationService _navigationService;

        string _actualUsername = "charlie@me.com";
        string _actualPassword = "RubbishPassword";

        string _username;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        bool _wrongLogin;
        public bool WrongLogin
        {
            get { return _wrongLogin; }
            set { SetProperty(ref _wrongLogin, value); }
        }

        public IMvxCommand OrderClickCommand => new MvxCommand(Login);

        public LoginViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void Login()
        {
            if (_username == _actualUsername && _password == _actualPassword)
            {
                _wrongLogin = false;
                _navigationService.Navigate<CandidateResultsViewModel>();
            }
            else
            {
                _wrongLogin = true;
            }
        }
    }
}
