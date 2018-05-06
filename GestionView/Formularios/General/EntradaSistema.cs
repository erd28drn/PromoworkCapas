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

namespace Promowork.Formularios.General
{
    public partial class EntradaSistema : Form
    {
        public EntradaSistema()
        {
            InitializeComponent();
        }
        bool ok = false;
       private void Accesos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promowork_dataDataSet.Empresas' table. You can move, or remove it, as needed.
            this.empresasTableAdapter.Fill(this.promowork_dataDataSet.Empresas);
         
            this.usuariosTableAdapter.FillByActivo(this.promowork_dataDataSet.Usuarios);
            this.accesosUsuariosEmpresasTableAdapter.FillByUsuario(promowork_dataDataSet.AccesosUsuariosEmpresas, Convert.ToInt32(cbUsuario.SelectedValue));

            DataRowView usuario = (DataRowView)usuariosBindingSource.Current;
            cbEmpresa.SelectedValue = (int)usuario["UltEmpresa"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sClave=textBox1.Text;
            byte[] tmpClave=ASCIIEncoding.ASCII.GetBytes(sClave);
            byte[] tmpClaveHash = new MD5CryptoServiceProvider().ComputeHash(tmpClave);

           // MessageBox.Show(Convert.ToString(promowork_dataDataSet.Tables["Usuarios"].Rows[Convert.ToInt32(comboBox1.SelectedIndex)]["ClaveUsuario"]));

            if (Convert.ToString(promowork_dataDataSet.Tables["Usuarios"].Rows[Convert.ToInt32(cbUsuario.SelectedIndex)]["ClaveUsuario"]) == Convert.ToBase64String(tmpClaveHash) || VariablesGlobales.nIdUsuarioActual == Convert.ToInt32(cbUsuario.SelectedValue))
            {
                //MessageBox.Show("Clave Correcta");
                

                try
                {

                    DateTime FechaTest = new DateTime(Convert.ToInt32(anoEmpresaTextBox.Text), Convert.ToInt32(mesEmpresaTextBox.Text), 1);

                    ok = true;
                }
                catch
                {
                    ok = false;
                    MessageBox.Show("Mes o Año Incorrecto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                if (cbEmpresa.SelectedIndex != -1)
                {
                    var usuarioSelecionado = (DataRowView)usuariosBindingSource.Current;
                    VariablesGlobales.nIdUsuarioActual = Convert.ToInt32(cbUsuario.SelectedValue);
                    VariablesGlobales.bEsAdmin = Convert.ToBoolean(usuarioSelecionado["AdminUsuario"]);
                    VariablesGlobales.nIdEmpresaActual = Convert.ToInt32(cbEmpresa.SelectedValue);
                    VariablesGlobales.nAnoActual = Convert.ToInt32(anoEmpresaTextBox.Text);
                    VariablesGlobales.nMesActual = Convert.ToByte(mesEmpresaTextBox.Text);

                    VariablesGlobales.ConfiguracionUsuario.idUsuario = Convert.ToInt32(cbUsuario.SelectedValue);
                    VariablesGlobales.ConfiguracionUsuario.empresaSeleccionada = Convert.ToInt32(cbEmpresa.SelectedValue);
                    VariablesGlobales.ConfiguracionUsuario.anoSeleccionado = Convert.ToInt32(anoEmpresaTextBox.Text);
                    VariablesGlobales.ConfiguracionUsuario.mesSeleccionado = Convert.ToByte(mesEmpresaTextBox.Text);

                    //usuarioSelecionado["ConfiguracionUsuario"] = JsonConvert.SerializeObject(VariablesGlobales.ConfiguracionUsuario);

                    for (int i = 0; i < promowork_dataDataSet.Usuarios.Count; i++)
                    {

                        promowork_dataDataSet.Tables["Usuarios"].Rows[i]["UltimoUsuario"] = 0;
                    }

                    promowork_dataDataSet.Tables["Usuarios"].Rows[Convert.ToInt32(cbUsuario.SelectedIndex)]["UltimoUsuario"] = 1;

                    for (int i = 0; i < promowork_dataDataSet.Empresas.Count; i++)
                    {

                        promowork_dataDataSet.Tables["Empresas"].Rows[i]["UltimaEmpresa"] = 0;
                    }
                    promowork_dataDataSet.Tables["Empresas"].Rows[Convert.ToInt32(cbEmpresa.SelectedIndex)]["UltimaEmpresa"] = 1;
                    promowork_dataDataSet.Tables["Empresas"].Rows[Convert.ToInt32(cbEmpresa.SelectedIndex)]["AnoEmpresa"] = Convert.ToInt32(anoEmpresaTextBox.Text);
                    promowork_dataDataSet.Tables["Empresas"].Rows[Convert.ToInt32(cbEmpresa.SelectedIndex)]["MesEmpresa"] = Convert.ToInt32(mesEmpresaTextBox.Text);

                }
                else
                {
                    ok = false;
                    MessageBox.Show("Tiene que seleccionar la Empresa en la cual va a trabajar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta",this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (ok == true)
            {
                try
                {
                    this.Validate();
                    this.usuariosBindingSource.EndEdit();
                    usuariosTableAdapter.Update(promowork_dataDataSet.Usuarios);

                    this.empresasBindingSource.EndEdit();
                    empresasTableAdapter.Update(promowork_dataDataSet.Empresas);

                    this.Close();
                }
                catch (DBConcurrencyException)
                {

                    MessageBox.Show("No se Pudo Salvar la Información. El Registro fue modificado por otro Usuario.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    VariablesGlobales.nIdUsuarioActual = 0;
                    VariablesGlobales.nIdEmpresaActual = 0;
                    VariablesGlobales.nAnoActual = 0;
                    VariablesGlobales.nMesActual = 0;

                    this.empresasTableAdapter.Fill(this.promowork_dataDataSet.Empresas);

                    this.usuariosTableAdapter.FillByActivo(this.promowork_dataDataSet.Usuarios);
                    this.accesosUsuariosEmpresasTableAdapter.FillByUsuario(promowork_dataDataSet.AccesosUsuariosEmpresas, Convert.ToInt32(cbUsuario.SelectedValue));

                    DataRowView usuario = (DataRowView)usuariosBindingSource.Current;
                    cbEmpresa.SelectedValue = (int)usuario["UltEmpresa"];

                }
                catch (SqlException ex)
                {
                    if (ErroresSQLServer.ManipulaErrorSQL(ex, this.Text))
                    {
                        VariablesGlobales.nIdUsuarioActual = 0;
                        VariablesGlobales.nIdEmpresaActual = 0;
                        VariablesGlobales.nAnoActual = 0;
                        VariablesGlobales.nMesActual = 0;

                        this.empresasTableAdapter.Fill(this.promowork_dataDataSet.Empresas);

                        this.usuariosTableAdapter.FillByActivo(this.promowork_dataDataSet.Usuarios);
                        this.accesosUsuariosEmpresasTableAdapter.FillByUsuario(promowork_dataDataSet.AccesosUsuariosEmpresas, Convert.ToInt32(cbUsuario.SelectedValue));

                        DataRowView usuario = (DataRowView)usuariosBindingSource.Current;
                        cbEmpresa.SelectedValue = (int)usuario["UltEmpresa"];
                    }

                }

               
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbUsuario_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbUsuario.SelectedIndex != -1)
            {
                this.accesosUsuariosEmpresasTableAdapter.FillByUsuario(promowork_dataDataSet.AccesosUsuariosEmpresas, (int)cbUsuario.SelectedValue);

                DataRow usuario = promowork_dataDataSet.Usuarios.FindByIdUsuario((int)cbUsuario.SelectedValue);
                //cbEmpresa.SelectedValue = usuario["UltEmpresa"] == DBNull.Value ? -1 : (int)usuario["UltEmpresa"];

                VariablesGlobales.ConfiguracionUsuario = JsonConvert.DeserializeObject<ConfiguracionUsuario>(usuario["ConfiguracionUsuario"].ToString());

                if (VariablesGlobales.ConfiguracionUsuario != null)
                {
                    cbEmpresa.SelectedValue = VariablesGlobales.ConfiguracionUsuario.empresaSeleccionada;
                    mesEmpresaTextBox.Text = VariablesGlobales.ConfiguracionUsuario.mesSeleccionado.ToString();
                    anoEmpresaTextBox.Text = VariablesGlobales.ConfiguracionUsuario.anoSeleccionado.ToString();
                }
                else
                {
                    cbEmpresa.SelectedIndex = 0;
                    mesEmpresaTextBox.Text = DateTime.Today.Month.ToString();
                    anoEmpresaTextBox.Text = DateTime.Today.Year.ToString();
                }

            }
        }

       
    }
}
