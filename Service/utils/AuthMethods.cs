using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Service.utils
{
    public class AuthMethods {
        static public byte[] GetSalt() {
            byte[] salt = new byte[32];
            using (var rng = RandomNumberGenerator.Create()) {
                rng.GetBytes(salt);
            }
            string result = Convert.ToBase64String(salt);
            return Encoding.ASCII.GetBytes(result);
        }

        static public byte[] GetCodeVerification() {
            byte[] salt = new byte[32 / 4];
            using (var rng = RandomNumberGenerator.Create()) {
                rng.GetBytes(salt);
            }
            string result = Convert.ToBase64String(salt);
            return Encoding.ASCII.GetBytes(result);
        }

        static public string EncodeByteToString(byte[] value) {
            return Encoding.UTF8.GetString(value);
        }

        static public string GetHashedPassword(string password, byte[] salt) {
            string hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: password,
                    salt: salt,
                    prf: KeyDerivationPrf.HMACSHA1,
                    iterationCount: 10000,
                    numBytesRequested: 256 / 8
                ));
            return hashedPassword;
        }

    }
}
