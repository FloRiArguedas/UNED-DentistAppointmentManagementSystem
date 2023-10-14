/*UNED III Cuatrimestre 2023
 * Proyecto 1 - Programación avanzada 
 * Sistema de Administración de Citas para Desarrollo-UNED
 * Floricela Arguedas Zúñiga
 * 9/10/2023
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        #region Propiedades
        public int Id_Cliente { get; set; }
        public string Name_Cliente { get; set; }
        public string PA_Cliente { get; set; }
        public string SA_Cliente { get; set; }
        public DateTime BiDate_Cliente { get; set; }
        public char Gen_Cliente { get; set; }
        #endregion

        #region Constructor
        public Cliente(int Id_Cliente, string name_Cliente, string pA_Cliente, string sA_Cliente, DateTime biDate_Cliente, char gen_Cliente)
        {
            this.Id_Cliente = Id_Cliente;
            Name_Cliente = name_Cliente;
            PA_Cliente = pA_Cliente;
            SA_Cliente = sA_Cliente;
            BiDate_Cliente = biDate_Cliente;
            Gen_Cliente = gen_Cliente;
        }
        #endregion
        //Utilizo el método ToString de la clase para enviar los datos al combobox.
        public override string ToString()
        {
            return Id_Cliente.ToString() + " " + Name_Cliente + " " + PA_Cliente + " " + SA_Cliente;
        }
    }
}
