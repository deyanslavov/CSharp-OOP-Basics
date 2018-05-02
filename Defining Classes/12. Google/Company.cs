public class Company
{
    private string name;
    private string department;
    private decimal salary;
    
    public Company()
    {
    }

    public Company(string name, string department, decimal salary)
    {
        this.name = name;
        this.department = department;
        this.salary = salary;
    }

    public string Name
    {
        get { return this.name; }
        set { name = value; }
    }
    
    public string Department
    {
        get { return this.department; }
        set { department = value; }
    }
    
    public decimal Salary
    {
        get { return this.salary; }
        set { salary = value; }
    }
    
    public override string ToString()
    {
        return this.name + " " + this.department + " " + string.Format("{0:0.00}", this.salary);
    }
}
