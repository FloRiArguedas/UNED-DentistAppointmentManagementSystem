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
    public partial class FormRegistroCitas : Form
    {
        #region Declaraciones y Constructor
        int IDCita;
        DateTime FechaCita;
        TipoConsulta TipoConsulta;
        Cliente Paciente;
        Doctor Doctor;
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
            else {
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
            else { 
                MessageBox.Show("En este momento no hay doctores activos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbbx_TipoConsultaCita_Click(object sender, EventArgs e)
        {
            if (this.database.CargarconsultasActivas()) { 
                cmbbx_TipoConsultaCita.DataSource = null;
                cmbbx_TipoConsultaCita.DataSource = this.database.ArrayConsultasActivas;
            }
            else
            {
                MessageBox.Show("En este momento no hay consultas activas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #endregion
    }
}
