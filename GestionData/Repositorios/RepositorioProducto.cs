using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData.Modelos;
using GestionData.Entities;

namespace GestionData.Repositorios
{
    public class RepositorioProducto
    {
        DefinicionesDataModel contextoDefiniciones = new DefinicionesDataModel();
  
        public Productos GertOne(int idProducto)
        {
            var producto = contextoDefiniciones.Productos.FirstOrDefault(p => p.IdProducto == idProducto);
            return producto;
        }

       
    }
}
