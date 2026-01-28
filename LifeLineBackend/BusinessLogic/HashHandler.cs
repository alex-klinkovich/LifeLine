using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class HashHandler
    {
        private const int saltSize = 16;
        private const int hashSize = 32;
        private const int iterations = 310_000;

        public static byte[] GenerateSalt()
        {
            byte[] salt = new byte[saltSize];
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            try
            {
                rng.GetBytes(salt);
                return salt;
            }
            finally
            {
                rng.Dispose();
            }
        }

        public static byte[] AddSalt(string password, byte[] salt)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] combinedPassword = new byte[passwordBytes.Length + salt.Length];

            Buffer.BlockCopy(passwordBytes, 0, combinedPassword, 0, passwordBytes.Length);
            Buffer.BlockCopy(salt, 0, combinedPassword, passwordBytes.Length, salt.Length);

            return combinedPassword;
        }
        public static byte[] HashPassword(string password, byte[] salt)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256);
            try
            {
                return pbkdf2.GetBytes(hashSize);
            }
            finally
            {
                pbkdf2.Dispose();
            }              
        }
        public static string EncodeHashed(byte[] hashedPassword)
        {
            return Convert.ToBase64String(hashedPassword);
        }
    }
}
