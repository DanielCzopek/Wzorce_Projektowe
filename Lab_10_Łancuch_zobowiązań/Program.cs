using System;
using System.Collections.Generic;

namespace LancuchZobowiazan
{
    public interface IHandler
    {
        // 2 metody
        //
    }

    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            //
            return handler;
        }

        public virtual void Handle(string request)
        {

            // jeśli uchwyt jest nullem to nikt nie je (i to wypisać)

            // jeśli ma jakąś wartość, to trzeba przekazać kolejnemu zwierzakowi w hierarchii

        }
    }

    public class MonkeyHandler : AbstractHandler
    {
        public override void Handle(string request)
        {
            if (request == "banan")
            {
                //
            }
            else
            {
                base.Handle(request);
            }
        }
    }

    public class SquirrelHandler : AbstractHandler
    {
        public override void Handle(string request)
        {
            if (request == "?????")
            {
                Console.WriteLine($"Wiewiórka zjada {request}.");
            }
            else
            {
                //
            }
        }
    }



    public class Client
    {
        public static void ClientCode(AbstractHandler handler)
        {

            // foreach po liście produktów (stringi)

            // wewnątrz pytanie "Dto chce {food}?"
            // i odpalenie właściwej metody na uchwycie

        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler monkey = new MonkeyHandler();
            AbstractHandler squirrel = new SquirrelHandler();
            // wszystkie zwierzaki?

            monkey.SetNext(dog); // dokończyć łańcuch...

            Console.WriteLine("Łańcuch: Małpa > Pies > Wiewiórka > Kot");
            Client.ClientCode(monkey);
            Console.WriteLine();

            Console.WriteLine("Podzbiór łańcucha: Wiewiórka > Kot");
            Client.ClientCode(squirrel);
        }
    }
}