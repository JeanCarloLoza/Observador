using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    class ObservadorPrueba : IObservador
    {
        public void Actualiza()
        {
            Console.WriteLine("Todas las pruebas unitarias fueron exitosas");
        }
    }
}
