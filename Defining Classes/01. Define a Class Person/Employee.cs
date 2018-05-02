class Employee
{
    string name;
    decimal salary;
    string position;
    string department;
    string email;
    int age;

    public string Name
    {
        get { return this.name; }
        set { name = value; }
    }

    public decimal Salary
    {
        get { return this.salary; }
        set { salary = value; }
    }

    public string Position
    {
        get { return this.position; }
        set { position = value; }
    }

    public string Department
    {
        get { return this.department; }
        set { department = value; }
    }

    public string Email
    {
        get { return this.email; }
        set { email = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { age = value; }
    }

    public Employee()
    {

    }

    public Employee(string name, decimal salary, string position, string department):this()
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = "n/a";
        this.age = -1;
    }

    public Employee(string name, decimal salary, string position, string department, string email)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = email;
        this.age = -1;
    }

    public Employee(string name, decimal salary, string position, string department, int age)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.age = age;
        this.email = "n/a";
    }

    public Employee(string name, decimal salary, string position, string department, string email, int age)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = email;
        this.age = age;
    }
}

