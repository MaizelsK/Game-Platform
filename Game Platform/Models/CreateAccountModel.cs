using Game_Platform.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Platform.Models
{
    public class CreateAccountModel : ValidatableObservableObject
    {
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                RaisePropertyChangedEvent("Email");
            }
        }

        private string login;
        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                RaisePropertyChangedEvent("Login");
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                RaisePropertyChangedEvent("Password");
            }
        }

        private string passwordConfirm;
        public string PasswordConfirm
        {
            get { return passwordConfirm; }
            set
            {
                passwordConfirm = value;
                RaisePropertyChangedEvent("PasswordConfirm");
            }
        }
    }
}