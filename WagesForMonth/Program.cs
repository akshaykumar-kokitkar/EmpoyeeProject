﻿//UC5
class program
{
    //constants
    public const int IS_PART_TIME = 0;
    public const int IS_FULL_TIME = 1;
    public const int EMP_RATE_PER_HOUR = 20;
    public const int WORKING_DAYS = 2;
    static void Main(string[] args)
    {
        //variables
        int empHrs = 0;
        int empWage = 0;
        int totalEmpWage = 0;

        //computation
        Random random = new Random();
        int empCheck = random.Next(0, 3);
        for (int day = 0; day < WORKING_DAYS; day++)
        {
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            totalEmpWage += empWage;
            Console.WriteLine("Emp Wage : " + empWage);
        }
        Console.WriteLine("Total emp wage : " + totalEmpWage);
    }
}