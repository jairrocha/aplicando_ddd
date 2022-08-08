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
    public class CardapioMap : MapBase<Cardapio>
    {
        public override void Configure(EntityTypeBuilder<Cardapio> builder)
        {
            base.Configure(builder);

            builder
                .ToTable("TB_CARDAPIO");

            builder.Property(c => c.Id).HasColumnName("ID_CARDAPIO");
            builder.Property(c => c.CodDia).IsRequired().HasColumnName("COD_DIA");
            builder.Property(c => c.Dia).HasColumnName("DESC_DIA_SEMANA").HasMaxLength(10);

      

        }

    }
}
