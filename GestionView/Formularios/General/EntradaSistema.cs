using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data.SqlClient;
using GestionServices.Generales;
using GestionData.Entities;
using Newtonsoft.Json;
using GestionData.Repositorios;
//using GestionData.Modelos;
//using System.Data.Entity;
//using System.Data.Objects;
//using System.Data.Objects.DataClasses;

namespace Promowork.Formularios.General
{
    public partial class EntradaSistema : Form
    {
        public EntradaSistema()
        {
            InitializeComponent();
        }

        bool ok = false;
        RepositorioUsuario repoUsuario = new RepositorioUsuario();
        RepositorioEmpresa repoEmpresa = new RepositorioEmpresa();
        UsuariosService usuariosService = new UsuariosService();
        EmpresasService empresasService = new EmpresasService();
        ConfiguracionUsuario configuracionUsuario = new ConfiguracionUsuario();
        ConfiguracionEmpresa configuracionEmpresa = new ConfiguracionEmpresa();
        List<GestionData.Modelos.Usuarios> usuarios;
        List<GestionData.Modelos.Empresas> empresasUsuario;
        GestionData.Modelos.Usuarios usuarioSeleccionado;

       private void Accesos_Load(object sender, EventArgs e)
        {
           usuarios = repoUsuario.GetAllActivos();
           usuariosBindingSource.DataSource = usuarios;
           if (VariablesGlobales.nIdUsuarioActual != 0)
           {
               cbUsuario.SelectedValue = VariablesGlobales.nIdUsuarioActual;
           }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int)cbUsuario.SelectedValue== VariablesGlobales.nIdUsuarioActual || usuariosService.ValidarClave(usuarioSeleccionado.IdUsuario, tbClave.Text))
            {

                if (cbEmpresa.SelectedIndex != -1)
                {
                    VariablesGlobales.nIdUsuarioActual = usuarioSeleccionado.IdUsuario;
                    VariablesGlobales.bEsAdmin = usuarioSeleccionado.AdminUsuario.Value;
                    VariablesGlobales.nIdEmpresaActual = (int)cbEmpresa.SelectedValue;
                    VariablesGlobales.nAnoActual = (int)tbAno.Value;
                    VariablesGlobales.nMesActual =  (byte)tbMes.Value;

                    configuracionUsuario.idUsuario = usuarioSeleccionado.IdUsuario;
                    configuracionUsuario.empresaSeleccionada = (int)cbEmpresa.SelectedValue;
                    configuracionUsuario.anoSeleccionado = (int)tbAno.Value;
                    configuracionUsuario.mesSeleccionado = (byte)tbMes.Value;

                    //VariablesGlobales.ConfiguracionUsuario = configuracionUsuario;

                    usuariosService.EstablecerUltimoUsuario(usuarioSeleccionado.IdUsuario);
                    repoUsuario.GuardarConfiguracionUsuario(configuracionUsuario);

                    //var configuracionEmpresaJson= empresasUsuario.FirstOrDefault(emp=> emp.IdEmpresa== (int)cbEmpresa.SelectedValue).ConfiguracionEmpresa;
                    //if (!string.IsNullOrWhiteSpace(configuracionEmpresaJson))
                    //{
                    //    configuracionEmpresa = JsonConvert.DeserializeObject<ConfiguracionEmpresa>(configuracionEmpresaJson);
                    //    VariablesGlobales.ConfiguracionEmpresa = configuracionEmpresa;
                    //}
                    
                    this.Close();
                   
                }
                else
                {
                    MessageBox.Show("Es obligatorio seleccionar la Empresa en la cual va a trabajar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta",this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

       private void cbUsuario_SelectedValueChanged(object sender, EventArgs e)
        {
            HabilitaDeshabilitaBtnAceptar();
            if (cbUsuario.SelectedIndex != -1)
            {
                
                usuarioSeleccionado = usuarios.FirstOrDefault(u => u.IdUsuario == (int)cbUsuario.SelectedValue);
                empresasUsuario = repoEmpresa.GetEmpresasUsuario(usuarioSeleccionado.IdUsuario);

                empresasBindingSource.DataSource = empresasUsuario;


                configuracionUsuario = JsonConvert.DeserializeObject<ConfiguracionUsuario>(usuarioSeleccionado.ConfiguracionUsuario);

                if (configuracionUsuario != null)
                {
                    cbEmpresa.SelectedValue = configuracionUsuario.empresaSeleccionada;
                    tbMes.Value = configuracionUsuario.mesSeleccionado.Value;
                    tbAno.Value = configuracionUsuario.anoSeleccionado.Value;
                }
                else
                {
                    cbEmpresa.SelectedIndex = 0;
                    tbMes.Value = DateTime.Today.Month;
                    tbAno.Value = DateTime.Today.Year;
                }

            }
           
        }

       private void HabilitaDeshabilitaBtnAceptar()
       {
           if (cbUsuario.SelectedIndex != -1 && cbEmpresa.SelectedIndex != -1 && (tbClave.Text.Trim().Length>=3 || (int)cbUsuario.SelectedValue== VariablesGlobales.nIdUsuarioActual))
           {
               btnAceptar.Enabled = true;
           }
           else
           {
               btnAceptar.Enabled = false;
           }
       }

       private void cbEmpresa_SelectedValueChanged(object sender, EventArgs e)
       {
           HabilitaDeshabilitaBtnAceptar();
       }

       private void tbClave_TextChanged(object sender, EventArgs e)
       {
           HabilitaDeshabilitaBtnAceptar();
       }



       
    }
}
