// See https://aka.ms/new-console-template for more information



Student C1 = new Student();
C1.SetID(101);
C1.SetName(null);

public class Student
{
    private int _id;
    private string _Name;
    private int _passMark = 35;

    public void SetName(string Name)
    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new Exception("Student name can't be null or empty");
        }
        this._Name = Name;
    }

    public string GetName()
    {
        if (string.IsNullOrEmpty(this._Name))
        {
            return "No Name";
        }
        else
        {
            return this._Name;
        }
    }


    public void SetID(int Id)
    {
        if (Id <= 0)
        {
            throw new Exception("Student ID can not be negative and zero");
        }
        this._id = Id;
    }

    public int GetID()
    {
        return this._id;
    }
}

