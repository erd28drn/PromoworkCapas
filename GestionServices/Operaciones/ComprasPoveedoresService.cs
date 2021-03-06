﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using GestionData.Entities;

namespace GestionServices.Operaciones
{
    public static class ComprasPoveedoresService
    {

        public static TotalesCompra CalculaTotalesCompra(BindingSource comprasDetBindingSource)
        {
            List<TotalesCompra> detalleCompra = new List<TotalesCompra>();

            foreach (DataRowView Row in comprasDetBindingSource)
            {
                detalleCompra.Add(new TotalesCompra
                {
                    ImporteBase = Row["ImpBase"] == DBNull.Value ? 0 : (decimal)Row["ImpBase"],
                    ImporteIVA = Row["ImpIva"] == DBNull.Value ? 0 : (decimal)Row["ImpIva"],
                    ImporteIRPF = Row["ImpIRPF"] == DBNull.Value ? 0 : (decimal)Row["ImpIRPF"]
                });
            }

            TotalesCompra totalesCompra= new TotalesCompra();
            try
            {
                totalesCompra.ImporteBase = detalleCompra.Sum(c => c.ImporteBase);
                totalesCompra.ImporteIVA = detalleCompra.Sum(c => c.ImporteIVA);
                totalesCompra.ImporteIRPF = detalleCompra.Sum(c => c.ImporteIRPF);
                return totalesCompra;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular los totales de la compra. "+ ex.Message, "Cálculo Total Compra", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return null;
            }
            
        
        }

        public static decimal CalculaTotalPagado(BindingSource pagosBindingSource)
        {
            List<Decimal> importesPagados = new List<Decimal>();

            foreach (DataRowView Row in pagosBindingSource)
            {
                importesPagados.Add(Row["Importe"] == DBNull.Value ? 0 : (decimal)Row["Importe"]);
            }

            decimal importePagado = 0;
            try
            {
                importePagado = importesPagados.Sum();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el Importe pagado de la compra. " + ex.Message, "Cálculo Pagado Compra", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return importePagado;

        }

    }
}
