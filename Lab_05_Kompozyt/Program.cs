using System;
using System.Collections.Generic;

public interface Kompozyt
{
    void Renderuj();
    void DodajElement(Kompozyt element);
    void UsunElement(Kompozyt element);
}

public class Lisc : Kompozyt
{
    public string Nazwa { get; set; }

    public Lisc(string nazwa) =>
        Nazwa = nazwa;

    public void Renderuj()
    {
        Console.WriteLine("Liść " + Nazwa + " renderowanie...");
    }

    public void DodajElement(Kompozyt element)
    {
    }

    public void UsunElement(Kompozyt element)
    {
    }
}

public class Wezel : Kompozyt
{
    protected readonly List<Kompozyt> Lista = new List<Kompozyt>();

    public string Nazwa { get; set; }

    public Wezel(string nazwa)
    {
        Nazwa = nazwa;
    }
    public virtual void Renderuj()
    {
        Console.WriteLine("Węzeł " + Nazwa + " rozpoczęcie renderowania");

        foreach (Kompozyt element in Lista)
            element.Renderuj();

        Console.WriteLine("Węzeł " + Nazwa + " zakończenie renderowania");
    }

    public void DodajElement(Kompozyt element) =>
        Lista.Add(element);

    public void UsunElement(Kompozyt element) =>
        Lista.Remove(element);
}

public class Korzen : Wezel
{
    public Korzen() : base("Korzeń")
    {
    }
    
    public override void Renderuj()
    {
        Console.WriteLine(Nazwa + " rozpoczęcie renderowania");

        foreach (Kompozyt element in Lista)
            element.Renderuj();

        Console.WriteLine(Nazwa + " zakończenie renderowania");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Wezel korzen = new Korzen();

        Wezel wezel2 = new Wezel("2");

        wezel2.DodajElement(new Lisc("2.1"));
        wezel2.DodajElement(new Lisc("2.2"));
        wezel2.DodajElement(new Lisc("2.3"));

        Wezel wezel3 = new Wezel("3");

        wezel3.DodajElement(new Lisc("3.1"));
        wezel3.DodajElement(new Lisc("3.2"));

        Wezel wezel33 = new Wezel("3.3");
        
        wezel33.DodajElement(new Lisc("3.3.1"));

        korzen.DodajElement(new Lisc("1.1"));
        korzen.DodajElement(wezel2);
        wezel3.DodajElement(wezel33);
        korzen.DodajElement(wezel3);

        korzen.Renderuj();
    }
}