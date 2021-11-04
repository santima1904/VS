using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cita
    {
        #region atributos
        private string nombreCliente;
        private string apellidosCliente;
        private string telefono;
        private string direccion;

        #endregion

        #region constructor
        //Con parámetros
        public Cita(string nombreCliente, string apellidosCliente, string telefono, string direccion)
        {
            this.NombreCliente = nombreCliente;
            this.ApellidosCliente = apellidosCliente;
            this.Telefono = telefono;
            this.Direccion = direccion;
        }

        //Por defecto
        public Cita()
        {
            this.NombreCliente = " ";
            this.ApellidosCliente = " ";
            this.Telefono = " ";
            this.Direccion = " ";
        }

        #endregion

        #region propiedades publicas
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        #endregion
    }
}
