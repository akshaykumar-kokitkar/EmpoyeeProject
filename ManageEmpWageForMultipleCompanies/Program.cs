using System;

/*
Ability to manage Employee Wage of multiple companies
- Note: Refactor to have one EmpWageBuilder to manage for Wage for multiple Company
- Create CompanyEmpWage class and let EmpWageBuilder has array of many CompanyEmpWage Object
*/

namespace ManageEmpWageForMultipleCompanies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Welome to Employee Wage Program****");
            Console.WriteLine("=====================================================================================================");

            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.addCompanyEmpWage("TCS", 15, 3, 15);
            empWageBuilder.addCompanyEmpWage("HCL", 25, 5, 22);
            empWageBuilder.addCompanyEmpWage("Infosys", 30, 6, 25);
            empWageBuilder.computeEmpWage();
        }
    }
}
