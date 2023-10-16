/*UNED III Cuatrimestre 2023
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
    public partial class FormReporteDoctor : Form
    {
        #region Declaraciones y constructor
        private DataBase database;
        string DoctorSelected;
        public FormReporteDoctor(DataBase DB)
        {
            InitializeComponent();
            this.database = DB;//Guardo la referencia de la DB que pasé por parámetro al form.
        }
        #endregion

        #region Eventos y Métodos
        private void cmbbox_DoctoresReporte_Click(object sender, EventArgs e)
        {
            //Llamo a la función si viene true muestro los doctores activos.
            if (this.database.CargarDoctoresActivos())
            {
                cmbbox_DoctoresReporte.DataSource = null;
                cmbbox_DoctoresReporte.DataSource = this.database.ArrayDoctoresActivos;
            }
        }

        private void cmbbox_DoctoresReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoctorSelected = cmbbox_DoctoresReporte.Text; //Capturo índice seleccionado.
        }

        private void bttn_VerCitasDoctor_Click(object sender, EventArgs e)
        {
            if (cmbbox_DoctoresReporte.SelectedIndex != -1)
            {
                var resultado = this.database.EnviarReporteDoctor(DoctorSelected);
                Entidades.Cita[] ArrayCitasDoctor = resultado.Item1;
                bool bandera = resultado.Item2;
                if (bandera == true)
                {
                    //Muestro la información en DataGridView
                    DGV_ReporteDoctor.DataSource = ArrayCitasDoctor;
                    DGV_ReporteDoctor.Refresh();
                }
                else
                {
                    MessageBox.Show("No hay citas para el doctor seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            else 
            {
                MessageBox.Show("Debe seleccionar el doctor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        #endregion


    }
}
