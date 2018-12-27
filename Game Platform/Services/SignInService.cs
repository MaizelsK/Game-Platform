using Game_Platform.Interfaces;
using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Entities;

namespace Game_Platform.Services
{
    public class SignInService : ISignInManager
    {
        public void SignIn(User user)
        {
            ApplicationService.CurrentUser = user;
        }

        public void SignOut()
        {
            ApplicationService.CurrentUser = null;
        }
    }
}
