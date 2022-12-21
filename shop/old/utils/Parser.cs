using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DB_scientificLibrary.utils
{
    static class Parser
    {
        private const int SALT_LENGTH = 24;
        private const int DERIVED_KEY_LENGTH = 24;
        private const int SALT_SIZE = 8;
        private const int NUM_ITERATIONS = 1000;

        private static readonly RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

        public static bool checkEmail(string email)
        {
            if (email == null) return false;

            Regex mRegxExpression;
            if (email.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(email.Trim()))
                {
                    return false;
                }
                else return true;
            }
            return false;
        }

        public static bool checkFIO(string fio)
        {
            if (fio == "") return false;

            Regex r = new Regex(@"[\d!#@$%^&*()-+_={}'?.,`~]");
            Match m = r.Match(fio);
            if (m.Success) return false;
            return true;
        }

        public static string CreatePasswordHash(string password)
        {
            byte[] buf = new byte[SALT_SIZE];
            rng.GetBytes(buf);
            string salt = Convert.ToBase64String(buf);

            Rfc2898DeriveBytes deriver2898 = new Rfc2898DeriveBytes(password.Trim(), buf, NUM_ITERATIONS);
            string hash = Convert.ToBase64String(deriver2898.GetBytes(16));
            return salt + ':' + hash;
        }

        public static bool VerifyPassword(string password, string saltHash)
        {
            string[] parts = saltHash.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 2)
                return false;
            byte[] buf = Convert.FromBase64String(parts[0]);
            Rfc2898DeriveBytes deriver2898 = new Rfc2898DeriveBytes(password.Trim(), buf, NUM_ITERATIONS);
            string computedHash = Convert.ToBase64String(deriver2898.GetBytes(16));
            return parts[1].Equals(computedHash);
        }

        //public static string CreatePasswordHash(string password, int iterationCount = 15013)
        //{
        //    if (password == null) throw new ArgumentNullException(nameof(password));

        //    byte[] salt = GenerateRandomSalt(SALT_LENGTH);
        //    //byte[] salt = { 0, 0, 0, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 0 };
        //    byte[] hashValue = GenerateHashValue(password, salt, iterationCount);
        //    byte[] iterationCountByteArr = BitConverter.GetBytes(iterationCount);
        //    var valueToSave = new byte[SALT_LENGTH + DERIVED_KEY_LENGTH + iterationCountByteArr.Length];
        //    Buffer.BlockCopy(salt, 0, valueToSave, 0, SALT_LENGTH);
        //    Buffer.BlockCopy(hashValue, 0, valueToSave, SALT_LENGTH, DERIVED_KEY_LENGTH);
        //    Buffer.BlockCopy(iterationCountByteArr, 0, valueToSave, salt.Length + hashValue.Length, iterationCountByteArr.Length);
        //    return Convert.ToBase64String(valueToSave);
        //}

        //private static byte[] GenerateRandomSalt(int saltLength)
        //{
        //    using (var csprng = new RNGCryptoServiceProvider())
        //    {
        //        var salt = new byte[saltLength];
        //        csprng.GetBytes(salt);
        //        return salt;
        //    }
        //}

        //private static byte[] GenerateHashValue(string password, byte[] salt, int iterationCount)
        //{
        //    using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterationCount))
        //    {
        //        return pbkdf2.GetBytes(DERIVED_KEY_LENGTH);
        //    }
        //}

        //public static bool VerifyPassword(string passwordGuess, string passwordHash)
        //{
        //    //ingredient #1: password salt byte array
        //    var salt = new byte[SALT_LENGTH];

            
        //    //ingredient #2: byte array of password
        //    var actualPasswordByteArr = new byte[DERIVED_KEY_LENGTH];

        //    //convert actualSavedHashResults to byte array
        //    //Convert.From
        //    byte[] actualSavedHashResultsBtyeArr = Convert.FromBase64String(passwordHash);
            
        //    //ingredient #3: iteration count
        //    int iterationCountLength = actualSavedHashResultsBtyeArr.Length - (salt.Length + actualPasswordByteArr.Length);
        //    byte[] iterationCountByteArr = new byte[iterationCountLength];
        //    Buffer.BlockCopy(actualSavedHashResultsBtyeArr, 0, salt, 0, SALT_LENGTH);
        //    Buffer.BlockCopy(actualSavedHashResultsBtyeArr, SALT_LENGTH, actualPasswordByteArr, 0, actualPasswordByteArr.Length);
        //    Buffer.BlockCopy(actualSavedHashResultsBtyeArr, (salt.Length + actualPasswordByteArr.Length), iterationCountByteArr, 0, iterationCountLength);
        //    byte[] passwordGuessByteArr = GenerateHashValue(passwordGuess, salt, BitConverter.ToInt32(iterationCountByteArr, 0));
        //    return ConstantTimeComparison(passwordGuessByteArr, actualPasswordByteArr);
        //}


        //private static bool ConstantTimeComparison(byte[] passwordGuess, byte[] actualPassword)
        //{
        //    uint difference = (uint)passwordGuess.Length ^ (uint)actualPassword.Length;
        //    for (var i = 0; i < passwordGuess.Length && i < actualPassword.Length; i++)
        //    {
        //        difference |= (uint)(passwordGuess[i] ^ actualPassword[i]);
        //    }

        //    return difference == 0;
        //}
    }
}
