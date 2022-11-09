using System;

namespace Library;

public class LargestName: Visitor
{
    public int LongName = 0;
    public Person LargestPersonName {get; set;}
    public override void Visit(Node node)
    {
        node.Person.Accept(this);
        foreach(Node one in node.Children)
        {
           one.Accept(this);
        }
    }
    public override void Visit(Person person)
    {
        if(person.Name.Length > LongName)
        {
            LongName = person.Name.Length;
            LargestPersonName = person;
            this.ContentBuilder.Clear();
            this.ContentBuilder.Append($"El nombre más largo lo tiene {LargestPersonName.Name}");
        }
    }
}