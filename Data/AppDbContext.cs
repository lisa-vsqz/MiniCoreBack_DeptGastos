using Microsoft.EntityFrameworkCore;
using MiniCore_Backend.Models;

namespace MiniCore_Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
    }
}
