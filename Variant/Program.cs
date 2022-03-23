using System;

namespace Delegate_n_Variant
{
    class Program
    {
        class Animal {}       // Base
        class Dog : Animal {} // Child
        
        interface ICovarianza<out T>{}          //      out -> covarianza
        interface IContravarianza<in T> { }     //      in -> Contravarianza
        interface IInvarianza<T> {}             // default -> Invarianza
        //Variant : Co-Contra Variance
        class Variant<T> : ICovarianza<T>, IContravarianza<T>, IInvarianza<T>
        {}
        
        static void Main(string[] args)
        {
            ICovarianza<Animal>  c1 = new Variant<Dog>();       // Animal <- Dog
            IContravarianza<Dog> c2 = new Variant<Animal>();    // Dog    <- Animal 
            IInvarianza<Animal>  c3 = new Variant<Animal>();
        }
    }
}