using System;

namespace Observador
{
    class Program
    {
        static void Main(string[] args)
        {
            string cRespuesta="";
            IPublicador publicador = new Publicador();
            CrearMenu();
            while (cRespuesta != "6")
            {
                cRespuesta = Console.ReadLine();
                switch (cRespuesta) {
                    case "1":
                        Console.WriteLine("codigo subido");
                        publicador.Notificar();
                        break;
                    case "2":
                        IObservador notificador = new ObservadorNotificador();
                        publicador.Agregar(notificador);
                        break;
                    case "3":
                        IObservador compilador = new observadorCompilador();
                        publicador.Agregar(compilador);
                        break;
                    case "4":
                        IObservador probador = new ObservadorPrueba();
                        publicador.Agregar(probador);
                        break;
                    case "5":
                        IObservador insatlador = new ObservadorInstalador();
                        publicador.Agregar(insatlador);
                        break;
                    case "6":
                        break;
                    default:
                        throw new Exception("Opcion no valida");
                
                }
            }
        }

        static public void CrearMenu()
        {
            Console.WriteLine("Selecciona la opcion que deseas realizar\n" +
                "1 = Subir el código\n" +
                "2 = Agregar Notificador\n" +
                "3 = Agregar Compilador\n" +
                "4 = Agregar Ejecutor de Pruebas Unitarias\n" +
                "5 = Agregar Instalador\n" +
                "6 = Salir");

        }
    }
}
