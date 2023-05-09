using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Lista l=new Lista();
            l.print();
            l.Add(9);
            l.Add(5);
            l.Add(2023);
            l.Add(15);
            l.Add(5);
            l.Add(2023);
            l.InsertarDespuesDe(9,10);
            l.print();
            Console.ReadLine();
        }
    }
}
