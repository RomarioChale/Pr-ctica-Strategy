using Patron_Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Strategy.Estrategias
{
    public class FormatoBMP : IAplicarFormato
    {
        public void AplicarFormato(string archivo)
        {
            Console.WriteLine("Se ha guardado la imagen " + archivo + ".BMP");
        }
    }
}
