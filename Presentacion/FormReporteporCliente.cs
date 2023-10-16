/* UNED III Cuatrimestre 2023
 * Proyecto 1 - Programación avanzada 
 * Sistema de Administración de Citas para Desarrollo-UNED
 * Floricela Arguedas Zúñiga
 * 9/10/2023
 * */
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
    public partial class FormReporteporCliente : Form
    {
        #region Declaraciones y Constructor
        private DataBase database;
        private string PacienteSelected;
        public FormReporteporCliente(DataBase DB)
        {
            InitializeComponent();
            this.database = DB;//Guardo la referencia de la DB que pasé por parámetro al form.
        }
        #endregion

        #region Obtención de Datos
        private void cmbbx_ClienteReporte_Click(object sender, EventArgs e)
        {
            if (this.database.ExistenClientesRegistrados())
            {
                cmbbx_ClienteReporte.DataSource = null;
                cmbbx_ClienteReporte.DataSource = this.database.ArrayClientes;
            }
            else
            {
                MessageBox.Show("Debe registrar primero al cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbbx_ClienteReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            PacienteSelected = cmbbx_ClienteReporte.Text;
        }
        #endregion

        #region Evento y Métodos
        private void bttn_MostrarreporteCliente_Click(object sender, EventArgs e)
        {
            if (cmbbx_ClienteReporte.SelectedIndex != -1)
            {
                var resultado = this.database.EnviarReporteCliente(PacienteSelected);
                Entidades.Cita[] ArrayCitasCliente = resultado.Item1;
                bool bandera = resultado.Item2;
                if (bandera == true)
                {
                    //Muestro la información en DataGridView
                    DGV_ReporteCliente.DataSource = ArrayCitasCliente;
                    DGV_ReporteCliente.Refresh();
                }
                else
                {
                    MessageBox.Show("No hay citas para el paciente seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar el paciente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion
    }
}
