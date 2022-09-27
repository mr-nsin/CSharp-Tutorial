// See https://aka.ms/new-console-template for more information



Student C1 = new Student();
C1.Id = 101;
C1.Name = "Nitin";


public class Student
{
    private int _id;
    private string _Name;
    private int _passMark = 35;

    public int PassMark
    {
        get
        {
            return this._passMark;
        }
    }

    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Student name can't be null or empty");
            }
            this._Name = value;
        }
        get
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
        
    }

    public int Id
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("Student ID can not be negative and zero");
            }
        }
        get
        {
            return this._id;
        }
        
    }
}

