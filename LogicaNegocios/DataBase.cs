/* UNED III Cuatrimestre 2023
 * Proyecto 1 - Programación avanzada 
 * Sistema de Administración de Citas para Desarrollo-UNED
 * Floricela Arguedas Zúñiga
 * 9/10/2023
 * */

using Entidades;
using System.Windows;


namespace LogicaNegocios
{
    public class DataBase
    {
        #region Declaraciones/Instancias
        public TipoConsulta[] TiposdeConsultas;
        public DataBase()
        {
            TiposdeConsultas = new TipoConsulta[10];
        }
        #endregion

        #region METODOS
        //En esta región estarán todos los métodos para el funcionamiento del sistema.
        #region Métodos para TIPO CONSULTA

        #region Métodos para crear y añadir un Tipo Consulta.
        //Métodos necesarios para llenar el arreglo de tipo consulta, después de capturar los datos en la interfaz.

        //Verificar si es un ID único.
        public bool IDunico(int IDTiCo)
        {

            for (int i = 0; i < TiposdeConsultas.Length; i++)
            {
                if (TiposdeConsultas != null) //Verifico que el array no este nulo.
                {
                    if (TiposdeConsultas[i] != null && IDTiCo == TiposdeConsultas[i].ID) //Verifico que no este nulo el índice
                    {
                        return false; // ID no es unico
                    }
                }
            }
            return true; //ID es único
        }

        //Retornar caracter con tipo status
        public char Status_Send(string obtained_status)
        {

            char status = ' ';
            if (obtained_status != null)
            {
                if (obtained_status == "0")
                {
                    status = 'A';
                }
                else
                {
                    status = 'I';
                }
            }
            return status;
        }

        //Método para crear un nuevo Tipo de Consulta
        public TipoConsulta CrearNuevoTipoConsulta(int IDTiCo, string descriptiontc, char status)
        {
            //Creación del objetoTipoConsulta
            TipoConsulta NuevoTipodeConsulta = null;
            if (IDunico(IDTiCo)) //Creo el objeto solo si el ID es único.
            {
                NuevoTipodeConsulta = new TipoConsulta(IDTiCo, descriptiontc, status);
            }
            return NuevoTipodeConsulta;
        }

        //Método para ingresar el nuevo Tipo de Consulta al arreglo.
        public bool AddArrayTipoConsulta(TipoConsulta NuevoTipodeConsulta)
        {
            if (NuevoTipodeConsulta != null)
            {
                for (int i = 0; i < TiposdeConsultas.Length; i++)
                {
                    if (TiposdeConsultas[i] == null)
                    {
                        TiposdeConsultas[i] = NuevoTipodeConsulta;
                        return true;
                    }
                }
            }
            return false;
        }

        //Método para procesar todo lo necesario para el evento añadir
        public bool AñadirTipoConsulta(int id_tc, string description, string selectedValue)
        {
            char status = Status_Send(selectedValue); //Llamo a la función y devuelvo el char con el valor seleccionado.
            TipoConsulta nuevo_tc = CrearNuevoTipoConsulta(id_tc, description, status); //creo el nuevo objeto Tipo Consulta.
            return AddArrayTipoConsulta(nuevo_tc);//Añado el nuevo objeto al array. Retorno si es true/salse.

        }
        #endregion

        #region Métodos para la modificación de Tipos de Consulta.


        //Método para buscar el ID del objeto Tipo Consulta
        public TipoConsulta VerificarID(int ID)
        {
            TipoConsulta TC_Encontrada = null;

            for (int i = 0; i < TiposdeConsultas.Length; i++)
            {
                if (this.TiposdeConsultas[i] != null) //Verifico que este indice no este null.
                {
                    if (ID == this.TiposdeConsultas[i].ID)
                    {
                        TC_Encontrada = TiposdeConsultas[i];
                        return TC_Encontrada;
                    }
                }
                else
                {
                    break;
                }
            }
            return TC_Encontrada;
        }


        //Método para cambiar el estado del Tipo Consulta

        public void ModificarEstado(string selectedValue, TipoConsulta TC_Encontrada)
        {
            char CurrentStatus;
            CurrentStatus = Status_Send(selectedValue); //Llamo a la función y devuelvo el char con el valor seleccionado.
            TC_Encontrada.Estado = CurrentStatus;
        }

        //Método para mostrar Tipo Consulta actualizado.

        public bool MostrarTCActualizado(int ID, string SelectedValue)
        {
            TipoConsulta TC_Encontrada;
            TC_Encontrada = VerificarID(ID);
            if (TC_Encontrada != null)
            {
                ModificarEstado(SelectedValue, TC_Encontrada); return true;
            }
            return false;
        }
    }
    #endregion

    #endregion

    #endregion

}


