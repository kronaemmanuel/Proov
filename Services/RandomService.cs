using System;
using System.Text;

namespace Proov.Services
{
    class RandomService
    {
        Random r = new Random();

        public string GetRandomString(int length)
        {
            const string charPool = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            var rs = new StringBuilder();

            while (length > 0)
            {
                rs.Append(charPool[(int) (r.NextDouble() * charPool.Length)]);
                length--;
            }

            return rs.ToString();
        }
    }
}