// See https://aka.ms/new-console-template for more information


Employee[] employees = new Employee[4];

employees[0] = new Employee();
employees[1] = new PartTimeEmployee();
employees[2] = new FullTimeEmployee();
employees[3] = new TemporaryEmployee();


foreach (Employee employee in employees)
{
    employee.PrintFullName();
}


public class Employee
{
    public string Firstname = "FN";
    public string Lastname = "LN";      

    public virtual void PrintFullName()
    {
        Console.WriteLine(Firstname + " " + Lastname);
    }
}

public class FullTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(Firstname + " " + Lastname + " - Full Time");
    }
    
}

public class PartTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(Firstname + " " + Lastname + " - Part Time");
    }
}

public class TemporaryEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(Firstname + " " + Lastname + " - Temporary");
    }
}

