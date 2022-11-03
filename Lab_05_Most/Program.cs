using System;


public interface ITelewizor
{

    int Kanal { get; set; }
    //
    //
    void ZmienKanal(int kanal);

}



public class TvLg : ITelewizor
{

    public TvLg()
    {
        this.Kanal = 1;
    }

    public int Kanal { get; set; }

    public void Wlacz()
    {
        Console.WriteLine("Telewizor LG włączony.");
    }

    public void Wylacz()
    {
        //
        //
    }

    public void ZmienKanal(int kanal)
    {
        //
        //
    }

}



public class TvXiaomi : ITelewizor
{

    //
    //

}



public abstract class PilotAbstrakcyjny
{

    private ITelewizor tv;

    public PilotAbstrakcyjny(ITelewizor tv)
    {
        //
        //
    }

    //
    //

    public void ZmienKanal(int kanal)
    {
        //
        //
    }

}



public class PilotHarmony : PilotAbstrakcyjny
{

    public PilotHarmony(ITelewizor tv) : base(tv) { }

    public void DoWlacz()
    {
        Console.WriteLine("Pilot Harmony włącza telewizor...");
        Wlacz();
    }

    //
    //

}

public class PilotPhilips : PilotAbstrakcyjny
{

    //
    //

    public void DoWylacz()
    {
        Console.WriteLine("Pilot Philips wyłącza telewizor...");
        Wylacz();
    }

}



class MainClass
{
    public static void Main(string[] args)
    {

        ITelewizor tv = new TvLg();
        //
        //

        pilotHarmony.DoWlacz();
        Console.WriteLine("Kanał: " + tv.Kanal);
        pilotPhilips.DoZmienKanal(100);
        Console.WriteLine("Kanał: " + tv.Kanal);
        pilotHarmony.DoWylacz();

    }
}