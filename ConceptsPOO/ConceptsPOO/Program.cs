using System;

namespace ConceptsPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POO Concepts");
            Console.WriteLine("-----------");

            Employee Empleado1 = new SalaryEmployee()
            {
                Id = 1,
                FirstName = "Pepito",
                LastName = "Perez",
                BirthDate = new Date(1986, 12, 18),
                HiringDate = new Date(2021, 6, 1),
                IsActive = true,
                Salary = 1200000.50M
            };

            Employee Empleado2 = new CommissionEmployee()
            {
                Id = 1,
                FirstName = "Juana",
                LastName = "Rodallega",
                BirthDate = new Date(1999, 7, 4),
                HiringDate = new Date(2022, 1, 15),
                IsActive = true,
                Sales = 430000000M,                
                CommissionPercentaje = 0.03F
            };

            Console.WriteLine(Empleado1);
            Console.WriteLine(Empleado2);

            /*try       -----Proof Date Class
            {
                Console.WriteLine(new Date(2022, 2, 3));
                Console.WriteLine(new Date(2022, 9, 3));
                Console.WriteLine(new Date(2022, 3, 34));
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }*/
        }
    }
}
