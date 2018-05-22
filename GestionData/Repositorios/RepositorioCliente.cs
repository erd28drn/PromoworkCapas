using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData.Modelos;
using GestionData.Entities;

namespace GestionData.Repositorios
{
    public class RepositorioCliente
    {
        DefinicionesDataModel contextoDefiniciones = new DefinicionesDataModel();

        public bool UpdateEmailCliente(int idCliente, string email)
        {
            var cliente = contextoDefiniciones.Clientes.FirstOrDefault(c => c.IdCliente == idCliente);
            cliente.EmailCliente = email;
            contextoDefiniciones.SaveChanges();
            return true;
        }
    }
}
