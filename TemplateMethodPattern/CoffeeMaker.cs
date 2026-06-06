using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    internal class CoffeeMaker: BeverageMaker
    {
        protected override void AddIngredients()
        {
            Console.WriteLine("Adding coffee grounds...");
        }
    }
}
