using System;
using System.Security.Cryptography;

namespace GreenLifeOS
{
    public static class PasswordHasher
    {
        private const int SaltSize = 16;       // 128-bit
        private const int HashSize = 32;       // 256-bit
        private const int Iterations = 100000; // OWASP recommended minimum

        /// <summary>
        /// Hash a password using PBKDF2
        /// </summary>
        public static string HashPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password cannot be empty.");

            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[SaltSize];
                rng.GetBytes(salt);

                using (var pbkdf2 = new Rfc2898DeriveBytes(
                    password,
                    salt,
                    Iterations,
                    HashAlgorithmName.SHA256))
                {
                    byte[] hash = pbkdf2.GetBytes(HashSize);

                    // Format: iterations.salt.hash
                    return $"{Iterations}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
                }
            }
        }

        /// <summary>
        /// Verify a password against stored hash
        /// </summary>
        public static bool VerifyPassword(string password, string storedHash)
        {
            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(storedHash))
                return false;

            var parts = storedHash.Split('.');
            if (parts.Length != 3)
                return false;

            int iterations = int.Parse(parts[0]);
            byte[] salt = Convert.FromBase64String(parts[1]);
            byte[] storedPasswordHash = Convert.FromBase64String(parts[2]);

            using (var pbkdf2 = new Rfc2898DeriveBytes(
                password,
                salt,
                iterations,
                HashAlgorithmName.SHA256))
            {
                byte[] computedHash = pbkdf2.GetBytes(storedPasswordHash.Length);

                return AreHashesEqual(storedPasswordHash, computedHash);
            }
        }

        /// <summary>
        /// Prevents timing attacks
        /// </summary>
        private static bool AreHashesEqual(byte[] hash1, byte[] hash2)
        {
            if (hash1.Length != hash2.Length)
                return false;

            int diff = 0;
            for (int i = 0; i < hash1.Length; i++)
                diff |= hash1[i] ^ hash2[i];

            return diff == 0;
        }
    }
}
