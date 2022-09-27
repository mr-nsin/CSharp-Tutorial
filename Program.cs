// See https://aka.ms/new-console-template for more information


BaseClass b = new DerivedClass();
b.Print();

public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("I am a Base Class Print Method");
    }
}

public class DerivedClass : BaseClass
{
    public override void Print()
    {
        Console.WriteLine("I am derived class print method");
    }
}

