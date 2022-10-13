using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

interface INums
{
    public string ShowNums();
}
interface ILetters
{
    public string ShowAlfa();
}

class AlphabetFactory
{

    private SystemFactory systemFactory;
    public INums numbers;
    public ILetters letters;

    public AlphabetFactory(SystemFactory systemFactory)
    {
        this.systemFactory = systemFactory;
    }

    public void Generate()
    {
        numbers = systemFactory.CreateNum();
        letters = systemFactory.CreateAlfa();
    }

}


abstract class SystemFactory
{
    public abstract ILetters CreateAlfa();
    public abstract INums CreateNum();
}


//
// ...
//


class CyrylicaFactory : SystemFactory
{
    public override ILetters CreateAlfa()
    {
        return new CyrlicaLetters();
    }

    public override INums CreateNum()
    {
        return new CyrlicaNumbers();
    }
}

class LacinkaFactory : SystemFactory
{
    public override ILetters CreateAlfa()
    {
        return new LacinkaLetters();
    }

    public override INums CreateNum()
    {
        return new LacinkaNumbers();
    }
}

class GrekaFactory : SystemFactory
{
    public override ILetters CreateAlfa()
    {
        return new GrekaLetters();
    }

    public override INums CreateNum()
    {
        return new GrekaNumbers();
    }
}

// Cyrlica

class CyrlicaNumbers : INums
{
    string numbers;

    public CyrlicaNumbers()
    {
        numbers = "1 2 3";
    }

    public string ShowNums()
    {
        return numbers;
    }

}

class CyrlicaLetters : ILetters
{
    string letters;
    public CyrlicaLetters()
    {
        letters = "абвгд";
    }
    public string ShowAlfa()
    {
    return letters;
    }

}

// Alfabet łaciński

class LacinkaNumbers : INums
{
    string numbers;

    public LacinkaNumbers()
    {
        numbers = "I II III";
    }

    public string ShowNums()
    {
        return numbers;
    }

}

class LacinkaLetters : ILetters
{
    string letters;
    public LacinkaLetters()
    {
        letters = "abcde";
    }
    public string ShowAlfa()
    {
        return letters;
    }

}

// Alfabet Grecki

class GrekaNumbers : INums
{
    string numbers;

    public GrekaNumbers()
    {
        numbers = "αʹ βʹ γʹ";
    }

    public string ShowNums()
    {
        return numbers;
    }

}

class GrekaLetters : ILetters
{
    string letters;
    public GrekaLetters()
    {
        letters = "αβγδε";
    }
    public string ShowAlfa()
    {
        return letters;
    }

}

//
// ...
//

public class Application
{
    public static void Main(String[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        AlphabetFactory alfabet_lacinka = new AlphabetFactory(new LacinkaFactory());
        AlphabetFactory alfabet_cyrlica = new AlphabetFactory(new CyrylicaFactory());
        AlphabetFactory alfabet_greka = new AlphabetFactory(new GrekaFactory());

        alfabet_lacinka.Generate();
        alfabet_cyrlica.Generate();
        alfabet_greka.Generate();
        
        Console.WriteLine(alfabet_lacinka.letters.ShowAlfa() + " " + alfabet_lacinka.numbers.ShowNums());
        Console.WriteLine(alfabet_cyrlica.letters.ShowAlfa() + " " + alfabet_cyrlica.numbers.ShowNums());
        Console.WriteLine(alfabet_greka.letters.ShowAlfa() + " " + alfabet_greka.numbers.ShowNums());
    }
}