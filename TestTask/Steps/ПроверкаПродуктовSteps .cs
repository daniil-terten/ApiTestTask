using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestTask.Models;

namespace TestTask.Feature
{
    [Binding]
    public class ПроверкаПродуктовSteps
    {
        public Product[] products;

        [When(@"получены все продукты")]
        public void ЕслиПолученыВсеПродукты()
        {
            products = GlobalVariables.reqresClient.GetProducts();
        }
        
        [Then(@"год каждого больше или равно (.*)")]
        public void ТоГодКаждогоБольшеИлиРавно(int p0)
        {
            foreach (var p in products)
            {
                if(p.Year < 2000)
                {
                    Assert.Fail("Есть продукты год которых ниже 2000");
                }
            }
        }
    }
}
