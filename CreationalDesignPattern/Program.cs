using System;
using System.Collections.Generic;
using CreationalDesignPatternBuilder;

namespace CreationalDesignPatternBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Pattern Builder");

            var superBuilder = new SuperCarBuilder();
            var notSoSuperBuilder = new NotSoSuperCarBuilder();

            // call Director Class
            var factory = new CarFactory();

            // call the builder Class
            var builders = new List<CarBuilder> {superBuilder, notSoSuperBuilder};

            // iterate loop 
            foreach (var builder in builders)
            {
                var c = factory.Build(builder);
                Console.WriteLine($"The Car requested by" + 
                                  $"{builder.GetType().Name}" +
                                  $"\n----------------------------" +
                                  $"\n Horse Power:{c.HorsePower}" +
                                  $"\n Impressive Features:{c.MostImpressiveFeature}" +
                                  $"\n Top Speed:{c.TopSpeedMph}"
                                  );
            }

            Console.ReadKey();
        }
    }
}
