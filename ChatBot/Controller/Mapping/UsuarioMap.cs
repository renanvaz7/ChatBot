using ChatBot.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Controller.Mapping
{
    class UsuarioMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("cliente");
            builder.HasKey(c => c.IdCliente);
            builder.Property(c => c.Nome);
            builder.Property(c => c.Sobrenome);
            builder.Property(c => c.Email);
            builder.Property(c => c.CPF);
            builder.Property(c => c.Telefone);
        }
    }
}
