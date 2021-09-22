using System;

namespace LA_1200_Muharemi
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie eine Zahl von 1-100 ein");
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            // int userGuess = Convert.ToInt32(Console.ReadLine());
            bool correct = false;
            while (!correct)

            {
                int userGuess = Convert.ToInt32(Console.ReadLine());
                int a = 1;
 
                if (userGuess < randomNumber)
                {
                    Console.WriteLine("Zu klein");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Geben sie eine Zahl von 1-100 ein");
                    a++;
                }


                else if (userGuess > randomNumber)
                {
                    Console.WriteLine("Zu gross");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Geben sie eine Zahl von 1-100 ein");
                    a++;
                }
                else
                {
                    correct = true;
                    Console.WriteLine("sie haben es geschaft");
                    Console.WriteLine("Sie habe" + a + "Versuche");
                }


            }
        }
    }
}
