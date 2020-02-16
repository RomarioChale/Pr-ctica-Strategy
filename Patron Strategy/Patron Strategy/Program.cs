using Patron_Strategy.Context;
using Patron_Strategy.Estrategias;
using System;

namespace Patron_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {

            string archivo = string.Empty;
            int opcion;
            do
            {
                Console.WriteLine("Ingrese el nombre del archivo");
                archivo = Convert.ToString(Console.ReadLine());

            } while (string.IsNullOrEmpty(archivo));

            do {
                Console.WriteLine("Selecciona el formato");
                Console.WriteLine("1.BMP");
                Console.WriteLine("2.PNG");
                Console.WriteLine("3.JPGE");

                opcion = Convert.ToInt32(Console.ReadLine());

                SistemaDeGuardadoDeImagenes sistemaDeGuardadoDeImagenes = new SistemaDeGuardadoDeImagenes();

                switch (opcion)
                {
                    case 1:
                        sistemaDeGuardadoDeImagenes.AsignarTipoFormato(TipoArchivo.BMP);
                        sistemaDeGuardadoDeImagenes.Ejecutar(archivo);
                        break;
                    case 2:
                        sistemaDeGuardadoDeImagenes.AsignarTipoFormato(TipoArchivo.PNG);
                        sistemaDeGuardadoDeImagenes.Ejecutar(archivo);

                        break;
                    case 3:
                        sistemaDeGuardadoDeImagenes.AsignarTipoFormato(TipoArchivo.JPGE);
                        sistemaDeGuardadoDeImagenes.Ejecutar(archivo);

                        break;

                }
            } while (opcion > 3);

            Console.ReadKey();
        }
    }
}
