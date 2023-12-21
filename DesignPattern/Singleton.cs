namespace DesignPattern
{
    // Sealed Class cause this class should not be inherited by any nested class as well else it will result in multiple instance creation of Singleton class
    internal sealed class Singleton
    {
        private static int counter = 0;

        // private variable to store singleton instance of class
        private static Singleton? instance = null;

        private Singleton()
        {
            counter++;
            Console.WriteLine($"Object Count : {counter}");
        }

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }
        }
        public void PrintMessage(string message) => Console.WriteLine(message);
    }
}
