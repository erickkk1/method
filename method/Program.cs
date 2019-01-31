using System;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first and last name please!");
          

            try
            {



                String name;
                name = Console.ReadLine();
               
                
                Console.WriteLine("Hello !" + name +" How are you doing?");
                Console.WriteLine("press any key to continue...");
                Console.ReadKey(true);

            }

            catch
            {
                Console.WriteLine("Enter a name please!");
                Console.ReadKey(true);

            }

        }
        

    }

}
