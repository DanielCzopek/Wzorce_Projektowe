using System;
using System.Collections.Generic;

namespace Odwiedzajacy
{


    public interface ICity
    {
        void Accept(IVisitor visitor);
    }


    public class PolishCity : ICity
    {
        /* UZUPEŁNIĆ */

        public PolishCity(string city)
        {
            City = city;
        }

    }


    public class NetherlandCity : ICity
    {

        /* UZUPEŁNIĆ */

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

    }


    public class USACity : ICity
    {

        public string City;

        /* UZUPEŁNIĆ */

    }


    public interface IVisitor
    {

        /* UZUPEŁNIĆ */

        void Visit(USACity element);

    }


    class Visitor : IVisitor
    {

        /* UZUPEŁNIĆ */
        private int USACounter = 0;

        public void Visit(PolishCity element)
        {
            Console.WriteLine($"Odwiedzam {element.City}");
            PolishCounter++;
        }

        /* UZUPEŁNIĆ */

        public void PrintInfo()
        {
            Console.WriteLine($"Byłem w {PolishCounter} Polskich miastach," +
                $" {NetherlandCounter} Holenderskich miastach i {USACounter} miastach USA.");
        }
    }


    public class Client
    {

        public static void ClientCode(List<ICity> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            List<ICity> components = new List<ICity>{
        new PolishCity("Kraków"),
        /* UZUPEŁNIĆ */
        new USACity("Huston"),
      };

            var visitor = new Visitor();
            Client.ClientCode(components, visitor);
            visitor.PrintInfo();
        }
    }

}