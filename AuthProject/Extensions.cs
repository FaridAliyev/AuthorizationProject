using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AuthProject
{
    public static class Extensions
    {
        public static bool IsEmail(this string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string HashPassword(this string password)
        {
            byte[] bytePass = Encoding.ASCII.GetBytes(password);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] hashedbytePass = md5.ComputeHash(bytePass);
            return Encoding.ASCII.GetString(hashedbytePass);
        }
    }
}
