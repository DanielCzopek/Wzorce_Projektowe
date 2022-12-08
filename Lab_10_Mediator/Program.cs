using System;
using System.Collections.Generic;


//
//
//

public class Mediator : IMediator
{
    List<IUzytkownik> uzytkownicy;

    public Mediator()
    {
        uzytkownicy = new List<IUzytkownik>();
    }

    public void DodajUzytkownika(IUzytkownik uzytkownik)
    {
        //
        //
    }

    public void WyslijWiadomosc(string wiadomosc, IUzytkownik nadawca)
    {
        //
        //
        //
    }
}

//
//
//

public class Dev : IUzytkownik
{
    string login;
    IMediator Mediator;

    public Dev(IMediator Mediator, string login)
    {
        this.login = login;
        this.Mediator = Mediator;
    }

    public void WyslijWiadomosc(string wiadomosc)
    {
        Mediator.WyslijWiadomosc(wiadomosc, this);
    }

    public void OdbierzWiadomosc(string wiadomosc)
    {
        Console.WriteLine("Programista " + login + " otrzymał wiadomość: " + wiadomosc);
    }
}

//
//
//

class Program
{
    static void Main(string[] args)
    {

        //

        IUzytkownik ania = new Klient(mediator, "Ania");
        //
        //

        //
        mediator.DodajUzytkownika(nakamoto);
        //

        //
        geohot.WyslijWiadomosc("Czekam, aż Nakamoto zaparzy kawę...");

    }
}