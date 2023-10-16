/*UNED III Cuatrimestre 2023
 * Proyecto 1 - Programación avanzada 
 * Sistema de Administración de Citas para Desarrollo-UNED
 * Floricela Arguedas Zúñiga
 * 9/10/2023
 * */

using Entidades;
using LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormReporteFecha : Form
    {
        private DataBase database;
        private DateTime fechacapturada;
        public FormReporteFecha(DataBase DB)
        {
            InitializeComponent();
            this.database = DB;//Guardo la referencia de la DB que pasé por parámetro al form.
        }

        #region Captura y muestra de datos.
        private void DaTiPic_DateSelected_ValueChanged(object sender, EventArgs e)
        {
            fechacapturada = DaTiPic_DateSelected.Value;
            fechacapturada = fechacapturada.Date;
        }
        private void bttn_VerCitasFecha_Click(object sender, EventArgs e)
        {
            var resultado = this.database.EnviarReporteFecha(fechacapturada);
            Entidades.Cita[] ArrayCitasFecha = resultado.Item1;
            bool bandera = resultado.Item2;
            if (bandera == true)
            {
                //Muestro la información en DataGridView
                DGV_ReporteFecha.DataSource = ArrayCitasFecha;
                DGV_ReporteFecha.Refresh();
            }
            else
            {
                MessageBox.Show("No hay citas para la fecha seleccionada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        #endregion
    }
}
