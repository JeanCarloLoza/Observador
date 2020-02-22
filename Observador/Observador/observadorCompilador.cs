using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    class observadorCompilador : IObservador
    {
        public void Actualiza()
        {
            Console.WriteLine("Ejecutando Compilador");
        }
    }
}
