// See https://aka.ms/new-console-template for more information
using System;

ChildClass ccObj = new ChildClass();


public class ParentClass
{
	public ParentClass()
	{
		Console.WriteLine("Parent Class Contstructor Called");
	}
}

public class ChildClass : ParentClass
{
	public ChildClass()
	{
		Console.WriteLine("Child Class Constructor Called");
	}
}
