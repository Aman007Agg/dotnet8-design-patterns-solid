using LinQ;

class program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 50000, Age = 30 },
            new Employee { Id = 2, Name = "Bob", Department = "IT", Salary = 60000, Age = 25 },
            new Employee { Id = 3, Name = "Charlie", Department = "Finance", Salary = 55000, Age = 35 },
            new Employee { Id = 4, Name = "David", Department = "IT", Salary = 70000, Age = 28 },
            new Employee { Id = 5, Name = "Eve", Department = "HR", Salary = 52000, Age = 32 }
        };


        //var result = employees.Where(emp => emp.Department == "IT" && emp.Salary > 55000)
        //                      .Select(emp => new { emp.Name, emp.Salary });

        var result = employees.Where(emp => emp.Department == "IT").ToList();
        foreach (var emp in result)
        {
            Console.WriteLine(emp.Name);
        }

        var result1 = employees.Where(emp => emp.Department == "IT").Select(emp => emp.Name);
        foreach (var name in result1)
        {
            Console.WriteLine($"Result-1:{name}");
        }
        //Console.ReadLine();

        var employee = employees.FirstOrDefault(emp => emp.Department == "Marketing");
        //Console.WriteLine(employee.Name);

        var employee2 = from emp in employees
                        where emp.Department == "IT"
                        select emp.Name;

        foreach (var empName in employee2)
        {
            Console.WriteLine($"Employee names in IT department:{empName}");
        }
        

    }
}