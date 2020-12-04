using ChatBot.Controller.Mapping;
using ChatBot.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Controller.Config
{
    class ChatBotContext : DbContext
    {
        public ChatBotContext(){}

        public ChatBotContext(DbContextOptions<ChatBotContext> options) : base(options){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=chatbot;Uid=root;Pwd=root");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>(new UsuarioMap().Configure);
            modelBuilder.Entity<Funcionario>(new FuncionarioMap().Configure);
            modelBuilder.Entity<Login>(new LoginMap().Configure);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

        public DbSet<Login> Logins { get; set; }
    }
}
