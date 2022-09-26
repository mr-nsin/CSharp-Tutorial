// See https://aka.ms/new-console-template for more information
using System;

ChildClass ccObj = new ChildClass();


public class ParentClass
{
	public ParentClass()
	{
		Console.WriteLine("Parent Class Contstructor Called");
	}

	public ParentClass(string Message)
	{
		Console.WriteLine(Message);
	}
}

public class ChildClass : ParentClass
{
	public ChildClass() : base("Deerived class controlling Parent Class")
	{
		Console.WriteLine("Child Class Constructor Called");
	}
}
