using design_patterns;

class Program
{
    static void Main()
    {
        //Card card = new Card("1234-5678-9012-3456", "John Doe");
        Card card_CreditCard = new CreditCard("1111-2222-3333-4444", "Aman Agrawal", 50000);
        Card card_DebitCard = new DebitCard("5555-6666-7777-8888", "Jane Smith", 10000);

        CreditCard creditCard = new CreditCard("1111-2222-3333-5555", "Naman Agrawal", 50000);

        DebitCard debitCard = new DebitCard("6661-6666-7777-8888", "Steve Smith", 10000);

        //card.DisplayCardInfo();

        creditCard.DisplayCardInfo();
        creditCard.ShowCreditLimit();
        debitCard.DisplayCardInfo();
        debitCard.ShowBalance();

        card_CreditCard.DisplayCardInfo();
        card_DebitCard.DisplayCardInfo();

        card_CreditCard.Pay(10000);
        card_DebitCard.Pay(5000);

        //card.Pay(1000);
        creditCard.Pay(10000);
        debitCard.Pay(5000);

        List<Card> cards = new List<Card>();
        cards.Add(new CreditCard("2222-3333-4444-5555", "Kamal Agrawal", 250000));
        cards.Add(new DebitCard("9999-8888-7777-8888", "Anjum Agrawal", 15000));

        foreach (Card card in cards)
        {
            card.DisplayCardInfo();
            card.Pay(2000);
        }


        List<IPaymentMethod> paymentMethods = new List<IPaymentMethod>();
        paymentMethods.Add(new CreditCard("3333-4444-5555-6666", "Rohan Agrawal", 75000));
        paymentMethods.Add(new DebitCard("7777-8888-9999-0000", "Sita Smith", 20000));
        paymentMethods.Add(new UPI("aman@oksbi"));
        paymentMethods.Add(new Wallet(4000));

        foreach (IPaymentMethod paymentMethod in paymentMethods)
        {
            paymentMethod.Pay(1500);
        }


        //PaymentService paymentService = new PaymentService();
        //paymentService.AddPaymentMethod("CC1", new CreditCard("4444-5555-6666-7777", "Rohit Agrawal", 100000));
        //paymentService.AddPaymentMethod("DB1", new DebitCard("8888-9999-0000-1111", "Sita Smith Jones", 30000));

        //paymentService.MakePayment("CC1", 2000);
        //paymentService.MakePayment("DB1", 3000);

        IPaymentRepository inMemoryRepository = new InMemoryPaymentRepository();
        ITransactionRepository inMemoryTransactionRepository = new InMemoryTransactionRepository();
        PaymentService paymentService = new PaymentService(inMemoryRepository, inMemoryTransactionRepository);


    }
}