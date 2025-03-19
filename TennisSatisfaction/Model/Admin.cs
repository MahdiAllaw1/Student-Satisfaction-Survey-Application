using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TennisSatisfaction.Model
{
    internal class Admin : Person
    {
        private string password;

        public Admin(string name, string password) : base(name)
        {
            this.password = Encrypt(password);
        }

        private static string Encrypt(string plainText)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(plainText);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
        // Verify password
        public bool VerifyPassword(string providedPassword)
        {
            return password == Encrypt(providedPassword);
        }
        // verify name
        public bool VerifyName(string providedName)
        {
            return this.Name == providedName;
        }

    }
}
