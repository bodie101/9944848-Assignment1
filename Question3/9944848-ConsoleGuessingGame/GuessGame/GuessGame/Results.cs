using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    class Results
    {
         public static void Display()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("**************** Guessing Game  ********************");
            Console.WriteLine("****************                ********************");
            Console.WriteLine("**************** 1. Level one   ********************");
            Console.WriteLine("**************** 2. Level two   ********************");
            Console.WriteLine("**************** 3. Level three ********************");
            Console.WriteLine("**************** 4. Exit        ********************");
            Console.WriteLine("****************                ********************");
            Console.WriteLine("****************************************************");
            int userinput = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if(userinput == 1)
            {
                ModeEasy.G1();
                Console.ReadKey();
            }
            if (userinput == 2)
            {
                ModeMedium.G2();
                Console.ReadKey();
            }
            if (userinput == 3)
            {
                ModeHard.G3();
                Console.ReadKey();
            }
            if (userinput == 0)
            {
                Environment.Exit(0);
            }
        }        
    }
}
