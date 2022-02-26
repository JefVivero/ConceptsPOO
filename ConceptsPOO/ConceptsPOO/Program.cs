using System;
using System.Collections.Generic;

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
                Id = 2,
                FirstName = "Juana",
                LastName = "Ortiz",
                BirthDate = new Date(1999, 7, 4),
                HiringDate = new Date(2022, 1, 15),
                IsActive = true,
                Sales = 430000000M,
                CommissionPercentaje = 0.03F
            };

            Employee Empleado3 = new HourlyEmployee()
            {
                Id = 3,
                FirstName = "Robert",
                LastName = "Gilbert",
                BirthDate = new Date(1999, 7, 4),
                HiringDate = new Date(2022, 1, 15),
                IsActive = true,
                HourValue = 12000M,
                Hours = 120.3F
            };
            Employee Empleado4 = new BaseCommissionEmployee()
            {
                Id = 4,
                FirstName = "Arturo",
                LastName = "Rodriguez",
                BirthDate = new Date(2000, 7, 4),
                HiringDate = new Date(2019, 1, 15),
                IsActive = true,
                Base = 800000M,
                CommissionPercentaje = 0.015F,
                Sales = 64000000M
            };

            /*Console.WriteLine(Empleado1);  ---- Proof Employee
            Console.WriteLine(Empleado2);
            Console.WriteLine(Empleado3);
            Console.WriteLine(Empleado4);*/


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

            ICollection<Employee> employees = new List<Employee>()
            {
                Empleado1, Empleado2, Empleado3, Empleado4
            };
            
            decimal payroll = 0;

            foreach (Employee employee in employees)
            {               
                Console.Write(employee);
                payroll += employee.GetValueToPay();
            }

            Console.WriteLine("\n\t                     ==================");
            Console.WriteLine($"\n\tTOTAL               :{$"{payroll:C2}",18}");

            Invoice invoice1 = new Invoice()
            {
                Id=0001,
                Description= "Pizza",
                Quantity= 57F,
                Price= 13000M
            };

            Console.WriteLine($"\n\t{invoice1}");

        }
    }
}
