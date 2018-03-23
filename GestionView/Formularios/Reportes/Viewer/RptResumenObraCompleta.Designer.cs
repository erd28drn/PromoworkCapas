﻿namespace Promowork.Formularios.Reportes.Viewer
{
    partial class RptResumenObraCompleta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ResumenObraCompletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Promowork_dataDataSet = new GestionData.Promowork_dataDataSet();
            this.EmpresasActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resumenObraCompletaTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ResumenObraCompletaTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.ResumenObraCompletaTableAdapter();
            this.EmpresasActualTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter();
            this.resumenObraCompletaTotalTableAdapter = new GestionData.Promowork_dataDataSetTableAdapters.ResumenObraCompletaTotalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ResumenObraCompletaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasActualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumenObraCompletaTotalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ResumenObraCompletaBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.EmpresasActualBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.resumenObraCompletaTotalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Promowork.ResumenObraCompleta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1028, 585);
            this.reportViewer1.TabIndex = 0;
            // 
            // ResumenObraCompletaBindingSource
            // 
            this.ResumenObraCompletaBindingSource.DataMember = "ResumenObraCompleta";
            this.ResumenObraCompletaBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // Promowork_dataDataSet
            // 
            this.Promowork_dataDataSet.DataSetName = "Promowork_dataDataSet";
            this.Promowork_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmpresasActualBindingSource
            // 
            this.EmpresasActualBindingSource.DataMember = "EmpresasActual";
            this.EmpresasActualBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // resumenObraCompletaTotalBindingSource
            // 
            this.resumenObraCompletaTotalBindingSource.DataMember = "ResumenObraCompletaTotal";
            this.resumenObraCompletaTotalBindingSource.DataSource = this.Promowork_dataDataSet;
            // 
            // ResumenObraCompletaTableAdapter
            // 
            this.ResumenObraCompletaTableAdapter.ClearBeforeFill = true;
            // 
            // EmpresasActualTableAdapter
            // 
            this.EmpresasActualTableAdapter.ClearBeforeFill = true;
            // 
            // resumenObraCompletaTotalTableAdapter
            // 
            this.resumenObraCompletaTotalTableAdapter.ClearBeforeFill = true;
            // 
            // RptResumenObraCompleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 585);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RptResumenObraCompleta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Resumen Completo de Obra";
            this.Load += new System.EventHandler(this.RptResumenObraCompleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResumenObraCompletaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Promowork_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasActualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumenObraCompletaTotalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ResumenObraCompletaBindingSource;
        private GestionData.Promowork_dataDataSet Promowork_dataDataSet;
        private System.Windows.Forms.BindingSource EmpresasActualBindingSource;
        private GestionData.Promowork_dataDataSetTableAdapters.ResumenObraCompletaTableAdapter ResumenObraCompletaTableAdapter;
        private GestionData.Promowork_dataDataSetTableAdapters.EmpresasActualTableAdapter EmpresasActualTableAdapter;
        private System.Windows.Forms.BindingSource resumenObraCompletaTotalBindingSource;
        private GestionData.Promowork_dataDataSetTableAdapters.ResumenObraCompletaTotalTableAdapter resumenObraCompletaTotalTableAdapter;
    }
}