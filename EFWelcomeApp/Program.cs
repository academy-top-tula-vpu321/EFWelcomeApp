using EFWelcomeApp;

using (CompaniesDbContext context = new())
{
    //context.Database.EnsureDeleted();
    //context.Database.EnsureCreated();

    // CRUD - Create (Insert)
    //Employee sam = new() { Name = "Sammy", DateBirth = new DateTime(2001, 6, 17) };
    //Employee jim = new() { Name = "Jimmy", DateBirth = new DateTime(1997, 3, 2) };
    //context.Employees.Add(sam);
    //context.Employees.Add(jim);

    // CRUD - Update (Update)
    //int id = 3;
    //var employee = context.Employees.FirstOrDefault(e => e.Id == id);

    //if (employee is not null)
    //    employee.DateBirth = new DateTime(2001, 9, 25);

    // CRUD - Delete (Delete)
    //int id = 3;
    //var employee = context.Employees.FirstOrDefault(e => e.Id == id);

    //if (employee is not null)
    //    context.Employees.Remove(employee);

    //context.SaveChanges();
}

using (CompaniesDbContext context = new())
{

    // CRUD - Read (Select)
    //if (!context.Database.CanConnect()) return;

    var employees = context.Employees.ToList();
    //Console.WriteLine("Employees:");

    //foreach (var employee in employees)
    //    Console.WriteLine(employee);
}

