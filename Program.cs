// See https://aka.ms/new-console-template for more information
using System;

FullTimeEmployee FTE = new FullTimeEmployee();
FTE.Firstname = "Nitin";
FTE.Lastname = "Singhal";
FTE.PrintFullName();

PartTimeEmployee PTE = new PartTimeEmployee();
PTE.Firstname = "John";
PTE.Lastname = "Doe";
PTE.PrintFullName();


public class Employee
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }        

    public void PrintFullName()
    {
        Console.WriteLine(Firstname + " " + Lastname);
    }
}

public class FullTimeEmployee : Employee
{
    
}

public class PartTimeEmployee : Employee
{
    public new void PrintFullName()
    {
        base.PrintFullName();
        //Console.WriteLine(Firstname + " " + Lastname + " - Contractor");
    }
}
