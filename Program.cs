using System;

namespace S03_ListaDobleCircular
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            int opcionMenu;
            do
            {
                Console.WriteLine("\n |-------------------------------------------|");
                Console.WriteLine(" |              Lista Circular               |");
                Console.WriteLine(" |--------------------|----------------------|");
                Console.WriteLine(" |----1. Insertar ----|----5.Desplegar PU----|");
                Console.WriteLine(" |----2. Buscar   ----|----6.Desplegar UP----|");
                Console.WriteLine(" |----3. Modificar----|----7.Eliminar lista--|");
                Console.WriteLine(" |----4. Eliminar nodo|----8.Salir       ----|");
                Console.WriteLine(" Escoja una opción : ");
                opcionMenu = int.Parse(Console.ReadLine());
                switch (opcionMenu)
                {
                    case 1:
                        Console.WriteLine("\n\n INSERTA NODO EN LA LISTA \n");
                        l.InsertarNodo();
                        break;
                    case 2:
                        Console.WriteLine("\n\n BUSCAR NODO EN LA LISTA \n");
                        l.BuscarNodo();
                        break;
                    case 3:
                        Console.WriteLine("\n\n MODIFICAR NODO EN LA LISTA \n");
                        //l.ModificarNodo();
                        break;
                    case 4:
                        Console.WriteLine("\n\n ELIMINAR NODO EN LA LISTA \n");
                        //l.EliminarNodo();
                        break;
                    case 5:
                        Console.WriteLine("\n\n DESPLEGAR LISTA DE NODOS DEL PRIMERO AL ÚLTIMO \n");
                        l.DesplegarListaPU();
                        break;
                    case 6:
                        Console.WriteLine("\n\n DESPLEGAR LISTA DE NODOS DEL ÚLTIMO AL PRIMERO \n");
                        l.DesplegarListaUP();
                        break;
                    case 7:
                        Console.WriteLine("\n\n ELIMINAR LISTA DE NODOS \n");
                        //l.EliminarLista();
                        break;
                    case 8:
                        Console.WriteLine("\n\n PROGRAMA FINALIZADO \n");
                        break;
                    default:
                        Console.WriteLine("\n\n Opción no valida \n");
                        break;
                }
            }
            while (opcionMenu != 8);

        }
    }
}
