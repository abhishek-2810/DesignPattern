using DesignPattern.FactoryPattern.SimpleFactory.Interface;

namespace DesignPattern.FactoryPattern.SimpleFactory;

internal class TableFan : IFan
{
    public void PowerOn()
    {
        Console.WriteLine("Table Fan Powered ON!");
    }

    public void PowerOff()
    {
        Console.WriteLine("Table Fan Powered OFF!");
    }
}