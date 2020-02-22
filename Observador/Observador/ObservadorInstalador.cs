using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    class ObservadorInstalador : IObservador
    {
        public void Actualiza()
        {
            Console.WriteLine("Ejecutando Instalador");
        }
    }
}
