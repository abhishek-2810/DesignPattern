using DesignPattern.FactoryPattern.SimpleFactory.Interface;

namespace DesignPattern.FactoryPattern.SimpleFactory;

internal class ExhaustFan : IFan
{
    public void PowerOn()
    {
        Console.WriteLine("Exhaust Fan Powered ON!");
    }

    public void PowerOff()
    {
        Console.WriteLine("Exhaust Fan Powered OFF!");
    }
}