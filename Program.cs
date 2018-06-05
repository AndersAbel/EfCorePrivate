using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new DbContextOptionsBuilder<MyDbContext>()
            .UseInMemoryDatabase("test")
            .Options;

            var ctx = new MyDbContext(options);

            ctx.MyEntities.Add(new MyEntity("Name"));

            ctx.SaveChanges();

            ctx = new MyDbContext(options);

            var e = ctx.MyEntities.Single();

            Console.WriteLine($"Found entity {e.Id} with name \"{e.Name}\"");

            e.Rename("New Name");

            ctx.SaveChanges();

            ctx = new MyDbContext(options);

            e = ctx.MyEntities.Single();

            Console.WriteLine($"Found entity {e.Id} with name \"{e.Name}\"");
        }
    }
}
