using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime SpecifyKind = DateTime.Now.AddYears(-16);
            DateTime DOB = DateTime.Now;
            do
            {
                Console.Write("Enter your date of birth if you are 16 or over (dd/mm/yyyy): ");

                try
                {
                    DOB = DateTime.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error");
                    DOB = DateTime.Now;
                }
                if (DOB >= SpecifyKind)
                {
                    Console.WriteLine("This is invalid, enter again");
                }
            }
            while (DOB >= SpecifyKind);


           
            int height;
            
            do
            {
                Console.WriteLine("Enter your height in cm: ");
         
                try
                {
                    height = int.Parse(Console.ReadLine());
                }
                catch
                {                    
                    Console.WriteLine("Invalid input, you need to enter a number");
                    height = 99;
                }
                if (height > 250 || height < 100)
                {
                    Console.WriteLine("Your height must be between 100 and 250 cm, enter again if you meet these conditions: ");
                }
            } while (height < 100 || height > 250);
        }
    }
}
