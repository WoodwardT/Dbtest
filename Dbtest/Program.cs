using Dbtest;
using Microsoft.EntityFrameworkCore;
using System.Linq;

DataContext context = new DataContext();

User user = new User { Name = "Tome" };


context.Users.Add(user);
context.SaveChanges();

var result = context.Users.First();

Console.WriteLine(result.Name);

