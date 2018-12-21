// Simple interface for SignInServices with 2 main commands

namespace Game_Platform.Interfaces
{
    public interface ISignInManager
    {
        void SignIn(string username, string password);
        void SignOut();
    }
}
