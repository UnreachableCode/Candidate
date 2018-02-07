using NSubstitute;
using NUnit.Framework;
using Candidate.Core.ViewModels;
using MvvmCross.Core.Navigation;

namespace Candidate.Tests.ViewModels
{
    [TestFixture]
    public class LoginViewModelTests
    {
        [Test]
        public void Login_WhenCalledWithValidCredentials_SetsWrongLoginToFalse()
        {
            var _navigationService = Substitute.For<IMvxNavigationService>();
            var _loginViewModel = new LoginViewModel(_navigationService);

            _loginViewModel.Username = "charlie@me.com";
            _loginViewModel.Password = "RubbishPassword";

            _loginViewModel.Login();

            Assert.IsFalse(_loginViewModel.WrongLogin);
        }

        [Test]
        public void Login_WhenCalledWithInvalidCredentials_SetsWrongLoginToTrue()
        {
            var _navigationService = Substitute.For<IMvxNavigationService>();
            var _loginViewModel = new LoginViewModel(_navigationService);

            _loginViewModel.Username = "WrongUsername";
            _loginViewModel.Password = "WrongPassword";

            _loginViewModel.Login();

            Assert.IsTrue(_loginViewModel.WrongLogin);
        }
    }
}
