using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9944848_consoleRegistrationForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(userMessages.welcome);
            Console.WriteLine();
            Console.WriteLine(userMessages.pressanykey);
            Console.ReadKey();

            Console.Clear();


            Console.Write(userMessages.firstNameQuestion);
            string fname = Console.ReadLine();
            
            Console.Clear();


            Console.Write(userMessages.lastNameQuestion);
            string lname = Console.ReadLine();
            Console.Clear();


            
            
            Console.Write(userMessages.emailQuestion);
            string email = Console.ReadLine();
            Console.Clear();


            Console.Write(userMessages.passwordQuestion);
            string pass1 = Console.ReadLine();

            Console.WriteLine();

            Console.Write(userMessages.passwordConfirm);
            string pass2 = Console.ReadLine();
            Console.Clear();


            Console.WriteLine(Validatepass.Passconfirm(pass1, pass2));
            Console.ReadKey();

            Console.Clear();


            Console.WriteLine("Your Username is being automatically generated...");
            int userName = GenerateUName.UserName();
            Console.WriteLine();
            Console.WriteLine(userMessages.pressanykey);
            Console.ReadKey();
            Console.Clear();

            var list = new List<string>();
            list.Add("Your first name is " + fname);
            list.Add("Your last name is " + lname);
            list.Add("Your email is " + email);
            list.Add("Your password is " + pass1);
            list.Add("Your username is " + userName);


            foreach (var item in list)
                Console.WriteLine(item);                      

            Console.ReadKey();


        }
    }
}
