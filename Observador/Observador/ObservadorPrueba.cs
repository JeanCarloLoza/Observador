using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    class ObservadorPrueba : IObservador
    {
        public void Actualiza()
        {
            Console.WriteLine("Ejecutando Prueba");
        }
    }
}
