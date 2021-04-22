using MeuEstagio.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuEstagio.API.Infra.Data.Configuration
{
    public class VagasMapping : IEntityTypeConfiguration<Vaga>
    {
        public void Configure(EntityTypeBuilder<Vaga> builder)
        {
            builder
                .HasKey(v => v.Id);

            builder.ToTable("TB_VAGAS");

            builder
                .HasOne(v => v.Cidade)
                .WithMany()
                .HasForeignKey(fk => fk.IdCidade)
                .OnDelete(DeleteBehavior.Restrict);
              
        }
    }
}
