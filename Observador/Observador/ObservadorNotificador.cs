using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    class ObservadorNotificador : IObservador
    {
        public void Actualiza()
        {
            Console.WriteLine("Existe una actualización de código: Versión 1.1");
        }
    }
}
