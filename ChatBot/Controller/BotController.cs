using ChatBot.Controller.Config;
using ChatBot.Controller.Interface;
using ChatBot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Controller
{
    class BotController : IBot, IDisposable
    {
        private ChatBotContext context;

        public BotController()
        {
            this.context = new ChatBotContext();
        }

        public void Adicionar(Cliente c)
        {
            context.Clientes.Add(c);
            context.SaveChanges();
        }

        public IList<Cliente> AllClientes()
        {
            return context.Clientes.ToList();
        }

        public Cliente Buscar(int id)
        {
            return context.Clientes.Find(id);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public void Editar(Cliente c)
        {
            var original = this.Buscar(c.IdCliente);
            this.context.Entry(original).CurrentValues.SetValues(c);
            context.SaveChanges();
        }

        public void Remover(Cliente c)
        {
            var original = this.Buscar(c.IdCliente);
            this.context.Remove(original);
            context.SaveChanges();
        }
    }
}
