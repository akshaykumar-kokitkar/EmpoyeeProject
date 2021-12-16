//UC6
class program
{
    //constants
    public const int IS_PART_TIME = 0;
    public const int IS_FULL_TIME = 1;
    public const int EMP_RATE_PER_HOUR = 20;
    public const int WORKING_DAYS = 2;
    public const int MAX_HOURS_IN_MONTH = 10;
    static void Main(string[] args)
    {
        //variables
        int empHrs = 0;
        int totalEmpHrs = 0;
        int totalWorkingDays = 0;

        //computation
        while (totalEmpHrs <= MAX_HOURS_IN_MONTH && totalWorkingDays < WORKING_DAYS)
        {
            totalWorkingDays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
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
             totalEmpHrs += empHrs;
            Console.WriteLine("Days : " + totalWorkingDays + " emp hrs : " + empHrs);    

        }
        int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("Total emp wage : " + totalEmpWage);
    }
}