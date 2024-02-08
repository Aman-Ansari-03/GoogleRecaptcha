namespace RecaptchaV3.Extensions
{
    public interface IRecaptchaExtension
    {
        Task<bool> VerifyRecaptchaTokenAsync(string token);
    }
}
