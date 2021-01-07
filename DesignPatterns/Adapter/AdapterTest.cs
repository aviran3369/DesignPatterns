using DesignPatterns.Adapter.Compounds;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class AdapterTest : ITest
    {
        public void Run()
        {
            // Non-adapted chemical compound
            Compound unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
        }
    }
}
