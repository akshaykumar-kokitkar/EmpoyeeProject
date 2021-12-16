//UC1
class Program
{
    //constants
    public const int IS_FULL_TIME = 1;
    static void Main(string[] args)
    {
        Random random = new Random();
        //computation
        int empCheck = random.Next(0, 2);
        if (empCheck == IS_FULL_TIME)
        {
            Console.WriteLine("Employee is Present");
        }
        else
        {
            Console.WriteLine("Employee is Absent");
        }
    }
}