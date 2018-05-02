using System;

public class Worker : Human
{
    private int workingHoursPerDay;
    private decimal weekSalary;
    
    public Worker(decimal weekSalary, int workingHoursPerDay, string firstName, string lastName):base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkingHoursPerDay = workingHoursPerDay;
    }

    public int WorkingHoursPerDay
    {
        get { return workingHoursPerDay; }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            workingHoursPerDay = value;
        }
    }

    public decimal WeekSalary
    {
        get { return weekSalary; }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            weekSalary = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() +Environment.NewLine + $"Week Salary: {this.WeekSalary:f2}\nHours per day: {this.WorkingHoursPerDay}\nSalary per hour: {this.WeekSalary / (this.WorkingHoursPerDay * 5):f2}";
    }
}

