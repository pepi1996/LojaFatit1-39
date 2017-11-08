using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LojaFatitForm1_39.Classes
{
     static class Enkriptimi
    {

        public static string Md5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] rezultati = md5.Hash;

            StringBuilder str = new StringBuilder();

            for (var i = 0; i < rezultati.Length; i++)
            {
                str.Append(rezultati[i].ToString("x2"));
            }
            return str.ToString();
        }

   
    }
}
