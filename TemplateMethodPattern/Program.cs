using TemplateMethodPattern;

class program
{
    static void Main()
    {
        Console.WriteLine($"Ingredients Steps for making Tea");
        BeverageMaker teaMaker = new TeaMaker();
        teaMaker.MakeBeverage();


        Console.WriteLine($"\nIngredients Steps for making Coffee");
        BeverageMaker coffeeMaker = new CoffeeMaker();
        coffeeMaker.MakeBeverage();
    }
}