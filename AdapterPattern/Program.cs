using AdapterPattern;

class Program
{
    static void Main()
    {
        LegacyPaymentGateway gateway = new LegacyPaymentGateway();
        IPaymentMethod payment = new LegacyPaymentAdapter(gateway);
        payment.Pay(1000);
    }
}