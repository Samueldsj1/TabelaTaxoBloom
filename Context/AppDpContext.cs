using Microsoft.EntityFrameworkCore;
using WebAppBloom.Models;

namespace WebAppBloom.Contexts;
public class AppDbContext:DbContext{
public DbSet<Competencia>Competencias=>Set<Competencia>();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=LAB-F08-01;DataBase=WebAppBloom;User Id=sa; Passoword=senai@123;TrustServerCerticate=True;");
    }
}