using System;

namespace Delegate
{
    class Program
    {
        //signature  <output> Nombre(<input> s);
        delegate string Delegado1(string s);
        delegate T DelegadoGenerico<T>(string s);
        
        static void Main(string[] args)
        {
            Delegado1 n = Imprimir;
            Delegado1 n2 = n;
            Delegado1 n3 = n2;
            
            //Imprimir("hola mundo");
            n2("hola mundo");
        }
        
        static string Imprimir(string s)  //Signature:  <output> Imprimir(<input> s);
        {
            Console.WriteLine(s);
            return s;
        }
    }
}