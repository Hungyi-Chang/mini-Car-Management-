using System;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {   
        }

        public DbSet<Value> Values { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
            .HasData(
                new Value {Id = 1, VehicleType = "Car", Make = "1998", Model = "Mercedes", Engine = "test", Doors= "4", wheel = "5", bodyType = "hatchback"},
                new Value { Id = 2, VehicleType = "Car", Make = "1998", Model = "Mercedes", Engine = "test", Doors = "4", wheel = "5", bodyType = "hatchback" }
            );
        }
    }

    
}
