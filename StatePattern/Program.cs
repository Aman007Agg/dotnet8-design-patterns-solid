using StatePattern;

class program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        order.Pay(); // Payment Successful.
        order.Ship(); // Order is being shipped.
        order.Deliver(); // Order has been delivered.
    }
}