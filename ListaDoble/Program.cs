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
            lista_doble.ImprimirIzquierda();
            Console.WriteLine("Inserto el 3 al final");
            lista_doble.InsertarFinal(3);
            lista_doble.ImprimirIzquierda();
            Console.ReadLine();
            lista_doble.ImprimirDerecha();
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
        public void ImprimirIzquierda()
        {
            Nodo nodo = cabeza;
            while(nodo!= null)
            {
                Console.WriteLine(nodo.Valor+"-");
                nodo = nodo.Siguiente;
            }
        }
        public void ImprimirDerecha()
        {
            Nodo nodo = cola;
            while (nodo != null)
            {
                Console.WriteLine(nodo.Valor + "-");
                nodo = nodo.Anterior;
            }
        }
        public void InsertarFinal (int valor)
        {   //1-Creo nuevo nodo
            Nodo nuevo_nodo = new Nodo(valor);
            if(cabeza==null)
            {
                cabeza = nuevo_nodo;
                cola = nuevo_nodo;
            }
            else
            {
                //2-Como voy a meterlo al final(después de la cola), tengo que "recordar"
                //la antigua_cola:
                Nodo antigua_cola = cola;
                //3-El siguiente a la antigua_cola es 
                antigua_cola.Siguiente = nuevo_nodo;
                //4-El anterior del nuevo nodo es la antigua_cola:
                nuevo_nodo.Anterior = antigua_cola;
                //5-Ahora la cola es el nuevo_nodo:
                cola = nuevo_nodo;

            }
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
        internal int Valor { get => valor;  }
    }
}
