using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairCHallenge4
{
    // REALIZADO CON DAMIAN BOSSATA
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta x = new Cuenta();

            Console.Write("Nombre: ");
            x._Nombre = Console.ReadLine();
            int Edad = 0;
            do
            {
                Console.Write("Edad: ");
            } while (!Int32.TryParse(Console.ReadLine(), out Edad));
            x._Edad = Edad;

            int dni = 0;
            do
            {
                Console.Write("DNI: ");
            } while (!Int32.TryParse(Console.ReadLine(), out dni));
            x._Dni = dni;

            if (x.MayorEdad(x._Edad))
                Console.WriteLine("Mayor de edad");
            else
                Console.WriteLine("Menor de edad");

            Console.ReadKey();
            Console.Clear();

            int opc = 0;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Presione:\n 1) Ver mis datos\n 2) Ver mi estado de cuenta\n 3) Depositar Dinero\n 4) Retirar dinero \n 0) Salir");
                } while (!Int32.TryParse(Console.ReadLine(), out opc) && opc >= 0 && opc <= 4);

                switch (opc)
                {
                    case 1:
                        x.MostrarPersona();
                        Console.ReadKey();
                        break;
                    case 2:
                        x.MostrarCuenta();
                        Console.ReadKey();
                        break;
                    case 3:
                        double cantI = 0;
                        do
                        {
                            Console.Write("Cantidad de dinero a ingresar: ");
                        } while (!double.TryParse(Console.ReadLine(), out cantI));
                        x.Ingresar(cantI);
                        Console.ReadKey();
                        break;
                    case 4:
                        double cantR = 0;
                        do
                        {
                            Console.Write("Cantidad de dinero a retirar: ");
                        } while (!double.TryParse(Console.ReadLine(), out cantR));
                        x.Retirar(cantR);
                        Console.ReadKey();
                        break;
                }
            } while (opc != 0);



        }
    }
}
