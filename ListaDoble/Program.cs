using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaDoble lista_doble=new ListaDoble();
            lista_doble.insertarPrincipio(16);
            lista_doble.insertarPrincipio(5);
            lista_doble.insertarPrincipio(2023);
            Console.ReadLine();
        }
    }
    internal class ListaDoble
    {
        Nodo cabeza;
        Nodo cola;

        public ListaDoble()
        {
            this.cabeza = null;
            this.cola = null;
        }
        public void insertarPrincipio(int valor)
        {
            //Creo el nuevo nodo:
            Nodo nuevo_nodo = new Nodo(valor);
            if (cabeza == null)
            {
                cabeza = nuevo_nodo;
                cola= nuevo_nodo;
            }
            else
            {
                //Como quiero insertar por el principìo
                //La nueva cabeza será mi nuevo_nodo
                //Y el siguiente de mi nuevo nodo,
                //será la antigua cabeza
                Nodo antigua_cabeza = cabeza;
                //La cabeza será ahora mi nuevo_nodo:
                cabeza = nuevo_nodo;
                //El siguiente de mi nuevo_nodo, seá la antigua cabeza:
                nuevo_nodo.Siguiente = antigua_cabeza;
                //El anterior de la antigua cabeza, será el nuevo nodo
                antigua_cabeza.Anterior = nuevo_nodo;
            }
        }
    }
    internal class Nodo
    {
        Nodo siguiente, anterior;
        int valor;

        public Nodo( int valor)
        {
            this.Siguiente = null;
            this.Anterior = null;
            this.valor = valor;
        }

        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
        internal Nodo Anterior { get => anterior; set => anterior = value; }
    }
}
