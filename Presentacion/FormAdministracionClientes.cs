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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormAdministracionClientes : Form
    {
        #region Declaraciones y Constructor.
        int IDCliente;
        string Name;
        string Apellido1;
        string Apellido2;
        DateTime BirthDate;
        string Gender;
        private DataBase database;

        public FormAdministracionClientes(DataBase DB)
        {
            InitializeComponent();
            this.database = DB;//Guardo la referencia de la DB que pasé por parámetro al form.
        }
        #endregion

        #region Captura de datos

        #region Datos para añadir
        private void txtboxID_TextChanged(object sender, EventArgs e)
        {
            try
            { //Realizo excepción en caso de que el usuario no escriba valores numéricos.
                string textoescrito = txtboxID.Text;
                IDCliente = int.Parse(textoescrito); //Capturo la identificación y la paso a int.
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Debe colocar una Identificación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void txtboxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan caracteres numéricos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtboxName_TextChanged(object sender, EventArgs e)
        {
            Name = txtboxName.Text; //Capturo el nombre.
        }

        private void txtbox1A_TextChanged(object sender, EventArgs e)
        {
            Apellido1 = txtbox1A.Text; //Capturo el 1er Apellido
        }

        private void txtbox2A_TextChanged(object sender, EventArgs e)
        {
            Apellido2 = txtbox2A.Text; //Capturo el 2do Apellido
        }

        private void dateToAdd_ValueChanged(object sender, EventArgs e)
        {
            BirthDate = dateToAdd.Value;//Capturo la fecha seleccionada
            BirthDate = BirthDate.Date;
        }

        private void cmbbxGenAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gender = cmbbxGenAdd.SelectedIndex.ToString(); //Capturo índice seleccionado y lo paso a string.
        }
        #endregion

        #region Datos para modificar

        private void txtBox_IDtoModify_TextChanged(object sender, EventArgs e)
        {
            try
            { //Realizo excepción en caso de que el usuario no escriba valores numéricos.
                string textoescrito = txtBox_IDtoModify.Text;
                IDCliente = int.Parse(textoescrito); //Capturo la identificación y la paso a int para revisar que no exista.
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Solo se aceptan caracteres numéricos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dateToModify_ValueChanged(object sender, EventArgs e)
        {
            BirthDate = dateToModify.Value;//Capturo la fecha seleccionada para cambiarla.
            BirthDate = BirthDate.Date;
        }

        private void cmbbxGenModify_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gender = cmbbxGenModify.SelectedIndex.ToString(); //Capturo el género para modificarlo.
        }

        #endregion
        #endregion

        #region Llamada a métodos y muestra de datos.

        #region Añadir
        private void bttnAdd_Click(object sender, EventArgs e)
        {
            //Verificar que todas las casillas requeridas sean completadas.

            if (!string.IsNullOrWhiteSpace(txtboxID.Text) && !string.IsNullOrWhiteSpace(txtboxName.Text) &&
                !string.IsNullOrWhiteSpace(txtbox1A.Text) && !string.IsNullOrWhiteSpace(txtbox2A.Text) &&
                BirthDate != DateTime.MinValue && cmbbxGenAdd.SelectedIndex != -1)
            {
                //Llamo a la función que ejecuta toda la lógica.
                if (this.database.ProcesarClienteNuevo(IDCliente, Gender, Name, Apellido1, Apellido2, BirthDate))
                {
                    //Muestro la información en DataGridView
                    dgv_AC.DataSource = this.database.ArrayClientes;
                    dgv_AC.Refresh();
                }
                else
                {
                    MessageBox.Show("La identificación ya se encuentra registrada o ha llegado al máximo permitido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Debe llenar todas las casillas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        #endregion


        #region Modificar

        //Llamar a la función para modificar

        private void bttnModify_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox_IDtoModify.Text) &&
                BirthDate != DateTime.MinValue && cmbbxGenAdd.SelectedIndex != -1)
            {
                if (database.MostrarClienteActualizado(IDCliente, Gender, BirthDate))
                {
                    //Muestro la información en DataGridView
                    dgv_AC.DataSource = this.database.ArrayClientes;
                    dgv_AC.Refresh();
                }
                else
                {
                    MessageBox.Show("No se encontró el cliente con el ID proporcionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Es necesario seleccionar las casillas de modificación ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        #endregion


        //Evento del botón consultar para que recargue la tabla.
        private void bttnCharge_Click(object sender, EventArgs e)
        {
            //Muestro la información en DataGridView
            dgv_AC.DataSource = this.database.ArrayClientes;
            dgv_AC.Refresh();
        }

        #endregion


    }
}
