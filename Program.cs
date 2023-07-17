using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Employee Salary Calculation System");

        Console.WriteLine("Choose Employee Type:");
        Console.WriteLine("1. HR");
        Console.WriteLine("2. Admin");
        Console.WriteLine("3. Software Developer");

        int employeeType = int.Parse(Console.ReadLine());

        int workingHours, workingDays, projectHandles, extras;
        double monthlySalary;

        switch (employeeType)
        {
            case 1: //Case for  HR
                Console.Write("Enter working hours: ");
                workingHours = int.Parse(Console.ReadLine());

                Console.Write("Enter number of working days: ");
                workingDays = int.Parse(Console.ReadLine());

                monthlySalary = CalculateSalary(workingHours, workingDays);
                break;

            case 2: //Case for  Admin
                Console.Write("Enter working hours: ");
                workingHours = int.Parse(Console.ReadLine());

                Console.Write("Enter number of working days: ");
                workingDays = int.Parse(Console.ReadLine());

                Console.Write("Enter project handles: ");
                projectHandles = int.Parse(Console.ReadLine());

                monthlySalary = CalculateSalary(workingHours, workingDays, projectHandles);
                break;

            case 3: // Case for Software Developer
                Console.Write("Enter working hours: ");
                workingHours = int.Parse(Console.ReadLine());

                Console.Write("Enter number of working days: ");
                workingDays = int.Parse(Console.ReadLine());

                Console.Write("Enter project handles: ");
                projectHandles = int.Parse(Console.ReadLine());

                Console.Write("Enter extras: ");
                extras = int.Parse(Console.ReadLine());

                monthlySalary = CalculateSalary(workingHours, workingDays, projectHandles, extras);
                break;

            default:
                Console.WriteLine("Invalid employee type");
                return;
        }

        Console.WriteLine("Monthly Salary: $" + monthlySalary);
    }
    //Method to calculate the salary based on Input parametres 
    static double CalculateSalary(int workingHours, int workingDays, int projectHandles = 0, int extras = 0)
    {
        double baseSalary = (workingHours * workingDays * 100) + (projectHandles * 3000) + (extras * 2000);
        return baseSalary;
    }
}