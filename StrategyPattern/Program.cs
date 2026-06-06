using StrategyPattern;

class Program
{
    static void Main()
    {
        ITravelStrategy strategy = new CarStrategy();
        NavigationService navigation = new NavigationService(strategy);
        navigation.StartJourney();

        strategy = new BikeStrategy();
        navigation = new NavigationService(strategy);
        navigation.StartJourney();

        strategy = new BusStrategy();
        navigation = new NavigationService(strategy);
        navigation.StartJourney();

    }
}