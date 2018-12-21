using Game_Platform.Helpers;
using Game_Platform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Platform.ViewModels
{
    public class LoginViewModel : ObservableObject
    {
        private LoginModel loginModel;

        public LoginViewModel()
        {
            loginModel = new LoginModel();
        }

        public string Login
        {
            get { return loginModel.Login; }
            set
            {
                loginModel.Login = value;
                RaisePropertyChangedEvent("Login");
            }
        }

        public string Password
        {
            get { return loginModel.Password; }
            set
            {
                loginModel.Password = value;
                RaisePropertyChangedEvent("Password");
            }
        }

        public bool RememberMe
        {
            get { return loginModel.RememberMe; }
            set
            {
                loginModel.RememberMe = value;
                RaisePropertyChangedEvent("RememberMe");
            }
        }

        #region Commands

        private DelegateCommand signInCommand;
        public DelegateCommand SignInCommand
        {
            get
            {
                return signInCommand ?? (
                    signInCommand = new DelegateCommand(obj =>
                    {
                        // Sign in...
                    }
                    ));
            }
        }

        private DelegateCommand cancelCommand;
        public DelegateCommand CancelCommand;


        private DelegateCommand createAccountCommand;
        public DelegateCommand CreateAccountCommand;


        #endregion
    }
}
