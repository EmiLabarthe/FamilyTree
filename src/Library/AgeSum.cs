using System;
using System.Text;

namespace Library;

public class AgeSum: Visitor
{
    public int SumOfAge = 0;
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
        SumOfAge = SumOfAge + person.Age;
        this.ContentBuilder.Clear();
        this.ContentBuilder.Append(SumOfAge);
    }
}