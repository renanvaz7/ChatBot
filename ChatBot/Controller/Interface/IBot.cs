using ChatBot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Controller.Interface
{
    interface IBot
    {
        void Adicionar(Cliente c);
        void Editar(Cliente c);
        void Remover(Cliente c);
        Cliente Buscar(int id);
        IList<Cliente> AllClientes();
    }
}
