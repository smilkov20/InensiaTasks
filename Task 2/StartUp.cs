namespace Task_2
{
    using System;

    using static TaskConstants;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This program expects gross salary and it returns net salary value.");
            Console.WriteLine("To close the program please enter 'Exit' for value.");

            var input = Console.ReadLine();

            /** The taxable values are stored in 'TaskConstants' file to make it easier to change percentages and taxable values.
             * In case you want to add new taxes you have to add new constant for the tax and add logic before 'var totalTaxes' declaration.
             * Note that the 'taxableSalary' is recalculated for every tax condition!
             */

            while (input.ToLower() != "exit")
            {
                if (!int.TryParse(input, out var salary))
                {
                    Console.WriteLine("Invalid salary value!");
                }
                else
                {
                    if (salary <= NotTaxableSalary)
                    {
                        Console.WriteLine($"Net salary is {salary}");
                    }
                    else
                    {
                        var taxableSalary = salary - NotTaxableSalary;

                        var incomeTax = taxableSalary * IncomeTaxPercent;

                        if (salary > SocialContributionMaxAmount)
                        {
                            taxableSalary = SocialContributionMaxAmount - NotTaxableSalary;
                        }

                        var socialContributionTax = taxableSalary * SocialContributionPercent;

                        var totalTaxes = incomeTax + socialContributionTax;
                        Console.WriteLine($"Income taxes : {incomeTax}");
                        Console.WriteLine($"Social contribution taxes : {socialContributionTax}");
                        Console.WriteLine($"Total taxes : {totalTaxes}");
                        Console.WriteLine($"Salary net value : {salary - totalTaxes}");
                    }

                }
                input = Console.ReadLine();
            }
        }
    }
}
