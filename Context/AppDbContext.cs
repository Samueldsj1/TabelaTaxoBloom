using Microsoft.EntityFrameworkCore;
using WebAppBloom.Models;
using WebAppBloom.EntityConfigs;

namespace WebAppBloom.Contexts;
public class AppDbContext:DbContext{
public DbSet<Competencia>Competencias=>Set<Competencia>();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //configurar conexão 
       optionsBuilder.UseSqlServer("Server=LAB-F08-01;Database=WebAppBloom;User Id=sa;Password=senai@123;TrustServerCertificate=True;");
    }

    //aplica configuração da tabela
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CompetenciaEntityConfig());
    }
}