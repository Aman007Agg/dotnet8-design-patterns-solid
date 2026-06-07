using FactoryMethod;

class Program
{
    static void Main()
    {
        IPaymentFactory factory;
        factory = new CreditCardFactory();
        IPaymentMethod payment = factory.CreatePaymentMethod();
        payment.Pay(1000);
        Console.WriteLine("Payment processed using Credit Card.");

        factory = new DebitCardFactory();
        payment = factory.CreatePaymentMethod();
        payment.Pay(500);
        Console.WriteLine("Payment processed using Debit Card.");

        factory = new UPIFactory();
        payment = factory.CreatePaymentMethod();
        payment.Pay(200);
        Console.WriteLine("Payment processed using UPI.");

        factory = new WalletFactory();
        payment = factory.CreatePaymentMethod();
        payment.Pay(300);


    }
}