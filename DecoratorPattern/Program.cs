using DecoratorPattern;

class Program
{
    static void Main()
    {
       IPaymentMethod payment = new CreditCard();
        payment = new LoggingDecorator(payment);
        payment = new ValidationDecorator(payment);
        payment.Pay(1000);
    }
}