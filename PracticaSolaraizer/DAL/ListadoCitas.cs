using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class ListadoCitas
    {
        /// <summary>
        /// Cabecera: public List<Cita> generarListadoCitas()
        /// Descripción: Método para generar una lista con objetos tipo Cita
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Cita> generarListadoCitas()
        {
            List<Cita> listadoCitas = new List<Cita>();
            Cita c1 = new Cita("Albert", "Machio", "987654321", "Calle Perú, n7");
            Cita c2 = new Cita("Jesus", "Trabaja", "974638729", "Avenida Casi Perú, n36");
            Cita c3 = new Cita("Pedro", "Pastor", "9828192983", "Calle Habla rico, n68");
            Cita c4 = new Cita("Fray", "Guillermo", "987897561", "Ronda de Narnia, n24");
            Cita c5 = new Cita("Shifu", "Gato", "92364728", "Calle Miau, n2");

            listadoCitas.Add(c1);
            listadoCitas.Add(c2);
            listadoCitas.Add(c3);
            listadoCitas.Add(c4);
            listadoCitas.Add(c5);

            return listadoCitas;
        }
    }
}
