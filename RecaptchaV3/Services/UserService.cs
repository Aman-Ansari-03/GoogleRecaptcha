using RecaptchaV3.Models;

namespace RecaptchaV3.Services
{
    public static class UserService
    {
        private static User ValidUser = new User() { Name = "cloudanalogy", Password = "1213" };
        public static bool IsValid(User user)
        {
            if (user == null) { return false; }
            return ValidUser.Name == user.Name && ValidUser.Password == user.Password;
        }
    }
}
