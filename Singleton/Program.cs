using Singleton;

class program
{
    static void Main()
    {
        Logger logger = Logger.Instance;
        logger.Log("Application Started");
        Logger logger2 = Logger.Instance;
        logger.Log("Check Logs");
        Console.WriteLine(ReferenceEquals(logger, logger2));
    }
}