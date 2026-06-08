using ProxyPattern;

class Program
{
    static void Main()
    {
        IPaymentMethod payment = new PaymentProxy(false);
        //payment.Pay(10000);
        payment.Pay(100000);


    }
}