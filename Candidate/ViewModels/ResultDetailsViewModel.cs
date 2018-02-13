using MvvmCross.Core.ViewModels;

namespace Mobile.Core.ViewModels
{
    public class ResultDetailsViewModel : MvxViewModel
    {
        string _username = "Charlie";
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
    }
}
