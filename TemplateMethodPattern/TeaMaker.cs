using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    internal class TeaMaker: BeverageMaker
    {
        protected override void AddIngredients()
        {
            Console.WriteLine("Adding tea leaves...");
        }
    }
}
