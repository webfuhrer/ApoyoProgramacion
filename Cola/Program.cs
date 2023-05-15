using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Cola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cola c = new Cola();
            c.Encolar(15);
            c.Encolar(5);
            c.Encolar(2023);
            c.Borrar();
            Console.ReadLine();

        }
    }
    internal class Nodo
    {
        int valor;
        Nodo siguiente;

        public Nodo(int valor)
        {
            this.valor = valor;
            this.Siguiente = null;
        }

        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
    }
    internal class Cola
    {
        Nodo cabeza;
     public Cola()
        {
            this.cabeza = null;
        }
    public void Encolar(int valor)
        {
            if (cabeza== null)
            {
                Nodo nodo = new Nodo(valor);
                cabeza = nodo;
            }
            else
            {
                Nodo n = cabeza;
                while(n.Siguiente!=null)
                {
                    n = n.Siguiente;
                }
                //Cuando salga del bucle
                //es porque he llegado al último nodo (n.Siguiente es null)
                //Así que pongo mi nuevo nodo como siguiente
                //del último.
                Nodo nuevo_nodo = new Nodo(valor);
                n.Siguiente= nuevo_nodo;
            }
        }
    public void Borrar()
        {
            //En las colas, se borra el primero. Para ello
            //se pone la cabeza al siguiente
            if (cabeza== null)
            {
                //Nada que hacer
            }
            else
            {
                cabeza = cabeza.Siguiente;
            }
            

           
        }
    }
}
