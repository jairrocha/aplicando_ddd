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
    public class PratoDiaMap : MapBase<PratoDia>
    {
        public override void Configure(EntityTypeBuilder<PratoDia> builder)
        {
            base.Configure(builder);

            builder
                .ToTable("TB_PRATO_DIA");

            builder
                .HasOne(p => p.Prato)
                .WithMany(ds => ds.PratosDia)
                .HasForeignKey(p => p.PratoId);


            builder
                .HasOne(c => c.Cardapio)
                .WithMany(ds => ds.PratosDia)
                .HasForeignKey(c => c.CardapioId)
                .OnDelete(DeleteBehavior.Restrict);
                

            builder
                .HasIndex(d => new { d.CardapioId, d.PratoId }).IsUnique(true);
                

            builder.Property(d => d.Id).IsRequired().HasColumnName("ID_PRATO_DIA");
            builder.Property(d => d.CardapioId).IsRequired().HasColumnName("ID_CARDAPIO");
            builder.Property(d => d.PratoId).IsRequired().HasColumnName("ID_PRATO");
            
        }
    }
}
