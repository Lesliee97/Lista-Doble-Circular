using System;
using System.Collections.Generic;
using System.Text;

namespace S03_ListaDobleCircular
{
    class Nodo
    {
        private int dato;
        private Nodo siguiente;
        private Nodo atras;

        //Encapsulamiento
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        //Apuntadores
        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Nodo Atras
        {
            get { return atras; }
            set { atras = value; }
        }
    }
}
