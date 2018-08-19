using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using Promowork.Formularios.Definiciones;
using Promowork.Formularios.General;
using Promowork.Formularios.Reportes.Parametros;
using Promowork.Formularios.Reportes.Viewer;
using Promowork.Formularios.Operaciones;
using GestionData;
using GestionData.Enumeradores;
using GestionData.Entities;
using GestionData.Repositorios;

namespace Promowork
{
    class VariablesGlobales
    {
        public static int nIdUsuarioActual = 0;
        public static bool bEsAdmin = false;
        public static int nIdEmpresaActual = 0;
        public static int nAnoActual = 0;
        public static byte nMesActual = 0;
        //public static ConfiguracionUsuario ConfiguracionUsuario = new ConfiguracionUsuario();
        //public static ConfiguracionEmpresa ConfiguracionEmpresa = new ConfiguracionEmpresa();
    }
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            Thread.CurrentThread.CurrentUICulture = new  CultureInfo("es-ES");

            try
            {
                Application.Run(new EntradaSistema ());
                if (VariablesGlobales.nIdEmpresaActual != 0 && VariablesGlobales.nIdUsuarioActual != 0 && VariablesGlobales.nAnoActual != 0 && VariablesGlobales.nMesActual != 0)
                {
                    Application.Run(new frmParticipantesDocumentos ());

                    //RepositorioUsuario repoUsuario = new RepositorioUsuario();
                    //repoUsuario.GuardarConfiguracionUsuario(VariablesGlobales.ConfiguracionUsuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errores sin Gestionar");

            }
        }
    }
}
