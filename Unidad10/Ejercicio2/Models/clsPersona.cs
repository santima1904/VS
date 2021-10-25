﻿using System;

namespace Ejercicio2.Models
{
    public class clsPersona
    {
        #region atributos privados
        private String nombre;
        private String apellidos;
        #endregion

        #region propiedades publicas
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }




        #endregion

        // Forma de autoimplementacion (para más adelante)
        // public String Nombre { get; set; }

        #region constructores
        //Constructor por defecto
        public clsPersona()
        {
            this.nombre = "Santi";
            this.apellidos = "Martinez";
        }

        //Constructor por parametros
        public clsPersona(string nombre, string apellidos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
        }

        #endregion
    }
} 