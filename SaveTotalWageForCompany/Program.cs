using System;

/*
Ability to save the Total Wage for Each Company
- Note: You can Create EmpWageBuilder for each Company
- Use Instance Variable instead of function parameters
*/

namespace SaveTotalWageForCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder dMart = new EmpWageBuilder("DMart", 20, 2, 10);
            EmpWageBuilder reliance = new EmpWageBuilder("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}
