using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// </summary>
    public abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }
}
