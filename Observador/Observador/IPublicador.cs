using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    interface IPublicador
    {
        public void Agregar(IObservador observador);
        public void Notificar();
    }
}
