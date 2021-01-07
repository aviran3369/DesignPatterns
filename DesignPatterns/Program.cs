using DesignPatterns.AbstractFactory;
using DesignPatterns.Adapter;
using DesignPatterns.Bridge;
using DesignPatterns.Builder;
using DesignPatterns.Composite;
using DesignPatterns.Decorator;
using DesignPatterns.Factory;
using DesignPatterns.Prototype;
using DesignPatterns.Singleton;
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    enum DPTest
    {
        AbstractFactory,
        Builder,
        Factory,
        Prototype,
        Singleton,
        Adapter,
        Bridge,
        Composite,
        Decorator
    }

    class Program
    {
        private static readonly Dictionary<DPTest, ITest> Tests;
        static Program()
        {
            Tests = new Dictionary<DPTest, ITest>();
            Tests.Add(DPTest.AbstractFactory, new AbstractFactoryTest());
            Tests.Add(DPTest.Builder, new BuilderTest());
            Tests.Add(DPTest.Factory, new FactoryTest());
            Tests.Add(DPTest.Prototype, new PrototypeTest());
            Tests.Add(DPTest.Singleton, new SingletonTest());
            Tests.Add(DPTest.Adapter, new AdapterTest());
            Tests.Add(DPTest.Bridge, new BridgeTest());
            Tests.Add(DPTest.Composite, new CompositeTest());
            Tests.Add(DPTest.Decorator, new DecoratorTest());
        }

        static void Main(string[] args)
        {
            // Tests[DPTest.AbstractFactory].Run();
            // Tests[DPTest.Builder].Run();
            // Tests[DPTest.Factory].Run();
            // Tests[DPTest.Prototype].Run();
            // Tests[DPTest.Singleton].Run();
            // Tests[DPTest.Adapter].Run();
            // Tests[DPTest.Bridge].Run();
            // Tests[DPTest.Composite].Run();
            Tests[DPTest.Decorator].Run();

            Console.ReadKey();
        }
    }
}
