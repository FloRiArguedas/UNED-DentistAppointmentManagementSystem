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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class FormRegistroCitas : Form
    {
        #region Declaraciones y Constructor
        int IDCita;
        DateTime FechaCita;
        TimeSpan horaCita;
        TipoConsulta TipoConsulta;
        Cliente Paciente;
        Doctor Doctor;
        string DoctorSelected;
        string PacienteSelected;
        string ConsultaSelected;
        private DataBase database;
        public FormRegistroCitas(DataBase DB)
        {
            InitializeComponent();
            this.database = DB;
        }
        #endregion

        #region MÉTODOS PARA CAPTURAR Y MOSTRAR INFORMACIÓN

        #region Métodos para cargar datos a Combobox con eventos.

        //Eventos de click en los combobox para cargar datos.
        //Se apuntan a null primero, para que cada vez que se de el evento, vuelva a cargar el array actualizado.
        private void cmbbx_PacienteCita_Click(object sender, EventArgs e)
        {

            if (this.database.ExistenClientesRegistrados())
            {
                cmbbx_PacienteCita.DataSource = null;
                cmbbx_PacienteCita.DataSource = this.database.ArrayClientes;
            }
            else
            {
                MessageBox.Show("Debe registrar primero al cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void cmbbx_DoctorCita_Click(object sender, EventArgs e)
        {
            //Llamo a la función si viene true muestro los doctores activos.
            if (this.database.CargarDoctoresActivos())
            {
                cmbbx_DoctorCita.DataSource = null;
                cmbbx_DoctorCita.DataSource = this.database.ArrayDoctoresActivos;
            }
            else
            {
                MessageBox.Show("En este momento no hay doctores activos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbbx_TipoConsultaCita_Click(object sender, EventArgs e)
        {
            if (this.database.CargarconsultasActivas())
            {
                cmbbx_TipoConsultaCita.DataSource = null;
                cmbbx_TipoConsultaCita.DataSource = this.database.ArrayConsultasActivas;
            }
            else
            {
                MessageBox.Show("En este momento no hay consultas activas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion


        #region Métodos para capturar datos.
        private void txtbx_IDCita_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string textoescrito = txtbx_IDCita.Text;
                IDCita = int.Parse(textoescrito);
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe colocar un ID", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtbx_IDCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan caracteres numéricos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DateTP_FechaCita_ValueChanged(object sender, EventArgs e)
        {
            FechaCita = DateTP_FechaCita.Value;
        }

        private void cmbbx_horacita_SelectedIndexChanged(object sender, EventArgs e)
        {
            string HoraSeleccionada = cmbbx_horacita.Text;
            TimeSpan hora = TimeSpan.Parse(HoraSeleccionada);//Convertio la hora al formato adecuado.
            FechaCita = FechaCita.Date + hora;//Le elimino a la fecha la hora que tenía por defecto y le coloco la seleccionada por el usuario.
        }

        private void cmbbx_DoctorCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoctorSelected = cmbbx_DoctorCita.Text; //Capturo índice seleccionado.
        }

        private void cmbbx_TipoConsultaCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultaSelected = cmbbx_TipoConsultaCita.Text;
        }

        private void cmbbx_PacienteCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            PacienteSelected = cmbbx_PacienteCita.Text;
        }

        #endregion


        #region Método para añadir nueva cita

        //Llamada a la función que crea la nueva cita.

        private void bttn_AddCita_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbx_IDCita.Text) && cmbbx_PacienteCita.SelectedIndex != -1 &&
                cmbbx_DoctorCita.SelectedIndex != -1 && cmbbx_TipoConsultaCita.SelectedIndex != -1 &&
                FechaCita != DateTime.MinValue && cmbbx_horacita.SelectedIndex != -1)
            {
                if (this.database.ProcesarNuevaCita(IDCita, FechaCita, ConsultaSelected, PacienteSelected, DoctorSelected))
                {
                    //Muestro la información en DataGridView
                    DGV_Citas.DataSource = this.database.ArrayCitas;
                    DGV_Citas.Refresh();
                }
                else {
                    MessageBox.Show("La cita no pudo ser agregada. Verifique el ID, Doctor o Fecha de la cita", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else 
            {
                MessageBox.Show("Debe llenar todas las casillas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #endregion

    }
}
