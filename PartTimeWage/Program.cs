//UC3
class progarm
{
    //constants
        public const int IS_PART_TIME = 0;
        public const int EMP_RATE_PER_HOUR = 20;
    static void Main(string[] args)
    {
        
        //variables
        int empHrs = 0;
        int empWage = 0;
        Random random = new Random();
        // Computation
        int empCheck = random.Next(0, 2);
        if (empCheck == IS_PART_TIME)
        {
            empHrs = 4;
            Console.WriteLine("Employee is part time\n  ");
        }
        else
        {
            empHrs = 8;
            Console.WriteLine("Employee is full time \n  ");

        }
        empWage = empHrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("Emp Wage : " + empWage);
    }
}