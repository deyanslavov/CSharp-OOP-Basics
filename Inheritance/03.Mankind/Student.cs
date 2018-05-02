using System;

public class Student : Human
{
    private string facultyNumber;

    public Student(string facultyNumber, string firstName, string lastName):base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get { return facultyNumber; }
        set
        {

            if (value.Length < 5 || value.Length > 10 || !ValidateFNumber(value))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            facultyNumber = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + Environment.NewLine + $"Faculty number: {this.FacultyNumber}";
    }

    private bool ValidateFNumber(string fn)
    {
        bool isValid = true;
        foreach (var @char in fn)
        {
            if (!char.IsLetterOrDigit(@char))
            {
                isValid = false;
                break;
            }
        }
        return isValid;
    }
}

