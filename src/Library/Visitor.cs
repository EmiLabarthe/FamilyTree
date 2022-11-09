using System;
using System.Text;

namespace Library;

public abstract class Visitor
{
    public StringBuilder ContentBuilder {get;} = new StringBuilder();
    public string Content()
    {
        return this.ContentBuilder.ToString();
    }
    public abstract void Visit(Node node);
    public abstract void Visit(Person person);
}