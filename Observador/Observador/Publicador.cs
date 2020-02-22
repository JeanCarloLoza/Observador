using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    class Publicador : IPublicador
    {
        List<IObservador> lstObservadores;

        public Publicador()
        {
            lstObservadores = new List<IObservador>();
        }

        public void Agregar(IObservador observador)
        {
            if (lstObservadores.Exists(x => x.GetType() == observador.GetType()))
                Console.WriteLine("Ya habia sido agregado");
            else
            {
                Console.WriteLine("Agregado");
                lstObservadores.Add(observador);
            }
        }

        public void Notificar()
        {
            foreach (IObservador observador in lstObservadores)
            {
                observador.Actualiza();
            }
        }
    }
}
