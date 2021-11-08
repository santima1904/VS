using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidad11.Entidades;

namespace Unidad11.DAL
{
    public static class clsListado
    {
        /// <summary>
        /// Método para rellenar una lista con objetos de clsPersona
        /// </summary>
        /// <returns>List<clsPersona></returns>
        public static List<clsPersona> rellenarLista()
        {
            List<clsPersona> lista = new List<clsPersona>();
            lista.Add(new clsPersona("Mariano", "Rajoy"));
            lista.Add(new clsPersona("Evaristo", "Hernández"));
            lista.Add(new clsPersona("Jose", "Pingu"));
            lista.Add(new clsPersona("Tibi", "Dominguez"));
            lista.Add(new clsPersona("Patozo", "Juan"));

            return lista;
        }
    }
}
