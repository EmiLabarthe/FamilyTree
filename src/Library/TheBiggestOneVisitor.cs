using System;

namespace Library;

public class TheBiggestOneVisitor: Visitor
{
    public int biggestAge = 0;
    public Person biggest {get; set;}
    public override void Visit(Node node)
    {
        foreach(Node one in node.Children)
        {
           one.Person.Accept(this);
        }
    }
    public override void Visit(Person person)
    {
         if(person.Age > biggestAge)
            {
                biggestAge = person.Age;
                biggest = person;
                this.ContentBuilder.Clear();
                this.ContentBuilder.Append($"{person.Name} con {person.Age} años");
            }
    }
}