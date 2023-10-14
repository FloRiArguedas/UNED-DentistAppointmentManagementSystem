/* UNED III Cuatrimestre 2023
 * Proyecto 1 - Programación avanzada 
 * Sistema de Administración de Citas para Desarrollo-UNED
 * Floricela Arguedas Zúñiga
 * 9/10/2023
 * */


namespace Entidades
{
    public class TipoConsulta
    {
        #region Propiedades
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public char Estado { get; set; }
        #endregion

        #region Constructor
        public TipoConsulta(int id_tc, string description, char status) {
            ID = id_tc;
            Descripcion = description;
            Estado = status;
        
        }
        #endregion

        public override string ToString()
        {
            return ID.ToString() + " " + Descripcion + " " + Estado;
        }
    }
}