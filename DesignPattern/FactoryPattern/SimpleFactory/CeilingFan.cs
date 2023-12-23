using DesignPattern.FactoryPattern.SimpleFactory.Interface;

namespace DesignPattern.FactoryPattern.SimpleFactory;

internal class CeilingFan : IFan
{
    public void PowerOn()
    {
        Console.WriteLine("Ceiling Fan Powered ON!");
    }

    public void PowerOff()
    {
        Console.WriteLine("Ceiling Fan Powered OFF!");
    }
}