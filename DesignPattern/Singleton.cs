namespace DesignPattern
{
    // Sealed Class cause this class should not be inherited by any nested class as well else it will result in multiple instance creation of Singleton class
    internal sealed class Singleton
    {
        private static int counter = 0;

        // private variable to store singleton instance of class
        private static Singleton? instance = null;

        private static readonly object lockObject = new object();

        // Constructor should be private as we need to restrict instance creation (for other classes)
        private Singleton()
        {
            counter++;
            Console.WriteLine($"Object Count : {counter}");
        }

        // One Property will be needed which will be responsible to provide class instance
        // this is also static as if we'll not do that then we won't be able to access this property without static
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    // lock one thread and then create instance by then other thread will wait
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }

                return instance;
            }
        }
        public void PrintMessage(string message) => Console.WriteLine(message);
    }
}
