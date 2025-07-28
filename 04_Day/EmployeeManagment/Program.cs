// ----------------------------------------------------------------------------------------
// ---------------------------------------------------------------------------------------
//Create an Employee Class with following specification:
//Employee name as String 2.Basic Salary ,HRA, DA, TAX, Gross Pay and Net Salary as decimal.
//Calculate the HRA(15 % of Basic salary), DA(10 % of Basic Salary), GrossPay(Basic Salary + HRA + DA), TAX(8 % of Gross Pay) and Net pay(Gross Pay - Tax)
//4.A constructor to allow to define the Employee Name and Basic Salary
//A method CalculateNetpay to calculate the HRA, DA, TAX, Gross and Net Pay values using critria mentioned in Point 4.
//A method Display to display salary structure.
// ---------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------
class Program
{
    class Employee
    {
        private string _empName;
        private decimal _basicSalary;
        private decimal _hra;
        private decimal _da;
        private decimal _tax;
        private decimal _grossPay;
        private decimal _netPay;

        public string EmployeeName
        {
            get { return _empName; }
            set { _empName = value; }
        }
        public decimal BasicSalary
        {
            get { return _basicSalary; }
            set { _basicSalary = value; }
        }
        public decimal HRA
        {
            get { return _hra; }
            set { _hra = value; }
        }

        public decimal DA
        {
            get { return _da; }
            set { _da = value; }
        }
        public decimal Tax
        {
            get { return _tax; }    
            set { _tax = value; }
        }
        public decimal GrossPay
        {
            get { return _grossPay; }
            set { _grossPay = value; }
        }
        public decimal NetPay
        {
            get { return _netPay; }
            set { _netPay = value; }
        }



        public Employee(string empName, decimal basicSalary)
        {
            this.EmployeeName = empName;
            this.BasicSalary = basicSalary;

            _hra = 0;
            _da = 0;
            _tax = 0;
            _grossPay = 0;
            _netPay = 0;

        }

        public void CalculateNetPay()
        {
            HRA = BasicSalary * 0.15m;

            DA = BasicSalary * 0.10m;

            GrossPay =  BasicSalary + HRA + DA;

            Tax = GrossPay * 0.08m;

            NetPay = GrossPay - Tax;
        }

        public void DisplaySalaryStructure()
        {
            Console.WriteLine("--- Employee Salary ---");
            Console.WriteLine($"Employee Name: {EmployeeName}");
            Console.WriteLine($"Basic Salary: {BasicSalary:C}");
            Console.WriteLine($"HRA (15% of Basic Salary): {HRA:C}");
            Console.WriteLine($"DA (10% of Basic Salary): {DA:C}");
            Console.WriteLine($"Gross Pay (Basic Salary + HRA + DA): {GrossPay:C}");
            Console.WriteLine($"Net pay(Gross Pay - Tax): {GrossPay:C}");
            Console.WriteLine("---------------------------");
        }

        
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("------ Employee ------");
        Console.WriteLine("Enter Your name: ");
        string name ="";
        int salary = 0;
        bool isValidName = false;
        while (!isValidName)
        {
            name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid Name!");
            }
            else
            {
                isValidName = true;
            }
        }
        bool isValidSalary = false;
        while (!isValidSalary)
        {
            
            Console.WriteLine("Enter Your salary (e.g. 200000 or 240000 etc.): ");
            if(int.TryParse(Console.ReadLine(), out salary))
            {
                isValidSalary = true;
            }
            else
            {

                Console.WriteLine("Invalid Salary!");
            }
        }

        Employee emp1 = new("Prashant Kumar", 2400000);

        emp1.CalculateNetPay();

        emp1.DisplaySalaryStructure();

        Employee emp2 = new(name, salary);

        emp2.CalculateNetPay();
        emp2.DisplaySalaryStructure();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}