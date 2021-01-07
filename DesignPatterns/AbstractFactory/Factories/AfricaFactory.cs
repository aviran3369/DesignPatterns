using DesignPatterns.AbstractFactory.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
