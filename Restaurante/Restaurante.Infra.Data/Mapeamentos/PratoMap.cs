using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurante.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Infra.Data.Mapeamentos
{
    public class PratoMap : MapBase<Prato>
    {
        public override void Configure(EntityTypeBuilder<Prato> builder)
        {
            base.Configure(builder);
            
            builder
                .ToTable("TB_PRATO");

            builder
                .Property(p => p.Id)
                .IsRequired()
                .HasColumnName("ID_PRATO");
            
            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnName("NOME")
                .HasMaxLength(100);
            
            builder
                .Property(p => p.Preco)
                .IsRequired()
                .HasColumnName("PRECO")
                .HasColumnType("NUMERIC(15,2)");
        }
    }
}
