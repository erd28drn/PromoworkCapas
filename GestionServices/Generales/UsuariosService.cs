using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionData.Repositorios;
using System.Security.Cryptography;

namespace GestionServices.Generales
{
    public class UsuariosService
    {
        RepositorioUsuario repoUsuario= new RepositorioUsuario();
        public bool ValidarClave(int? idUsuario, string clave)
        {
            bool result = false;
            if (idUsuario != null)
            {
                byte[] tmpClave = ASCIIEncoding.ASCII.GetBytes(clave);
                byte[] tmpClaveHash = new MD5CryptoServiceProvider().ComputeHash(tmpClave);
                result= repoUsuario.GetOne(idUsuario.Value).ClaveUsuario == Convert.ToBase64String(tmpClaveHash);
            }
            return result;
        }

        public bool EstablecerUltimoUsuario(int? idUsuario)
        {
            bool result = false;
            if (idUsuario != null)
            {
                repoUsuario.SetAllUltimoUsuarioFalse();
                repoUsuario.SetUltimoUsuario(idUsuario.Value);
                result= true;
            }
            return result;
        }
    }
}
