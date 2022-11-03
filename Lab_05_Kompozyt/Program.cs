using System;
using System.Collections.Generic;

public interface Kompozyt
{
    //
    void DodajElement(Kompozyt element);
    void UsunElement(Kompozyt element);
}

public class Lisc : Kompozyt
{

    public string nazwa { get; set; }

    public void Renderuj()
    {
        // renderowanie
    }


    // konstruktor

    // 2 brakujące metody których wymaga interfejs

}


public class Wezel : Kompozyt
{

    private List<Kompozyt> Lista = new List<Kompozyt>();

    public string nazwa { get; set; }

    public void Renderuj()
    {
        //rozpoczęcie renderowania

        //foreach item.Renderuj(); 

        //zakończenie renderowania
    }

    // 2 brakujące metody 

}


class MainClass
{
    public static void Main(string[] args)
    {

        //
        //  definicje struktury
        //

        korzen.Renderuj();

    }
}