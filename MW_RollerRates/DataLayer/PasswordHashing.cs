﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace DataLayer
{
    public class PasswordHashing
    {
        private static int iterations = 1000;
        public static string GenerateSalt()
        {
            byte[] salt = new byte[32];
            RNGCryptoServiceProvider rngProvider = new RNGCryptoServiceProvider();
            rngProvider.GetBytes(salt);
            string saltstring = Convert.ToBase64String(salt);

            return saltstring;
        }

        public static string GeneratePasswordHash(string password, string saltString)
        {
            var salt = Encoding.UTF8.GetBytes(saltString);
            Rfc2898DeriveBytes rfc2898 = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] key = rfc2898.GetBytes(32);
            string keyB64 = Convert.ToBase64String(key);
            return keyB64;
        }

        public static bool ValidateUser(string givenPass, string userSalt, string userHash)
        {
            string givenHash = GeneratePasswordHash(givenPass, userSalt);
            if (givenHash == userHash)
            {
                return true;
            }
            return false;
        }
    }
}
