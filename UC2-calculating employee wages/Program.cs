using System;

namespace UC2_calculating_employee_wages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constants
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            //Variables
            int empHrs = 0;
            int empWages = 0;
            Random random = new Random();
            //computation
            int empcheck = random.Next(0, 2);
            if (empcheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWages = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wages : * empWage");
        }
    }
}
