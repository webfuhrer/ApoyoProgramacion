using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Nodo
    {
        public int valor;
        public Nodo siguiente;
        public Nodo (int valor)
        {
            this.valor = valor;
            siguiente = null;
        }
     
    }
    internal class Lista
    {
        Nodo head;
        public Lista()
        {
            this.head = null;
        }
        public void InsertarDespuesDe(int valor_anterior, int nuevo_valor)
        {
            Nodo nodo_actual = head;
            while(nodo_actual!=null)
            {
                if (nodo_actual.valor== valor_anterior)
                {
                    Nodo nodo_siguiente = nodo_actual.siguiente;
                    Nodo nuevo_nodo = new Nodo(nuevo_valor);
                    nuevo_nodo.siguiente = nodo_siguiente;
                    nodo_actual.siguiente = nuevo_nodo;
                }
                nodo_actual = nodo_actual.siguiente;
            }
        }
        public void Borrar(int n, int num_ocurrencias)
        {
            int num_encontrados = 0;
            if (head == null)
            {
                Console.WriteLine("La lista está vacía, no hay nada que borrar");
            }
            else
            {
                Nodo nodo_actual = head;
                Nodo nodo_anterior = null;
                while(nodo_actual!=null && num_encontrados!=num_ocurrencias)
                {
                    int valor = nodo_actual.valor;
                       
                    if (valor==n)
                    {
                        num_encontrados++;
                        if (nodo_anterior==null)
                        {
                            //Esto es cuando quiero borrar el primero
                            head= head.siguiente;
                        }
                        else
                        {
                            //Borro el nodo (el nodo anterior tiene que apuntar al siguiente).
                            //a->b->c-d Si quiero borrar c, necesito que b apunte a d
                            nodo_anterior.siguiente = nodo_actual.siguiente;
                        }
                        
                    }
                    nodo_anterior = nodo_actual;
                    nodo_actual = nodo_actual.siguiente;
                   
                }
            }

        }
        public void Add(int valor_nodo)
        {
            Nodo nuevo_nodo=new Nodo(valor_nodo);
            if (head==null)
            {
                head = nuevo_nodo;
            }
            else
            {
                Nodo nodo_actual = head;
                while(nodo_actual.siguiente!=null)
                {
                    nodo_actual = nodo_actual.siguiente;
                }
                //El nodo_actual es el último, así que le pongo apuntando al nuevo
                nodo_actual.siguiente = nuevo_nodo;
            }
            
        }
        public void print()
        {
            if (head == null)
            {
                Console.WriteLine("La lista está vacía");

            }
            else
            {
                Nodo nodo_actual = head;
                while(nodo_actual!=null)
                {
                    Console.Write( nodo_actual.valor+", ");
                    nodo_actual= nodo_actual.siguiente;

                }
                //Console.Write(nodo_actual.valor + ", ");
                Console.WriteLine("Has llegado al final de la lista");
            }
        }
    }
}
