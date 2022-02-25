using System;

namespace ConceptsPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POO Concepts");
            Console.WriteLine("-----------");

            try
            {
                Console.WriteLine(new Date(2022, 2, 3));
                Console.WriteLine(new Date(2022, 9, 3));
                Console.WriteLine(new Date(2022, 3, 34));
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
