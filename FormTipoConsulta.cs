/*UNED III Cuatrimestre 2023
 * Proyecto 1 - Programaci�n avanzada 
 * Sistema de Administraci�n de Citas para Desarrollo-UNED
 * Floricela Arguedas Z��iga
 * 9/10/2023
 * */
using Entidades;
using LogicaNegocios;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class FormTipoConsulta : Form
    {
        #region Declaraciones
        string description;
        string selectedValue;
        private DataBase database;
        #endregion

        #region Constructor
        public FormTipoConsulta(DataBase DB)
        {
            InitializeComponent();
            this.database = DB;
        }
        #endregion

        #region Captura de datos para el objeto.
        private void txtb_description_TextChanged(object sender, EventArgs e)
        {
            description = txtb_description.Text;
        }
        private void cmbbx_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedValue = cmbbx_status.SelectedIndex.ToString();
        }
        #endregion

        #region Llamada al los m�todos y muestra de datos.
        //Eventos y m�todos para el bot�n de a�adir
        private void bttn_ad_Click(object sender, EventArgs e)
        {
            //Llamo a la funci�n de la clase DataBase para que haga toda la l�gica.
            this.database.A�adirTipoConsulta(description, selectedValue);
            //Muestro la informaci�n en DataGridView
            DGV_TC.DataSource = this.database.TiposdeConsultas;
            DGV_TC.Refresh();
        }
        //Eventos y m�todos para el bot�n de modificar

        #endregion
    }
}