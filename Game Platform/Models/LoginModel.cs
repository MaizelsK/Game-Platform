using Game_Platform.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Platform.Models
{
    public class LoginModel : ObservableObject
    {
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

        private bool rememberMe;
        public bool RememberMe
        {
            get { return rememberMe; }
            set
            {
                rememberMe = value;
                RaisePropertyChangedEvent("RememberMe");
            }
        }
    }
}
