using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public interface INums
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

class GreakFactory : SystemFactory
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




class CyrlicaNumbers : INums
{
    string numbers;

    public CyrlicaNumbers()
    {
        numbers = "1 2 3";
    }

    public string ShowNum()
    {
        return numbers;
    }
}

class CyrlicaLetters : ILetters
{

}

class LacinkaNumbers : INums
{
}


class LacinkaLetters : ILetters
{
    string letters;

    public LacinkaLetters()
    {
        letters = "abcde";
    }

    //
    //
    //
}
class GrekaNumbers : INums
{
    string numbers;

    public GrekaNumbers()
    {
        numbers = "αʹ βʹ γʹ";
    }

    public string ShowNum()
    {
        return numbers;
    }
}

class GrekaLetters : ILetters
{

}


//
// ...
//


public class Application
{
    public static void Main(String[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        AlphabetFactory alphabet_lacinka = new AlphabetFactory(new LacinkaFactory());
        //
        //

        //
        alphabet_cyrylica.Generate();
        //

        //
        //
        Console.WriteLine(alfabet_greka.letters.ShowAlfa() + " " + alfabet_greka.numbers.ShowNum());
    }
}