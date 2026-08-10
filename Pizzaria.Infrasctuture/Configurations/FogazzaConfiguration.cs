using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria.Infrasctuture.Configurations
{
    public class FogazzaConfiguration : IEntityTypeConfiguration<Fogazza>
    {
        public void Configure(EntityTypeBuilder<Fogazza> builder)
        {
            // Define a chave primária
            builder.HasKey(g => g.Id);

            // Configurações dos campos
            builder.Property(g => g.Name)
                .IsRequired()           // Campo obrigatório
                .HasMaxLength(200);     // Máximo de 200 caracteres

            builder.Property(g => g.Description)
                .HasMaxLength(2000);    // Máximo de 2000 caracteres

            builder.Property(g => g.CoverImageUrl)
                .HasMaxLength(500);

            // =====================================================================
            //  CONCEITO: Configuração de Relacionamento (Fluent API)
            // Um Game pertence a UMA Category (relação N:1).
            // Uma Category possui MUITOS Games (relação 1:N).
            // HasOne  WithMany  HasForeignKey
            // =====================================================================
            builder.HasOne(g => g.Category)       // Um Game tem UMA Category
                .WithMany(c => c.Fogazzas)            // Uma Category tem MUITOS Games
                .HasForeignKey(g => g.CategoryId)  // A FK é CategoryId
                .OnDelete(DeleteBehavior.Restrict); // Não permite deletar categoria com games
        }
    }
}
