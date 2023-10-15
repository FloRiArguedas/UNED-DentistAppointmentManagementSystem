/*UNED III Cuatrimestre 2023
 * Proyecto 1 - Programación avanzada 
 * Sistema de Administración de Citas para Desarrollo-UNED
 * Floricela Arguedas Zúñiga
 * 9/10/2023
 * */
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cita
    {
        #region Propiedades
        public int IDCita { get; set; }
        public DateTime FechaCita { get; set; }
        public TipoConsulta ConsultaCita { get; set; }
        public Cliente ClienteCita { get; set; }
        public Doctor DoctorCita { get; set; }
        #endregion

        #region Constructor
        public Cita(int iDCita, DateTime fechaCita, TipoConsulta consultaCita, Cliente clienteCita, Doctor doctorCita)
        {
            IDCita = iDCita;
            FechaCita = fechaCita;
            ConsultaCita = consultaCita;
            ClienteCita = clienteCita;
            DoctorCita = doctorCita;
        }
        #endregion
    }
}
