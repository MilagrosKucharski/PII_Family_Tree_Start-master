using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person n1 = new Person(97, "Juan");
            Person n2 = new Person(75, "Pedro");
            Person n3 = new Person(73, "Maximiliano");
            Person n4 = new Person(45, "Constantino");
            Person n5 = new Person(41, "Roberto");
            Person n6 = new Person(39, "Luis");
            Person n7 = new Person(38, "Carlitos");
            Person n8 = new Person(17, "Mariano");


            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            EdadVisitor visitor = new();
            n1.Accept(visitor);
            Console.WriteLine(visitor.Resultado);

            HojaMasGrandeVisitor masGrandeVisitor = new();
            n1.Accept(masGrandeVisitor);
            Console.WriteLine(masGrandeVisitor.Resultado);

            NombreMasLargoVisitor masLargoVisitor = new();
            n1.Accept(masLargoVisitor);
            Console.WriteLine(masLargoVisitor.Resultado);
            //n1.Accept()


            
        }
    }
}
