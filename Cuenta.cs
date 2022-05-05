using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairCHallenge4
{
    internal class Cuenta:Persona
    {
       
        private double cantidad;
        protected double _cantidad {get => cantidad; set => cantidad = value; }

        public Cuenta()
        { }

        public void MostrarCuenta()
        {
            Console.WriteLine($"Nombre: {_Nombre}");
            Console.WriteLine($"DNI: {_Dni}");
            Console.WriteLine($"Edad: {_Edad}");

            Console.WriteLine($"Cantidad: {_cantidad}");

        }

        public void Ingresar(double dinero)
        {
            if (dinero > 0)
            { 
            this._cantidad += dinero;
            Console.WriteLine($"Usted Deposito:{dinero}, su total es: {this._cantidad}");
            }
        }

        public void Retirar(double dinero)
        {
            

                this._cantidad = this._cantidad-dinero;
                Console.WriteLine($"Usted Retiro:{dinero}, su total es: {this._cantidad}");

        }

    }
}
