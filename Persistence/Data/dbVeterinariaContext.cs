using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Persistence.Entities;

namespace Persistence.Data;

public partial class dbVeterinariaContext : DbContext
{
    public dbVeterinariaContext(DbContextOptions<dbVeterinariaContext> options)
        : base(options)
    {
    }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Breed> Breeds { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Clientaddress> Clientaddresses { get; set; }
    public DbSet<Clientphone> Clientphones { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Refreshtoken> Refreshtokens { get; set; }
    public DbSet<Rol> Rols { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<User> Users { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
