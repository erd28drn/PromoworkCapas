using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Promowork
{
    public static class Mensajes
    {
        public static DialogResult Error(string mensaje)
        {
            return MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Mostrará el mensaje: mensaje+" ¿Desea guardar los cambios realizados?"
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public static DialogResult PreguntaGuardarDatos(string mensaje)
        {
            return MessageBox.Show(mensaje+" ¿Desea guardar los cambios realizados?", "Guardar Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
