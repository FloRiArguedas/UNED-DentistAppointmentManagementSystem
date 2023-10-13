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
    public partial class P_Principal : Form

    {
        private DataBase DB;
        public P_Principal(DataBase database)
        {
            InitializeComponent();
            this.DB = database;   //Guardo la referencia de la DB para pasarla a los distintos forms.
        }
        #region Formularios
        //Muestro la pantalla de Registro de tipos de consulta, en la primer opción del menú.
        private void registroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoConsulta formulario_TC = new FormTipoConsulta(this.DB);
            formulario_TC.MdiParent = this;
            formulario_TC.Show();
        }

        private void administrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdministracionClientes formulario_AC = new FormAdministracionClientes(this.DB);
            formulario_AC.MdiParent = this;
            formulario_AC.Show();

        }

        private void administrarDoctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdministrarDoctores formulario_AD = new FormAdministrarDoctores(this.DB);
            formulario_AD.MdiParent = this;
            formulario_AD.Show();
        }


        #endregion


    }
}
