using DataAccessLibrary;
using DataAccessLibrary.Entities;
using DataAccessLibrary.Helpers;
using Game_Platform.Helpers;
using Game_Platform.Models;
using Game_Platform.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
                return signInCommand ??
                    (signInCommand = new DelegateCommand(obj =>
                    {
                        using (DataContext context = new DataContext())
                        {
                            // Получаем хэш введенного пароля
                            PasswordHasher hasher = new PasswordHasher();
                            string passwordHash = hasher.Hash(Password);

                            // Ищем пользователя с ведденым логином и паролем
                            User user = context.Users.AsNoTracking()
                                            .FirstOrDefault(u => u.Username == Login && u.PasswordHash == passwordHash);

                            if (user != null)
                            {
                                // Аутентификация пользователя
                                SignInService service = new SignInService();
                                service.SignIn(user);
                            }
                            else
                            {
                                ShowErrorMessage("Ошибка аутентификации пользователя, повторите снова!");
                            }
                        }
                    }));
            }
        }

        private DelegateCommand cancelCommand;
        public DelegateCommand CancelCommand
        {
            get
            {
                return cancelCommand ??
                    (cancelCommand = new DelegateCommand(obj =>
                    {
                        Application.Current.Shutdown();
                    }));
            }
        }


        private DelegateCommand createAccountCommand;
        public DelegateCommand CreateAccountCommand;

        #endregion

        public void ShowErrorMessage(string message)
        {

        }

        public void ValidateModel()
        {

        }

    }
}
