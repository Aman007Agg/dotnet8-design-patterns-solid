using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Started");
        await GetDataAsync();
        Console.WriteLine("Finished");
    }

    static async Task GetDataAsync()
    {
        Console.WriteLine("Waiting..");
        await Task.Delay(3000);
        Console.WriteLine("Completed");

    }
}