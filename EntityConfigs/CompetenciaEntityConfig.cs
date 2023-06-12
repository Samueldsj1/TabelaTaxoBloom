using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppBloom.Models;
namespace WebAppBloom.EntityConfigs;
public class CompetenciaEntityConfig:IEntityTypeConfiguration<Competencia>{
    //flent API
    // interface é o mais alto nivel de abstração 
    // Na orientação a objeto ela é a ponta do iceberg
    // funciona como um contrato com as classes
    // obriga geralmente a implementação.
    public void Configure(EntityTypeBuilder<Competencia>builder){
        builder.ToTable("Competencia");
        builder.HasKey(c=>c.Id);
        builder.Property(c=>c.Id).HasColumnName("Id");

        builder.Property(c=>c.ColunaBloom).HasColumnName("ColunaBloom").HasColumnType("varchar(60)").IsRequired();
        builder.Property(c=>c.LinhaBloom).HasColumnName("LinhaBloom").HasColumnType("varchar(60)").IsRequired();
    }
    

}