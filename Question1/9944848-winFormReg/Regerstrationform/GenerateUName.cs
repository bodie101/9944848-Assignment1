using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regerstrationform
{
    class GenerateUName
    {
        public static int UserName()
        {
            Random rnd = new Random();
            return int.Parse($"4{rnd.Next(100000, 9999999)}");
        }

        public static string Student(string fname, string lname, string email, int studentid)
        {
            string name = $"Your name is {fname} {lname} ";
            string gmail = $"Your email is {email}";
            
            string idnumber = $"Your student id is {studentid}";

            return $"{name}\n{idnumber}\n{gmail}";
        }
    }
}



