using System.Security.Cryptography;
using System.Text;

namespace TecniDev.Tools.Helpers
{
    public static class SecurityHelper
    {
        public static string Crypt(string key)
        {
            var data = Encoding.UTF8.GetBytes(key);
            var hashed = SHA512.HashData(data);
            StringBuilder builder = new();
            foreach (byte b in hashed)
                builder.Append(b.ToString("x2"));
            return builder.ToString();
        }
    }
}