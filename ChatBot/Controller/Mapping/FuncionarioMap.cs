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
    class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("funcionario");
            builder.HasKey(f => f.IdFuncionario);
            builder.Property(f => f.Nome);
            builder.Property(f => f.Email);
            builder.Property(f => f.CPF);
            builder.Property(f => f.Telefone);
        }
    }
}
