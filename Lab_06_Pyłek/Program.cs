using System;
using System.Collections.Generic;

namespace Pylek
{
    public enum Type { LargeTree, Bush, Tree } // czy to wszystkie typy?

    public interface Plant{
        void Display(int positionX, int positionY);
    }

   

    public class Bush : Plant
    {
        public String Texture { get; set; }

        public void Display(int x, int y)
        {
            Console.WriteLine($"Krzak (plik \"{Texture}\") znajduje się na pozycji {x},{y}\n");
        }
    }

    public class Tree : Plant
    {
        public String Texture { get; set; }

        public void Display(int x, int y)
        {
            Console.WriteLine($"Normalne drzewo (plik \"{Texture}\") znajduje się na pozycji {x},{y}\n");
        }
    }
    public class LargeTree : Plant
    {
        // pole na nazwę pliku?
        public String Texture { get; set; }

        public void Display(int x, int y)
        {
            Console.WriteLine($"Duże drzewo (plik \"{Texture}\") znajduje się na pozycji {x},{y}\n");
        }
    }

    // klasy roślinności
    public class PlantFactory
    {
        private Dictionary<Type, Plant> Plants = new Dictionary<Type, Plant>();

        public Plant GetPlant(Type type)
        {
            // deklaracja zmiennej plant (bez wartości)
            Plant plant;

            if (Plants.ContainsKey(type))
            {
                // już był, więc ze słownika i komunikat
                plant = Plants[type];
                Console.WriteLine($"Wykorzystuję istniejący obiekt");
            }
            else
            {
                // a jeśli nie było takiego obiektu, to trzeba utworzyć - switch?
                // i dodać do cache'u
                switch (type)
                {
                    case Type.LargeTree:
                        plant = new LargeTree() { Texture = "large_tree.png" };
                        break;
                    case Type.Bush:
                        plant = new Bush() { Texture = "bush.png" };
                        break;
                    case Type.Tree:
                        plant = new Tree() { Texture = "tree.png" };
                        break;
                    default:
                        plant = null;
                        break;
                }
                Plants.Add(type, plant);
                Console.WriteLine("Tworzę nowy obiekt typu {0}", type);
            }

            // obiekt oczywiście trzeba zwrócić z fabryki
            return plant;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var factory = new PlantFactory();

            var plant = factory.GetPlant(Type.Tree);
            plant.Display(0, 0);
            plant = factory.GetPlant(Type.LargeTree);
            plant.Display(0, 7);
            plant = factory.GetPlant(Type.Tree);
            plant.Display(3, 16);
            plant = factory.GetPlant(Type.Bush);
            plant.Display(10, 9);
            plant = factory.GetPlant(Type.Tree);
            plant.Display(7, 7);
            plant = factory.GetPlant(Type.LargeTree);
            plant.Display(20, 0);
            plant = factory.GetPlant(Type.Tree);
            plant.Display(3, 28);
            plant = factory.GetPlant(Type.Bush);
            plant.Display(1, 5);
            plant = factory.GetPlant(Type.Tree);
            plant.Display(8, 8);
            // jak zwykle czegoś brakuje...
        }
    }
}