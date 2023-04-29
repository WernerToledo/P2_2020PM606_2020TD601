using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace P2_2020PM606_2020TD601.Models
{
    public class covid2023DbContext: DbContext
    {
        public covid2023DbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<departamentos> departamentos { get; set; } 
        public DbSet<generos> generos { get; set; } 
        public DbSet<casosReportados> casosReportados { get; set; } 


    }
}
