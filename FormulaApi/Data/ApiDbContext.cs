using FormulaApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace FormulaApi.Data
{
    public class ApiDbContext : DbContext
    {
            public DbSet<Driver> Drivers { get; set; }
            public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        }
    }
