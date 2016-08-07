using System;

class Client
{
    static void Main(string[] args)
    {
        // Creating the adaptee
        var adaptee = new Adaptee();

        // Adapting the adaptee to ITarget
        ITarget target = new ObjectAdapter(adaptee);

        // Using ITarget Interface
        Console.WriteLine("Calling ITarget.Request()");
        target.Request();
    }
}

// needed target interface
interface ITarget { void Request(); }

// unchangeable adaptee class
class Adaptee
{
    public void Operation() { Console.WriteLine("Adaptee.Operation() called"); }
}

// adapter
class ObjectAdapter : ITarget
{
    Adaptee _adaptee;
    public ObjectAdapter(Adaptee adaptee) { _adaptee = adaptee; }
    public void Request()
    {
        Console.WriteLine("ObjectAdapter.Request() called");
        _adaptee.Operation();
    }
}
