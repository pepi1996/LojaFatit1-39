using LojaFatitForm1_39.Modeli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaFatitForm1_39.Classes
{
    static class UserValidimi
    {
        public static string username;
        public static bool CheckUsernameIfExist(string username)
        {
            var context = new LojaContext();
            var lojtari = new Lojtari();

            lojtari = (from l in context.Lojtaret
                       where l.Username == username
                       select l).FirstOrDefault();

            if (lojtari != null)
            {
                return true;
            }

            return false;
        }
    }
}
