using System;
using System.Security.Cryptography;

namespace DataAccessLibrary.Helpers
{
    // Класс для генерации хэша пароля
    // И его проверке при входе пользователя
    public class PasswordHasher
    {
        public int saltSize;
        public int iterationSize;
        public int pseudoRandomSize;

        public PasswordHasher()
        {
            saltSize = 16;
            iterationSize = 2000;
            pseudoRandomSize = 20;
        }

        // Хэширование пароля
        public string Hash(string password)
        {
            byte[] salt = new byte[saltSize];
            new RNGCryptoServiceProvider().GetBytes(salt);

            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(password, salt, iterationSize);
            byte[] hash = rfc.GetBytes(pseudoRandomSize);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, saltSize);
            Array.Copy(hashBytes, 0, hash, saltSize, pseudoRandomSize);

            return Convert.ToBase64String(hashBytes);
        }

        // Проверка, введенного пользователем, пароля
        public bool VerifyPassword(string enteredPassword, string passwordHash)
        {
            byte[] hashBytes = Convert.FromBase64String(passwordHash);
            byte[] salt = new byte[saltSize];

            Array.Copy(hashBytes, 0, salt, 0, saltSize);

            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(enteredPassword, salt, iterationSize);
            byte[] hash = rfc.GetBytes(pseudoRandomSize);

            // Если хоть один символ не совпадает
            // Возвращаем false, т.к. пароль не совпал  
            for (int i = 0; i < hash.Length; i++)
                if (hashBytes[i + saltSize] != hash[i])
                    return false;

            return true;
        }
    }
}
