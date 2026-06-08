using FacadePattern;

class Program
{
    static void Main()
    {
        OrderFacade facade = new OrderFacade();
        facade.PlaceOrder("Laptop", 50000);
    }
}