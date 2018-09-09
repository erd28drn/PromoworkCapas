using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionData.Modelos;
using GestionData.Repositorios;
using System.IO;
using System.Collections;
using GestionData.Entities;

namespace Promowork.Formularios.General
{
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        RepositorioNota repoNota = new RepositorioNota();
        RepositorioUsuario repoUsuario = new RepositorioUsuario();
        List<Notas> notas;
        List<GestionData.Modelos.Usuarios> usuarios;
        

        private void frmNotas_Load(object sender, EventArgs e)
        {
            notas = repoNota.GetNotasUsuario(VariablesGlobales.nIdUsuarioActual);
            notasBindingSource.DataSource = notas;

            usuarios = repoUsuario.GetAll().OrderBy(u=> u.NomUsuario).ToList();
            usuariosBindingSource.DataSource = usuarios;
        }

        private void notasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            GuardarCambios();
        }

        private void GuardarCambios()
        {
            this.Validate();
            notasBindingSource.EndEdit();
            notas = (List<Notas>)notasBindingSource.DataSource;
            RespuestasServicios respuesta = repoNota.InsertUpdateDelete(notas, VariablesGlobales.nIdUsuarioActual);
            if (respuesta.ResultadoOk == false)
            {
                Mensajes.Error(respuesta.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void frmNotas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            notasBindingSource.EndEdit();
            
            if (repoNota.TieneCambiosSinGuardar())
            {
                if (Mensajes.PreguntaGuardarDatos("Ha modificado Notas.") == System.Windows.Forms.DialogResult.Yes)
                {
                    GuardarCambios();
                }
            }
        }

        private void btImportTxt_Click(object sender, EventArgs e)
        {
            if (ofTextoNota.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var ficherosSeleccionados = ofTextoNota.FileNames.ToList();
                foreach (string fichero in ficherosSeleccionados)
                {
                    //FileStream stream = File.Open(fichero, FileMode.Open, FileAccess.Read, FileShare.Read);
                    //StreamReader reader = new StreamReader(stream);
                    //String texto = reader.ReadToEnd();

                    string descripcionNota= File.ReadAllText(fichero);

                    FileInfo fileInfo = new FileInfo(fichero);
                    string nombreNota= fileInfo.Name.Substring(0,fileInfo.Name.LastIndexOf(".")).ToUpper();
                    CreaNota(nombreNota, descripcionNota);
                }
                GuardarCambios();
            }
                       
        }

        private Notas CreaNota(string nombreNota, string descripcionNota)
        {
            Notas nuevaNota = new Notas();
            nuevaNota.NombreNota = nombreNota;
            nuevaNota.DescripcionNota = descripcionNota;
            nuevaNota.IdUsuarioPertenece = VariablesGlobales.nIdUsuarioActual;

            notasBindingSource.Add(nuevaNota);

            return nuevaNota;
        }

    }
}
