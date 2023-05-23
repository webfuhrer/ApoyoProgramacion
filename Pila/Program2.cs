using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pila<string> p =new Pila<string>();
            p.Apilar("Manolo");
            p.Apilar("Pepe");
            p.Apilar("Jose");
            p.Imprimir();
            p.Desapilar();
            Console.WriteLine("Después de desapilar");
            p.Imprimir();
            Console.ReadLine();
        }
    }
    internal class Pila<T>
    {
        Nodo<T> ultimo;
        public void Apilar(T numero)
        {
            //1-Creo el nuevo nodo:
            Nodo<T> nuevo_nodo = new Nodo<T>(numero);
            if (ultimo==null)
            {
                ultimo = nuevo_nodo;
            }
            else
            {
                //Ya hay nodos en la pila
                //2-Memorizao quien ere el último
                //Nodo antiguo_ultimo = ultimo;
                nuevo_nodo.SetSiguiente(ultimo);
                //3-El ultimo lo apunto al nuevo_nodo
                ultimo = nuevo_nodo;
                //4-El que acabo de meter tiene que apuntar al que antes era el último
               
            }
        }
        public void Desapilar()
        {
            if (ultimo==null)
            {

            }
            else
            {

                ultimo = ultimo.GetSiguiente();
            }
        }
        public void Imprimir()
        {
            Nodo<T> nodo = ultimo;
        while (nodo!=null)
            {
                Console.WriteLine(nodo.GetValor());
                nodo = nodo.GetSiguiente();
            }
        }
    }
    
    internal class Nodo<T>
    {
        T valor;
        Nodo<T> siguiente;

        public Nodo(T valor)
        {
            this.valor = valor;
            this.siguiente = null;
        }

        public T GetValor()
        {
            return valor;
        }

        public void SetValor(T value)
        {
            valor = value;
        }

        internal Nodo<T> GetSiguiente()
        {
            return siguiente;
        }

        internal void SetSiguiente(Nodo<T> value)
        {
            siguiente = value;
        }
    }
}
