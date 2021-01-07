using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    public class BridgeTest : ITest
    {
        public void Run()
        {
            // Create RefinedAbstraction
            Customers customers = new Customers("Chicago");

            // Set ConcreteImplementor
            customers.Data = new CustomersData();

            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();
        }
    }
}
