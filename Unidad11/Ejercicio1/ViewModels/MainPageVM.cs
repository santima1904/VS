using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidad11.DAL;
using Unidad11.Entidades;
using Windows.UI.Xaml;

namespace Ejercicio1.ViewModels
{
    public class MainPageVM
    {
        private List<clsPersona> listaPersonas;
        private clsPersona opersona;

        #region constructores
        public MainPageVM()
        {
            listaPersonas = clsListado.rellenarLista();
            //opersona = opersonaSeleccionada;
        }

        #endregion

        /// <summary>
        ///     <h1>Cabecera: </h1> public void Guardar_Click(object sender, RoutedEventArgs e)
        ///     <h1>Descripción: </h1>Método asociado con el evento del botón dado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Guardar_Click(object sender, RoutedEventArgs e)

        {

           

        }
    }
}
