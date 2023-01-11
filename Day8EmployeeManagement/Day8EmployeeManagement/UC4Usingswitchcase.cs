using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8EmployeeManagement
{
    internal class UC4Usingswitchcase
    {
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public const int EMP_RATE_PER_HOUR = 20;
        public static void switchcase()
        {
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                case IS_FULL_TIME:
                    Console.WriteLine("Employee is Working FullTime");
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    Console.WriteLine("Employee is Working PartTIme");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    empHrs = 0;
                    break;
            }
empWage = empHrs * EMP_RATE_PER_HOUR;
Console.WriteLine("Employee Wage : " + empWage);
        }
    }
}
