using System;
using System.Collections.Generic;
using System.Text;

namespace S03_ListaDobleCircular
{
    class Lista
    {
        //Crear lista de elementos

        //Recorremos por el primero o por el último
        Nodo primero = new Nodo();//Cabeza de la lista
        Nodo ultimo = new Nodo();//Último de la lista

        //Constructor de la clase
        public Lista()
        {
            //Mientras no haya ningun nodo
            primero = null;
            ultimo = null;
        }
        //Métodos para gesstionar los nodos
        //Ingresar nodos
        public void InsertarNodo()
        {
            Nodo nuevo = new Nodo();
            Console.WriteLine("\n Ingresa dato para el nuevo nodo:");
            nuevo.Dato = int.Parse(Console.ReadLine());//20--40
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
                primero.Siguiente = primero;
                primero.Atras = ultimo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Atras = ultimo;
                nuevo.Siguiente = primero;
                ultimo = nuevo;
                primero.Atras = ultimo;
            }
            Console.WriteLine("\nNodo ingresado correctamente\n");
        }
        public void DesplegarListaPU()
        {
            Nodo Actual = new Nodo();
            Actual = primero;
            if(Actual != null)
            {
                do
                {
                    Console.WriteLine(" " + Actual.Dato);
                    Actual = Actual.Siguiente;
                } while (Actual != primero);
            }
            else
            {
                Console.WriteLine("\nLista vacia\n");
            }
        }
        public void DesplegarListaUP()
        {
            Nodo Actual = new Nodo();
            Actual = ultimo;
            if (Actual != null)
            {
                do
                {
                    Console.WriteLine(" " + Actual.Dato);
                    Actual = Actual.Atras;
                } while (Actual != ultimo);
            }
            else
            {
                Console.WriteLine("\nLista vacia\n");
            }
        }
        public void BuscarNodo()
        {
            Nodo Actual = new Nodo();
            Actual = primero;
            bool encontrado = false;
            Console.WriteLine("\nIngrese dato a buscar\n");
            int nodoBuscado = int.Parse(Console.ReadLine());
            if (Actual != null)
            {
                do
                {
                    if (Actual.Dato == nodoBuscado)
                    {
                        Console.WriteLine("\nNodo con el dato ({0}) encontrado ", Actual.Dato);
                        encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                } while (Actual != primero && encontrado != true);
                if(!encontrado)
                {
                    Console.WriteLine("\nNodo no encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\nLista vacia\n");
            }
        }
    }
}
