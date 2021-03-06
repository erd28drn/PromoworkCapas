﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Data.SqlClient;
using System.Windows.Forms;
//using System.Drawing;
//using WIA;
using System.IO;
//using System.Windows.Media.Imaging;
//using AcroPDFLib;
//using AxAcroPDFLib;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

//using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using Microsoft.Reporting.WinForms;
using System.Net.Mail;
using System.Net;
using GestionData;
using GestionData.Entities;
using GestionData.Modelos;


namespace GestionServices.Generales
{
    
    public static class Utilidades
    {
        public static Boolean Escanear(string texto)
        {

            return true;
        }

        //public static Boolean ConvertirPDF()
        //{
        //    string pdfpath = "C:\\Salva Documentos\\Promowork";
        //    string imagepath = "C:\\Salva Documentos\\Promowork";
        //    Document doc = new Document();
        //    try
        //    {
                
        //        PdfWriter.GetInstance(doc, new FileStream(pdfpath + "\\Images.pdf", FileMode.Create));
        //        doc.Open();

        //        doc.Add(new Paragraph("GIF"));
        //        Image gif = Image.GetInstance(imagepath + "\\Prueba.gif");
        //        doc.Add(gif);
        //    }
        //    catch (Exception ex)
        //    {
        //        //Log error;
        //    }
        //    finally
        //    {
        //        doc.Close();
        //    }

        //    return true;
        //}

        #region RECUENTO, SUMA Y PROMEDIO DE CELDAS
        public static resultadoCeldasSeleccionadas SumarCeldas(DevExpress.XtraGrid.Views.Grid.GridView gridView, GridCell[] celdasSeleccionadas)
        {
            
            resultadoCeldasSeleccionadas resultado= new resultadoCeldasSeleccionadas();
            
            double importeTotal = 0;

            for (int i = 0; i < celdasSeleccionadas.Count(); i++)
            {
                double importeCel = 0;
                double.TryParse(gridView.GetRowCellDisplayText(celdasSeleccionadas[i].RowHandle, celdasSeleccionadas[i].Column).Replace("€",""), out importeCel);
                importeTotal = importeTotal + importeCel;
            }

            resultado.Recuento = celdasSeleccionadas.Count();
            resultado.Suma =  importeTotal;
            resultado.Promedio = importeTotal / celdasSeleccionadas.Count();


            return resultado;

        }
        public class resultadoCeldasSeleccionadas
        {
            public int Recuento { get; set; }
            public double Suma { get; set; }
            public double Promedio { get; set; }

        }
        #endregion RECUENTO, SUMA Y PROMEDIO DE CELDAS

        #region EXPORTA REPORTES EN PDF Y XLS
        public static string ExportarReporte(ReportViewer reporte, string nombreReporte, string extension, string tipo)
        {
            try
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;


                byte[] bytes = reporte.LocalReport.Render
                  (tipo, null, out mimeType, out encoding, out tipo, out 
              streamids, out warnings);

                FileStream fs = new FileStream(nombreReporte + extension, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite, 8);
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();

                MemoryStream memoryStream = new MemoryStream(bytes);
                memoryStream.Seek(0, SeekOrigin.Begin);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Error al crear el fichero. "+ ex.Message;
            }
        }

        #endregion EXPORTA REPORTES EN PDF Y XLS

        #region ENVIAR REPORTES POR CORREO ELECTRONICO
        public static string EnviaCorreo(int idEmpresa, List<string> destinatarios, string asunto, List<string> adjuntos, string cuerpo, List<string> responderA, List<string> ccos=null, string nombreRemitente="")
        {
            string mensaje="";
            GeneralesDataModel contextoGeneral = new GeneralesDataModel();
            ServidorSMTP servidorSMTP = null;
            try
            {
                servidorSMTP = contextoGeneral.ServidorSMTP.FirstOrDefault(s => s.IdEmpresa == idEmpresa);
            }
            catch (Exception ex)
            {
                mensaje = "Ocurrió un error al obtener los datos del servidor SMTP. " + ex.Message;
            }

            if (servidorSMTP != null)
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Host = servidorSMTP.NombreServidorSMTP;
                smtp.Port = servidorSMTP.PuertoSMTP.Value;
                smtp.EnableSsl = servidorSMTP.HabilitarSSL.Value;
                smtp.UseDefaultCredentials = servidorSMTP.UsarCredencialesPorDefecto.Value;
                smtp.Credentials = new NetworkCredential(servidorSMTP.Usuario, servidorSMTP.Clave);

                MailMessage msg = new MailMessage();

                string from = "compras@promowork.es";//servidorSMTP.Usuario
                if (responderA != null && responderA.Any())
                {
                    from = responderA.FirstOrDefault();
                    foreach (string responder in responderA)
                    {
                        msg.ReplyToList.Add(new MailAddress(responder));
                    }
                }

                msg.IsBodyHtml = true;
                msg.From = new MailAddress(from, nombreRemitente);//servidorSMTP.Usuario);
                msg.Subject = asunto;
                msg.Body = cuerpo;

                foreach (string destinatario in destinatarios)
                {
                    msg.To.Add(new MailAddress(destinatario.Trim()));
                }
                if (ccos != null)
                {
                    foreach (string cco in ccos)
                    {
                        msg.Bcc.Add(new MailAddress(cco.Trim()));
                    }
                }

                if (adjuntos != null)
                {
                    foreach (string adjunto in adjuntos)
                    {
                        Attachment attachment = new Attachment(adjunto);
                        msg.Attachments.Add(attachment);
                    }
                }

                try
                {
                    smtp.Send(msg);
                    msg.Dispose();
                    mensaje = "OK";
                }
                catch (Exception ex)
                {
                    mensaje = "Error al enviar correo electrónico: " + ex.Message;
                }
            }
            else
            {
                mensaje = "No existen datos de servidor SMTP para la empresa actual";
            }

            return mensaje;
        }
        #endregion ENVIAR REPORTES POR CORREO ELECTRONICO

        #region CREAR TABLA DESDE GRIDVIEW
        public static string CrearTablaHTMLDesdeGridView(GridView gridView)
        {
            string tablaHtml = "<table  border=1 cellspacing=0 cellpadding=2>";
            tablaHtml += "<tr bgcolor='BlanchedAlmond' style='font-weight:bold'>";

            foreach (GridColumn column in gridView.Columns)
            {
                if (column.Visible)
                {
                    tablaHtml += "<td>" + column.Caption + "</td>";
                }
            }
            tablaHtml += "</tr>";

            for (int i = 0; i < gridView.RowCount; i++)
            {
                tablaHtml += "<tr>";
                foreach (GridColumn column in gridView.Columns)
                {
                    if (column.Visible)
                    {
                        if (column.ColumnType== typeof(bool))
                        {
                            var celValue= (bool)gridView.GetRowCellValue(i, column)==true?"X":"";

                            tablaHtml += "<td align='center' style='font-weight:bold'>" + celValue + "</td>";
                        }
                        else
                        {
                            tablaHtml += "<td>" + gridView.GetRowCellValue(i, column) ?? "" + "</td>";
                        }
                    }
                }
                tablaHtml += "</tr>";
            }
            tablaHtml += "</table>";


            return tablaHtml;
        }
        #endregion CREAR TABLA DESDE GRIDVIEW


        public static bool ValidarMes(string mes)
        { 
            int mesInt=0;
            int.TryParse(mes, out mesInt);

            if (mesInt >= 1 && mesInt <= 12)
            {
                return true;
            }
            return false;
        }
        
    }
}
