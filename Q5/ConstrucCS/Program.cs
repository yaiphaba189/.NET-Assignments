using System;

namespace ConstrucCS
{
    class Employee
    {
    
        private int _empId;
        private string _name;

        public int EmpId
        {
            get => _empId;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Employee ID must be positive.");
                _empId = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");
                _name = value;
            }
        }

      
        public Employee()
        {
            EmpId = 101;
            Name = "Jain";
            Console.WriteLine("The default constructor is called.");
            DisplayEmployeeInfo();
        }


        public Employee(int empId, string name)
        {
            EmpId = empId;
            Name = name;
            Console.WriteLine("\nThe parameterized constructor is called.");
            DisplayEmployeeInfo();
        }

        private void DisplayEmployeeInfo()
        {
            Console.WriteLine("Employee ID: {0}, Name: {1}", EmpId, Name);
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee(202, "Jain");
            Console.ReadKey();
        }
    }
}
