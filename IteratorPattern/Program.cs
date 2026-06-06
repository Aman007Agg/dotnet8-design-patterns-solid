using IteratorPattern;

class program
{
    static void Main()
    {
        CardCollection card = new CardCollection();
        card.AddCard("Credit Card");
        card.AddCard("Debit Card");
        card.AddCard("Prepaid Card");
        card.AddCard("Gift Card");

        CardIterator iterator = new CardIterator(card);

        while(iterator.HasNext())
        {
            Console.WriteLine(iterator.Next());
        }
    }
}