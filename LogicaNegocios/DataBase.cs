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
        public Cliente[] ArrayClientes;


        public DataBase()
        {
            TiposdeConsultas = new TipoConsulta[10];
            ArrayClientes = new Cliente[20];
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
            return AddArrayTipoConsulta(nuevo_tc);//Añado el nuevo objeto al array. Retorno si es true/false.

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



        #endregion

        #endregion


        #region Métodos para ADMINISTRAR CLIENTES

        #region Métodos para crear y añadir Clientes

        //Verificar si la identificación del cliente es única.
        public bool VerificarIdentificacionCliente(int IDCliente)
        {
            for (int i = 0; i < this.ArrayClientes.Length; i++)
            {
                if (ArrayClientes != null) //Verifico que el array no este nulo.
                {
                    if (ArrayClientes[i] != null && IDCliente == ArrayClientes[i].Id_Cliente) //Verifico que no este nulo el índice
                    {
                        return false; // ID no es unico
                    }
                }
            }
            return true; //ID es único
        }

        //Método para convertir a char el género del cliente.
        public char ConvertirGenero(string obtained_gender)
        {

            char gender =' ';
            if (obtained_gender != null)
            {
                if (obtained_gender == "0")
                {
                    gender = 'F';
                }
                else if (obtained_gender == "1")
                {
                    gender = 'M';
                }
                else
                {
                    gender = 'N';
                }
            }
            return gender;
        }

        //Método para crear un nuevo cliente.
        public Cliente CrearCliente(int ID, string name, string apellido1, string apellido2, DateTime fechaNac, char gender)
        {
            Cliente ClienteNuevo= null;

            if (VerificarIdentificacionCliente(ID))
            {
                ClienteNuevo = new Cliente(ID, name, apellido1, apellido2, fechaNac, gender);
            }

            return ClienteNuevo;
        }

        //Método para enviar el nuevo cliente al arreglo.
        public bool AddClienttoArray (Cliente ClienteNuevo)
        {
            if (ClienteNuevo != null) //Verifico que el cliente haya sido creado.
            {
                for (int i = 0; i < ArrayClientes.Length; i++)
                {
                    if (ArrayClientes[i] == null)
                    {
                        ArrayClientes[i] = ClienteNuevo;
                        return true; //Se añadió cliente.
                    }
                }
            }
            return false; //No se añadió cliente.
        }

        //Método que procesa todo lo necesario para crear un cliente nuevo.

        public bool ProcesarClienteNuevo(int IDCliente, string obtained_gender,string name, string apellido1, string apellido2, DateTime fechaNac) {

            VerificarIdentificacionCliente(IDCliente); //Llamo a la funcion que revisa si el ID no existe.
            char gender = ConvertirGenero(obtained_gender);//Llamo a la función que recibe el género lo convierte a char.
            //Llamo a la función que crea el cliente.
            Cliente ClienteNuevo= CrearCliente(IDCliente, name, apellido1, apellido2, fechaNac, gender);
            //Llamo a la función que llena el array.
            return AddClienttoArray(ClienteNuevo); //Retorno si se añadió o no el cliente para enviar msj a interfaz.
        }


        #endregion

        #region Métodos para buscar y modificar Clientes

        //Método para buscar que la identificación del cliente ya exista.
        public Cliente RevisarIDexiste(int ID)
        {
            Cliente ClienteEncontrado = null;

            for (int i = 0; i < ArrayClientes.Length; i++)
            {
                if (this.ArrayClientes[i] != null) //Verifico que este indice no este null.
                {
                    if (ID == this.ArrayClientes[i].Id_Cliente)
                    {
                        ClienteEncontrado = ArrayClientes[i];
                        return ClienteEncontrado;
                    }
                }
                else
                {
                    break;
                }
            }
            return ClienteEncontrado;
        }

        //Método para cambiar el género y fecha de nacimiento del cliente.
        public bool ModificarCliente(string selectedValue, Cliente ClienteEncontrado, DateTime FechaActualizada)
        {
            char newgenre;
            if (FechaActualizada != DateTime.MinValue) { //Valido que el usuario haya cambiado la fecha de nacimiento.
                newgenre = ConvertirGenero(selectedValue); //Llamo a la función y devuelvo el char con el valor seleccionado.
                ClienteEncontrado.Gen_Cliente = newgenre; //Ingreso al objeto el nuevo género.
                ClienteEncontrado.BiDate_Cliente = FechaActualizada; //Ingreso al objeto la nueva fecha.
                return true;
            }
            return false; //El usuario no seleccionó fecha.
        }

        //Método para realizar/mostrar  la modificación del cliente.

        public bool MostrarClienteActualizado(int ID, string SelectedValue, DateTime FechaActualizada)
        {
            Cliente ClienteEncontrado;
            ClienteEncontrado = RevisarIDexiste(ID);
            if (ClienteEncontrado != null)
            {
                ModificarCliente(SelectedValue, ClienteEncontrado, FechaActualizada); return true;
            }
            return false;
        }
        #endregion
        #endregion
        #endregion

    }
}


