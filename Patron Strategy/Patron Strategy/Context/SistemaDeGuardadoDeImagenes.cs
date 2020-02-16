using Patron_Strategy.Estrategias;
using Patron_Strategy.Interfaces;

namespace Patron_Strategy.Context
{
    public class SistemaDeGuardadoDeImagenes
    {
        private IAplicarFormato _aplicarFormato;
        public void AsignarTipoFormato(TipoArchivo tipoArchivo)
        {

            switch (tipoArchivo)
            {
                case TipoArchivo.BMP:
                    _aplicarFormato = new FormatoBMP();
                    break;
                case TipoArchivo.JPGE:
                    _aplicarFormato = new FormatoJPGE();
                    break;
                case TipoArchivo.PNG:
                    _aplicarFormato = new FormatoPNG();
                    break;

            }
        }

 
        public void Ejecutar(string archivo)
        {
            _aplicarFormato.AplicarFormato(archivo);
        }

    }
}
