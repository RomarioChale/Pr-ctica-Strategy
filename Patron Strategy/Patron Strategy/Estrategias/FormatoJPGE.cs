using Patron_Strategy.Interfaces;
using System;

namespace Patron_Strategy.Estrategias
{
    public class FormatoJPGE : IAplicarFormato
    {
        public void AplicarFormato(string archivo)
        {
            Console.WriteLine("Se ha guardado la imagen " + archivo + ".JPGE");

        }
    }
}
