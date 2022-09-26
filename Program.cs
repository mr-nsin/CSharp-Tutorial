// See https://aka.ms/new-console-template for more information
using System;

FullTimeEmployee FTE = new FullTimeEmployee();
FTE.Firstname = "Nitin";
FTE.Lastname = "Singhal";
FTE.Email = "singhal.nitin108@yahoo.com";
FTE.YearlySalary = 500000;
FTE.PrintFullName();

public class Employee
{
    public string Firstname;
    public string Lastname;
    public string Email;

    public void PrintFullName()
    {
        Console.WriteLine(Firstname + " " + Lastname);
        }
}

public class FullTimeEmployee : Employee
{
    public float YearlySalary;
}

public class PartTimeEmployee : Employee
{
    public float HourlyRate;
}

