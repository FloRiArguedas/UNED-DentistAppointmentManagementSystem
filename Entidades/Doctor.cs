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
    public class Doctor
    {
        #region Propiedades
        public int ID_Doctor { get; set; }
        public string Name_Doctor { get; set; }
        public string PA_Doctor { get; set; }
        public string SA_Doctor { get; set; }
        public char Status_Doctor { get; set; }
        #endregion

        #region Constructor
        public Doctor(int iD_Doctor, string name_Doctor, string pA_Doctor, string sA_Doctor, char status_Doctor)
        {
            ID_Doctor = iD_Doctor;
            Name_Doctor = name_Doctor;
            PA_Doctor = pA_Doctor;
            SA_Doctor = sA_Doctor;
            Status_Doctor = status_Doctor;
        }
        #endregion

    }
}
