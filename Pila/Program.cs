using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pila p= new Pila();
            p.Desapilar();
            p.Apilar(16);
            p.Apilar(5);
            p.Apilar(2023);
            Console.WriteLine("ANTES DE DESAPILAR");
            p.Imprimir();
            p.Desapilar();
            Console.WriteLine("DESPUÉS DE DESAPILAR");
            p.Imprimir();

            Console.ReadLine();
        }
    }
    internal class Pila
    {
        Nodo cabeza;

        public Pila()
        {
            this.cabeza = null;
        }
        public void Apilar(int valor)
        {
            //1-Creo un nuevo nodo
            Nodo nuevo_nodo = new Nodo(valor);
            //Si la pila está vacía, la cabeza debe apuntar
            //al nuevo nodo

            if (cabeza == null)
            {
                cabeza = nuevo_nodo;
            }
            else
            {
                
                //Meto en una variable la antigua cabeza para
                //no perder la referencia, porque si la pierdo, mis pilas 
                //solo tendrán un elemento
                Nodo antigua_cabeza=cabeza;
                //Apunto la cabeza al nuevo nodo
                cabeza = nuevo_nodo;
                //El nuevo nodo apunta a la antigua cabeza
                nuevo_nodo.Siguiente = antigua_cabeza;
            }
        }
        public void Desapilar()
        {
            //Desapilar consiste en hacer que la cabeza sea el siguiente 
            //del actual
            if (cabeza==null)
            {
                Console.WriteLine("La pila está vacía");
            }
            else
            {
                Console.WriteLine("Desapilando el "+cabeza.Valor);
                cabeza = cabeza.Siguiente;

            }
        }
        public void Imprimir()
        {
            Nodo nodo = cabeza;
            while(nodo!=null)
            {
                int valor = nodo.Valor;
                Console.WriteLine("El valor es: " + valor);
                nodo = nodo.Siguiente;
            }
        }
    }
    internal class Nodo
    {
        int valor;
        Nodo siguiente;

        public Nodo(int valor)
        {
            this.valor = valor;
            this.siguiente = null;
        }

        public int Valor { get => valor; set => valor = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
    }
}
