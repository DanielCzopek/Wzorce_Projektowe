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
        public string City;

        public PolishCity(string city)
        {
            City = city;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }


    public class NetherlandCity : ICity
    {

        /* UZUPEŁNIĆ */
        public string City;
        public NetherlandCity(string city)
        {
            City = city;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

    }


    public class USACity : ICity
    {

        public string City;

        /* UZUPEŁNIĆ */
        public USACity(string city)
        {
            City = city;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }


    public interface IVisitor
    {

        /* UZUPEŁNIĆ */

        void Visit(USACity element);
        void Visit(NetherlandCity element);
        void Visit(PolishCity element);


    }


    class Visitor : IVisitor
    {

        /* UZUPEŁNIĆ */
        private int USACounter = 0;
        private int PolishCounter = 0;
        private int NetherlandCounter = 0;

        public void Visit(PolishCity element)
        {
            Console.WriteLine($"Odwiedzam {element.City}");
            PolishCounter++;
        }
        public void Visit(NetherlandCity element)
        {
            Console.WriteLine($"Odwiedzam {element.City}");
            NetherlandCounter++;
        }

        public void Visit(USACity element)
        {
            Console.WriteLine($"Odwiedzam {element.City}");
            USACounter++;
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
                new PolishCity("Szczecin"),
                new PolishCity("Rzeszów"),
                new PolishCity("Gdańsk"),
                new PolishCity("Katowice"),
                new NetherlandCity("Maastricht"),
                new NetherlandCity("Amsterdam"),
                new USACity("Nowy Jork"),
                new USACity("Waszyngton"),
                new USACity("Boston"),
                new USACity("Princeton"),
                new USACity("Seattle"),
                new USACity("Chicago"),
        new USACity("Huston"),
      };

            var visitor = new Visitor();
            Client.ClientCode(components, visitor);
            visitor.PrintInfo();
        }
    }

}