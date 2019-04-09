using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regerstrationform
{
    class Validatepass
    {
        public static string Passconfirm(string pass1, string pass2 )
        {
           if (pass1 == pass2)
            {
                return "Password confirmed";
            }
           else
            {
                return "The password are not the same "; 
            }
        }
    }
}
