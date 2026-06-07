using AbstractFactoryMethod;

class Program
{
    static void Main()
    {
        IPaymentFactory factory = new CreditCardFactory();
        IPaymentMethod payment = factory.CreatePaymentMethod();
        IReceipt receipt = factory.CreateReceipt();
        payment.Pay(100.00m);
        receipt.GenerateReceipt();


        factory = new UPIFactory();
        payment = factory.CreatePaymentMethod();
        receipt = factory.CreateReceipt();
        payment.Pay(300.00m);
        receipt.GenerateReceipt();

    }
}