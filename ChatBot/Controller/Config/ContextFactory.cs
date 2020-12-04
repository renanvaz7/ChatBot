using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Controller.Config
{
    class ContextFactory : IDesignTimeDbContextFactory<ChatBotContext>
    {
        public ChatBotContext CreateDbContext(string[] args)
        {
            var connectString = "Server=localhost;Port=3306;Database=chatbot;Uid=root;Pwd=root";
            var optionsBuilder = new DbContextOptionsBuilder<ChatBotContext>();
            optionsBuilder.UseMySql(connectString);
            return new ChatBotContext(optionsBuilder.Options);
        }
    }
}
