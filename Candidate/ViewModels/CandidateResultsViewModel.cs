using MvvmCross.Core.ViewModels;

namespace Candidate.Core.ViewModels
{
    public class CandidateResultsViewModel : MvxViewModel
    {
        string _username = "Charlie";
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
    }
}
