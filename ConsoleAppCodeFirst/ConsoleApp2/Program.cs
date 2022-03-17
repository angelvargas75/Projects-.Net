using ConsoleApp2;
using System.Data.Entity.Migrations;

class Program
{
    static void Main(string[] args)
    {
        Get();
    }

    
    //Metodos CRUD
    private static void Get()
    {
        using (var context = new EmployeeDbContext())
        {
            var res = context.Employees.FirstOrDefault(x => x.Id == 5);

            Console.WriteLine("Employee name: " + res.Name);
            Console.ReadKey();
        }
    }

    private static void Insert()
    {
        using (var context = new EmployeeDbContext())
        {
            var res = new Employee
            {
                Name = "Margaret",
                Address = "4110 Old Redmond Rd.",
                Designation = "Lead 5",
                JoingDate = DateTime.Now
            };

            context.Employees.Add(res);
            context.SaveChanges();
        }
    }

    private static void Update()
    {
        using (var context = new EmployeeDbContext())
        {
            var res = new Employee
            {
                Id = 3,
                Name = "Laura",
                Address = "4726 - 11th Ave. N.E.",
                Designation = "Lead 3",
                JoingDate = DateTime.Now,
            };

            context.Employees.AddOrUpdate(res);
            context.SaveChanges();
        }
    }

    private static void Delete()
    {
        using (var context = new EmployeeDbContext())
        {
            var res = context.Employees.FirstOrDefault(x => x.Id == 1);
            context.Employees.Remove(res);
            context.SaveChanges();
        }
    }

    private static void CreateDb()
    {
        using (var context = new EmployeeDbContext())
        {
            var res = new Employee
            {
                Name = "Jhon",
                Address = "908 W. Capital Way",
                Designation = "Lead 1",
                JoingDate = DateTime.Now
            };

            context.Employees.Add(res);
            context.SaveChanges();
        }
    }
}