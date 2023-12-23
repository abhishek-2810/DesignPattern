using DesignPattern.FactoryPattern.SimpleFactory.Enum;
using DesignPattern.FactoryPattern.SimpleFactory;
using DesignPattern.SingletonPattern;
﻿namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Singleton
            // SingleThread Execution
            SingletonObjectCallFromClassA();
            SingletonObjectCallFromClassB();

            // ParallelThread Execution
            Parallel.Invoke(
                SingletonObjectCallFromClassA,
                SingletonObjectCallFromClassB
            );

            // Simple Factory
            var simpleFactory = new SimpleFactory();
            var ceilingFan = simpleFactory.CreateFan(Fan.CeilingFan);
            ceilingFan.PowerOn();
            ceilingFan.PowerOff();
        }

        private static void SingletonObjectCallFromClassB()
        {
            var singletonObjectFomClassB = Singleton.GetInstance;
            singletonObjectFomClassB.PrintMessage("From Class B");
        }

        private static void SingletonObjectCallFromClassA()
        {
            var singletonObjectFomClassA = Singleton.GetInstance;
            singletonObjectFomClassA.PrintMessage("From Class A");
        }
    }
}
