namespace DesignPattern
{
    internal class Singleton
    {
        private static int counter = 0;
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
