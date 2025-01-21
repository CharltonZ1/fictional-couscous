namespace PillarsofOOP;

internal class Employee
{
    // Field data.
    private string _empName;
    private int _empID;
    private int _empAge;
    private float _currPay;
    private string _empSSN;
    private EmployeePayTypeEnum _payType;
    private DateTime _dateHired;

    // Properties.
    public string Name
    {
        get => _empName;
        set
        {
            if (value.Length > 15)
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            else
                _empName = value;
        }
    }

    public int ID
    {
        set => _empID = value;
    }

    public float Pay
    {
        get => _currPay;
        set => _currPay = value;
    }

    public int Age
    {
        get => _empAge;
        set => _empAge = value;
    }

    public string SocialSecurityNumber
    {
        get => _empSSN;
        private set => _empSSN = value;
    }

    public EmployeePayTypeEnum PayType
    {
        get => _payType;
        set => _payType = value;
    }

    public DateTime DateHired
    {
        get => _dateHired;
        set => _dateHired = value;
    }

    // Constructors.

    public Employee() { }
    public Employee(string name, int id, float pay)
        : this(name, 0, id, pay, "", EmployeePayTypeEnum.Salaried) { }
    public Employee(string name, int age, int id, float pay, string ssn, EmployeePayTypeEnum payType)
    {
        Name = name;
        ID = id;
        Pay = pay;
        Age = age;
        SocialSecurityNumber = ssn;
        PayType = payType;
    }

    // Methods.

    public void GiveBonus(float amount)
    {
        Pay = this switch
        {
            { Age: >= 18, PayType: EmployeePayTypeEnum.Commission,
                DateHired.Year: > 2020
            } => Pay += amount * 1.10f,
            {
                Age: >= 18, PayType: EmployeePayTypeEnum.Hourly,
                DateHired.Year: > 2020
            } => Pay += amount * 1.05f,
            {
                Age: >= 18, PayType: EmployeePayTypeEnum.Salaried,
                DateHired.Year: > 2020
            } => Pay += amount * 1.03f,
            {
                Age: >= 18, PayType: EmployeePayTypeEnum.Commission,
                DateHired.Year: < 2021
            } => Pay += amount * 1.05f,
            {
                Age: >= 18, PayType: EmployeePayTypeEnum.Hourly,
                DateHired.Year: < 2021
            } => Pay += amount * 1.03f,
            {
                Age: >= 18, PayType: EmployeePayTypeEnum.Salaried,
                DateHired.Year: < 2021
            } => Pay += amount * 1.02f,
            _ => Pay


        };
    }

    public void DisplayStats()
    {
        Console.WriteLine("Name: {0}", Name);
        //Console.WriteLine("ID: {0}", ID);
        Console.WriteLine("Age: {0}", Age);
        Console.WriteLine("Pay: {0}", Pay);
    }
}
