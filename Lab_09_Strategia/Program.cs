using System;

abstract class Zawodnik
{

    KopniecieTyp kopniecieTyp;
    SkokTyp skokTyp;

    public Zawodnik(KopniecieTyp kopniecieTyp, SkokTyp skokTyp)
    {
        this.kopniecieTyp = kopniecieTyp;
        this.skokTyp = skokTyp;
        /* UZUPEŁNIĆ */


    }

    public virtual void przedstaw()
    {

    }


    public void uderzenie()
    {
        Console.WriteLine("Uderzenie");
    }

    public void kopniecie()
    {
        kopniecieTyp.kopniecie();
    }

    public void skok()
    {
        skokTyp.skok();
    }

    public void ustawKopniecieTyp(KopniecieTyp kopniecieTyp)
    {
        /* UZUPEŁNIĆ */
        this.kopniecieTyp = kopniecieTyp;
    }

    public void ustawSkokTyp(SkokTyp skokTyp)
    {
        /* UZUPEŁNIĆ */
        this.skokTyp = skokTyp;
    }

    /* UZUPEŁNIĆ */

}


interface KopniecieTyp
{

    void kopniecie();

}


class KopniecieLod : KopniecieTyp
{
    public void kopniecie()
    {
        Console.WriteLine("Kopniecie lodowe");
    }

    /* UZUPEŁNIĆ */

}

class KopniecieOgien : KopniecieTyp
{
    public void kopniecie()
    {
        Console.WriteLine("Kopniecie z ogniem");
    }
}

//
//
//

interface SkokTyp
{

    void skok();

}

class KrotkiSkok : SkokTyp
{
    public void skok()
    {
        Console.WriteLine("Krotki skok");
    }
}
class DlugiSkok : SkokTyp
{
    public void skok()
    {
        Console.WriteLine("Dlugi skok");
    }
}


//
//
//

//
//
//

class SubZero : Zawodnik
{

    public SubZero(KopniecieTyp kopniecieTyp, SkokTyp skokTyp) : base(kopniecieTyp, skokTyp)
    {
    }


    override public void przedstaw()
    {
        Console.WriteLine("Jestem Sub-Zero!");
    }

}


class Scorpion : Zawodnik
{

    public Scorpion(KopniecieTyp kopniecieTyp, SkokTyp skokTyp) : base(kopniecieTyp, skokTyp)
    {
    }


    override public void przedstaw()
    {
        Console.WriteLine("Jestem Scorpion!");
    }

}



class MainClass
{

    public static void Main(string[] args)
    {
        Console.WriteLine("-- Mortal Kombat --");
        Console.WriteLine();

        SkokTyp krotkiSkok = new KrotkiSkok();
        SkokTyp dlugiSkok = new DlugiSkok();
        KopniecieTyp kopniecieLod = new KopniecieLod();
        KopniecieTyp kopniecieOgien = new KopniecieOgien();


        Zawodnik subZero = new SubZero(kopniecieLod, krotkiSkok);
        subZero.przedstaw();
        subZero.uderzenie();
        subZero.kopniecie();
        subZero.skok();
        subZero.ustawSkokTyp(dlugiSkok);
        subZero.skok();
        Console.WriteLine();
        Zawodnik scorpion = new Scorpion(kopniecieOgien, dlugiSkok);
        scorpion.przedstaw();
        scorpion.uderzenie();
        scorpion.kopniecie();
        scorpion.ustawKopniecieTyp(kopniecieLod);
        scorpion.kopniecie();
        scorpion.skok();

    }

}