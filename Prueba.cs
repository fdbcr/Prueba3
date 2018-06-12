using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindMvc5
{
    public class Prueba
    {
        public string Nombre { get; set; }

        private int edad;
        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }

        public double Pruebas { get; set; }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public void Metodo()
        {

            try
            {

            }
            catch (Exception)
            {

                throw;
            }

            try
            {

            }
            finally
            {

            }

            if (true)
            {

            }

        }

    }
}