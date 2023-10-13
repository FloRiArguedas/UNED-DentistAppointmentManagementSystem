/*UNED III Cuatrimestre 2023
 * Proyecto 1 - Programación avanzada 
 * Sistema de Administración de Citas para Desarrollo-UNED
 * Floricela Arguedas Zúñiga
 * 9/10/2023
 * */
using Entidades;
using LogicaNegocios;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class FormTipoConsulta : Form
    {
        #region Declaraciones
        string description;
        string selectedValue;
        private DataBase database;
        int IDVerify;
        int IDTiCon;
        #endregion

        #region Constructor
        public FormTipoConsulta(DataBase DB)
        {
            InitializeComponent();
            this.database = DB;//Guardo la referencia de la DB que pasé por parámetro al form.
        }
        #endregion

        #region Captura de datos para el objeto TC.

        private void txtbx_IDTC_TextChanged(object sender, EventArgs e)
        {
            IDTiCon = int.Parse(txtbx_IDTC.Text);
        }
        private void txtb_description_TextChanged(object sender, EventArgs e)
        {
            description = txtb_description.Text;
        }
        private void cmbbx_status_SelectedIndexChanged(object sender, EventArgs e)

        {
            selectedValue = cmbbx_status.SelectedIndex.ToString();
        }
        #endregion

        #region Llamada a los métodos y muestra de datos.

        #region Añadir
        //Eventos y métodos para el botón de añadir
        private void bttn_ad_Click(object sender, EventArgs e)
        {
            if (cmbbx_status.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(txtb_description.Text))
            {
                //Llamo a la función de la clase DataBase para que haga toda la lógica.
                if (this.database.AñadirTipoConsulta(IDTiCon, description, selectedValue)) //Valido que venga en true.
                {
                    //Muestro la información en DataGridView
                    DGV_TC.DataSource = this.database.TiposdeConsultas;
                    DGV_TC.Refresh();
                }
                else
                {
                    MessageBox.Show("El ID debe ser único", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Debe llenar todas las casillas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Modificar
        //Eventos y métodos para el botón de modificar

        private void bttn_modify_Click(object sender, EventArgs e)
        {
            string newSelectedValue;
            if (!string.IsNullOrWhiteSpace(txtbx_IDModify.Text)) //Verifico que el textbox no esté vacio.
            {

                try
                { //Manejo excepción en caso de que escriban caracteres que no pueden ser int.
                    IDVerify = int.Parse(txtbx_IDModify.Text);//Capturo ID
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe escribir números enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (cmbbx_changeStatus.SelectedIndex != -1)//Verifico que seleccione un estado.
                {
                    newSelectedValue = cmbbx_changeStatus.SelectedIndex.ToString();
                    //Llamo a la función que verifica que exista el ID y cambia el estado
                    if (database.MostrarTCActualizado(IDVerify, newSelectedValue))
                    {
                        //Muestro la información en DataGridView
                        DGV_TC.DataSource = this.database.TiposdeConsultas;
                        DGV_TC.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("El ID proporcionado no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe cambiar el estado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Debe indicar un ID", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #endregion

    }

}
