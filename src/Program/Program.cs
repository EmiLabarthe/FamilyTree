using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Messi", 35);
            Person p2 = new Person("Thiago", 12);
            Person p3 = new Person("Mateo", 8);
            Person p4 = new Person("Ciro", 4);
            Person p5 = new Person("Suarez", 36);
            Person p6 = new Person("Delfina", 14);
            Person p7 = new Person("Benjamin", 10);
            Person p8 = new Person("Dios", 50);
            
            Node n1 = new Node(p1);
            Node n2 = new Node(p2);
            Node n3 = new Node(p3);
            Node n4 = new Node(p4);
            Node n5 = new Node(p5);
            Node n6 = new Node(p6);
            Node n7 = new Node(p7);
            Node n8 = new Node(p8);

            //Dios tiene 50 años y es padre de Suarez y Messi
            n8.AddChildren(n1);
            n8.AddChildren(n5);

            //Hijos de Messi
            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n1.AddChildren(n4);

            //Dos hijos de Suarez
            n5.AddChildren(n6);
            n5.AddChildren(n7);

            //Suma de edades
            Visitor visitor = new AgeSum();
            visitor.Visit(n8);
            string Content = null;
            Content = visitor.Content();
            Console.WriteLine($"Las edades suman {Content} años");

            //Determinar edad mayor de hijos de Dios
            Visitor visitor2 = new TheBiggest();
            visitor2.Visit(n8);
            string Content2 = null;
            Content2 = visitor2.Content();
            Console.WriteLine($"El hijo más grande de Dios es {Content2}");

            //Determinar edad mayor de hijos de Messi
            Visitor visitor3 = new TheBiggest();
            visitor3.Visit(n1);
            string Content3 = null;
            Content3 = visitor3.Content();
            Console.WriteLine($"El hijo más grande de Messi es {Content3}");

            //Determinar el nombre más largo
            Visitor visitor4 = new LargestName();
            visitor4.Visit(n8);
            string Content4 = null;
            Content4 = visitor4.Content();
            Console.WriteLine($"{Content4}");
        }
    }
}
