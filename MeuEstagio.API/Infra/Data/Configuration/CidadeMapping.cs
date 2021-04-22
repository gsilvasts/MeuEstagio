using MeuEstagio.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuEstagio.API.Infra.Data.Configuration
{
    public class CidadeMapping : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder
                .HasKey(v => v.Id);

            builder.ToTable("TB_CIDADES");

        }
    }
}
