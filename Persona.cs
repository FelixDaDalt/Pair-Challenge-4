using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairCHallenge4
{
    class Persona
    {
        private int Dni;
        private string Nombre;
        private int Edad;

        public int _Dni { get => Dni; set => Dni = value; }
        public string _Nombre { get => Nombre; set => Nombre = value; }
        public int _Edad { get => Edad; set => Edad = value; }

        public Persona()
        { 
        
        }

        public void MostrarPersona()
        {
            Console.WriteLine($"Nombre: {_Nombre}");
            Console.WriteLine($"DNI: {_Dni}");
            Console.WriteLine($"Edad: {_Edad}");
        }

        public bool MayorEdad(int _Edad)
        {
            if (_Edad >= 18)
                return true;
            else
                return false;
        }

    }
}
