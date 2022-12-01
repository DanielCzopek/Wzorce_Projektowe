using System;

abstract class Zawodnik
{

    KopniecieTyp kopniecieTyp;
    SkokTyp skokTyp;

    public Zawodnik(KopniecieTyp kopniecieTyp, SkokTyp skokTyp)
    {
        /* UZUPEŁNIĆ */
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
    }

    public void ustawSkokTyp(SkokTyp skokTyp)
    {
        /* UZUPEŁNIĆ */
    }

    /* UZUPEŁNIĆ */

}


interface KopniecieTyp
{

    void kopniecie();

}


class KopniecieLod : KopniecieTyp
{

    /* UZUPEŁNIĆ */

}

//
//
//

interface SkokTyp
{

    void skok();

}


//
//
//

//
//
//


class SubZero : Zawodnik
{

    /* UZUPEŁNIĆ - KONSTRUKTOR */


    override public void przedstaw()
    {
        Console.WriteLine("Jestem Sub-Zero!");
    }

}


//
//
//
//
//



class MainClass
{

    public static void Main(string[] args)
    {
        Console.WriteLine("-- Mortal Kombat --");
        Console.WriteLine();

        //
        //
        KopniecieTyp kopniecieLod = new KopniecieLod();
        KopniecieTyp kopniecieOgien = new KopniecieOgien();


        Zawodnik subZero = new SubZero(kopniecieLod, krotkiSkok);
        subZero.przedstaw();
        subZero.uderzenie();
        subZero.kopniecie();
        subZero.skok();
        subZero.ustawSkokTyp(dlugiSkok);
        subZero.skok();

        //
        //
        //

    }

}