using PrototypePattern;

class Program
{
    static void Main()
    {
        CreditCard card1 = new CreditCard
        {
            CardNumber = "1111",
            UserName = "Aman",
            CreditLimit = 50000
        };
        CreditCard card2 = card1.Clone();
        card2.UserName = "Naman";

        Console.WriteLine(card1.UserName);
        Console.WriteLine(card2.UserName);
    }
}