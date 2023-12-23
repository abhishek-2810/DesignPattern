using DesignPattern.FactoryPattern.SimpleFactory.Enum;
using DesignPattern.FactoryPattern.SimpleFactory.Interface;

namespace DesignPattern.FactoryPattern.SimpleFactory;

internal class SimpleFactory
{
    public IFan CreateFan(Fan fanType)
    {
        return fanType switch
        {
            Fan.TableFan => new TableFan(),
            Fan.CeilingFan => new CeilingFan(),
            Fan.ExhaustFan => new ExhaustFan(),
            _ => new TableFan()
        };
    }
}