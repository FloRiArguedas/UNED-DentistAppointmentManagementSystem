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
using System.Xml.Linq;

namespace Presentacion
{
    public partial class FormAdministrarDoctores : Form
    {
        #region Declaraciones y Constructor.
        int IDDoctor;
        string Name;
        string Apellido1;
        string Apellido2;
        string status;
        private DataBase database;

        public FormAdministrarDoctores(DataBase DB)
        {
            InitializeComponent();
            this.database = DB;//Guardo la referencia de la DB que pasé por parámetro al form.
        }

        #endregion

        #region Captura de Datos

        #region Datos para añadir Doctor

        private void txtbx_IDDoctor_TextChanged(object sender, EventArgs e)
        {
            try
            { //Realizo excepción en caso de que el usuario no escriba valores numéricos.
                string textoescrito = txtbx_IDDoctor.Text;
                IDDoctor = int.Parse(textoescrito); //Capturo la identificación y la paso a int.
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Solo se aceptan caracteres numéricos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Txtbx_NameDoctor_TextChanged(object sender, EventArgs e)
        {
            Name = Txtbx_NameDoctor.Text; //Capturo el nombre.
        }
        private void Txtbx_PriApDoctor_TextChanged(object sender, EventArgs e)
        {
            Apellido1 = Txtbx_PriApDoctor.Text;
        }
        private void Txtbx_SegApDoctor_TextChanged(object sender, EventArgs e)
        {
            Apellido2 = Txtbx_SegApDoctor.Text;
        }
        private void cmbbx_StatusDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = cmbbx_StatusDoctor.SelectedIndex.ToString(); //Capturo índice seleccionado y lo paso a string
        }

        #endregion

        #region Datos para modificar Doctor

        private void Txtbx_IDModifyDoctor_TextChanged(object sender, EventArgs e)
        {
            try
            { //Realizo excepción en caso de que el usuario no escriba valores numéricos.
                string textoescrito = Txtbx_IDModifyDoctor.Text;
                IDDoctor = int.Parse(textoescrito); //Capturo la identificación y la paso a int para revisar que no exista.
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Solo se aceptan caracteres numéricos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cmbbx_StatusModifyDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = cmbbx_StatusModifyDoctor.SelectedIndex.ToString(); //Capturo índice seleccionado y lo paso a string
        }

        #endregion

        #endregion

        #region Llamada a métodos y muestra de datos.

        #region Añadir
        //Llamar a la función para Añadir y validar casillas.
        private void bttn_addDoc_Click(object sender, EventArgs e)
        {
            //Verificar que todas las casillas requeridas sean completadas.

            if (!string.IsNullOrWhiteSpace(txtbx_IDDoctor.Text) && !string.IsNullOrWhiteSpace(Txtbx_NameDoctor.Text) &&
                !string.IsNullOrWhiteSpace(Txtbx_PriApDoctor.Text) && !string.IsNullOrWhiteSpace(Txtbx_SegApDoctor.Text) &&
                cmbbx_StatusDoctor.SelectedIndex != -1)
            {
                //Llamo a la función que ejecuta toda la lógica.
                if (this.database.ProcesarDoctorNuevo(IDDoctor, Name, Apellido1, Apellido2, status))
                {
                    //Muestro la información en DataGridView
                    DGV_Doctores.DataSource = this.database.ArrayDoctors;
                    DGV_Doctores.Refresh();
                }
                else
                {
                    MessageBox.Show("La identificación ya se encuentra registrada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Debe llenar todas las casillas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Modificar
        //Llamar a la función para modificar y validar casillas.
        private void bttn_ModifyDoc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txtbx_IDModifyDoctor.Text) && cmbbx_StatusModifyDoctor.SelectedIndex != -1)
            {
                if (database.MostrarDoctorActualizado(IDDoctor, status))
                {
                    //Muestro la información en DataGridView
                    DGV_Doctores.DataSource = this.database.ArrayDoctors;
                    DGV_Doctores.Refresh();
                }
                else
                {
                    MessageBox.Show("No se encontró el doctor con el ID proporcionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Es necesario seleccionar las casillas de modificación ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        #endregion

        #endregion

    }
}
