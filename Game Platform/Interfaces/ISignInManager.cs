// Simple interface for SignInServices with 2 main commands

using DataAccessLibrary.Entities;

namespace Game_Platform.Interfaces
{
    public interface ISignInManager
    {
        void SignIn(User user);
        void SignOut();
    }
}
