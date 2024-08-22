using System.Text;
using TweetNaclSharp;

namespace discord
{
    public static class Validator
    {
        public static bool ValidateRequest(string timestamp, string message, string signature, string publicKey)
        {
            try
            {
                var body = timestamp + message;
                return Nacl.SignDetachedVerify(Encoding.UTF8.GetBytes(body), Encoding.UTF8.GetBytes(signature), Encoding.UTF8.GetBytes(publicKey));
            } catch (Exception)
            {
                return false;
            }
        }
    }
}
