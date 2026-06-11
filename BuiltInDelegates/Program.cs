using System.ComponentModel;

class Program
{

    /// <summary>
    /// built-in Delegates tYpes - Action, Func, Predicate
    /// </summary>
    static void Main()
    {
        Action<string> action = message =>
        {
            Console.WriteLine($"Hi I am action:{message}");
        };
        action("Hello");

        Func<int, int, int> add = (a, b) =>
        {
            return a + b;
        };
        Console.WriteLine(add(3, 5));

        Func<int, bool> isAdult = age =>
        {
            return age >= 18;
        };
        Console.WriteLine(isAdult(25));

        Func<int, bool> isEven = number => number % 2 == 0;
        Console.WriteLine(isEven(1));

        Predicate<int> isEvenNumber = number => number % 2 == 0;
        Console.Write(isEvenNumber(2));
    }
}