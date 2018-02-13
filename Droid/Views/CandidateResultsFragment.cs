using Android.Runtime;
using Candidate.Core.ViewModels;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;

namespace Candidate.Droid.Views
{
    [MvxFragment(typeof(MainResultsViewModel), Resource.Id.content_frame, true)]
    [Register("Candidate.Droid.Views.CandidateResultsFragment")]
    public class CandidateResultsFragment : BaseFragment<CandidateResultsViewModel>
    {
        protected override int FragmentId => Resource.Layout.CandidateResultsFragment;
    }
}