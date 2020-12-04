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
    class LoginMap : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.ToTable("login");
            builder.HasKey(l => l.IdLogin);
            builder.Property(l => l.NomeUsuario);
            builder.Property(l => l.Senha);
        }
    }
}
