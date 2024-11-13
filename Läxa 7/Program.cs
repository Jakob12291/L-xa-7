using System;
using System.Collections.Generic;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public decimal Salary { get; set; }

    // Konstruktor för att skapa en Employee
    public Employee(int id, string name, string gender, decimal salary)
    {
        Id = id;
        Name = name;
        Gender = gender;
        Salary = salary;
    }

    // Skriv ut information om en anställd
    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Gender: {Gender}, Salary: {Salary:C}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Skapa fem olika Employee-objekt
        Employee e1 = new Employee(1, "Leonora", "Female", 50000);
        Employee e2 = new Employee(2, "Reidar", "Male", 55000);
        Employee e3 = new Employee(3, "Jakob", "Male", 60000);
        Employee e4 = new Employee(4, "Romella", "Female", 45000);
        Employee e5 = new Employee(5, "Simon", "Male", 65000);

        // Del 1 – Stack
        // Skapa en Stack och lägg till objekten med Push()
        Stack<Employee> employeeStack = new Stack<Employee>();
        employeeStack.Push(e1);
        employeeStack.Push(e2);
        employeeStack.Push(e3);
        employeeStack.Push(e4);
        employeeStack.Push(e5);

        // Skriv ut alla objekt i stacken
        Console.WriteLine("=== Stack efter Push ===");
        foreach (var employee in employeeStack)
        {
            Console.WriteLine(employee);
            Console.WriteLine($"Objects left in stack: {employeeStack.Count}");
        }

        // Hämta alla objekt med Pop-metoden
        Console.WriteLine("\n=== Stack efter Pop ===");
        while (employeeStack.Count > 0)
        {
            Employee poppedEmployee = employeeStack.Pop();
            Console.WriteLine(poppedEmployee);
            Console.WriteLine($"Objects left in stack: {employeeStack.Count}");
        }

        // Lägg tillbaka alla objekt i stacken
        employeeStack.Push(e1);
        employeeStack.Push(e2);
        employeeStack.Push(e3);
        employeeStack.Push(e4);
        employeeStack.Push(e5);

        // Hämta objekt med Peek-metoden
        Console.WriteLine("\n=== Peek på de två översta objekten ===");
        Employee peekedEmployee1 = employeeStack.Peek();
        Console.WriteLine(peekedEmployee1);
        Console.WriteLine($"Objects left in stack: {employeeStack.Count}");

        // För att få två objekt, måste vi Pop det första objektet först
        employeeStack.Pop();
        Employee peekedEmployee2 = employeeStack.Peek();
        Console.WriteLine(peekedEmployee2);
        Console.WriteLine($"Objects left in stack: {employeeStack.Count}");

        // Kolla om objekt nummer 3 finns i stacken
        bool exists = employeeStack.Contains(e3);
        Console.WriteLine($"\nDoes object with ID 3 exist in the stack? {exists}");

        // Del 2 – List
        // Skapa en lista och lägg till fem objekt av klassen Employee
        List<Employee> employeeList = new List<Employee> { e1, e2, e3, e4, e5 };

        // Kolla om ett specifikt objekt finns i listan
        Employee employee2 = new Employee(2, "Bob", "Male", 55000);
        if (employeeList.Contains(employee2))
        {
            Console.WriteLine("\nEmployee2 object exists in the list");
        }
        else
        {
            Console.WriteLine("\nEmployee2 object does not exist in the list");
        }

        // Använd Find-metoden för att hitta första objektet med Gender = "Male"
        Employee firstMale = employeeList.Find(e => e.Gender == "Male");
        Console.WriteLine($"\nFirst male employee: {firstMale}");

        // Använd FindAll-metoden för att hitta alla objekt med Gender = "Male"
        List<Employee> allMales = employeeList.FindAll(e => e.Gender == "Male");
        Console.WriteLine("\nAll male employees:");
        foreach (var male in allMales)
        {
            Console.WriteLine(male);
        }
    }
}