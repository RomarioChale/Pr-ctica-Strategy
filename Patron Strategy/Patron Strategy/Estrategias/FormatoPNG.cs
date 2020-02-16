using Patron_Strategy.Interfaces;
using System;

namespace Patron_Strategy.Estrategias
{
    public class FormatoPNG : IAplicarFormato
    {
        public void AplicarFormato(string archivo)
        {
            Console.WriteLine("Se ha guardado la imagen " + archivo + ".PNG");
        }
    }
}
