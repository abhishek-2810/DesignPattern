namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var singletonObjectFomClassA = Singleton.GetInstance;
            singletonObjectFomClassA.PrintMessage("From Class A");

            var singletonObjectFomClassB = Singleton.GetInstance;
            singletonObjectFomClassB.PrintMessage("From Class B");
        }
    }
}
