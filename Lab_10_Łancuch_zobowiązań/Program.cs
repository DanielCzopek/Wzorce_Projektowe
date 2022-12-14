using System;
using System.Collections.Generic;

namespace LancuchZobowiazan
{
    public interface IHandler
    {
        public void Handle(string request);
        IHandler SetNext(IHandler handler);
        // 2 metody
        //
    }

    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual void Handle(string request)
        {

            // jeśli uchwyt jest nullem to nikt nie je (i to wypisać)
            if (_nextHandler == null)
                Console.WriteLine($"Nikt nie chce tego zjeść: {request}");
            else
            {
                _nextHandler.Handle(request);
            }
            // jeśli ma jakąś wartość, to trzeba przekazać kolejnemu zwierzakowi w hierarchii

        }
    }

    public class MonkeyHandler : AbstractHandler
    {
        public override void Handle(string request)
        {
            if (request == "banan")
            {
                Console.WriteLine($"Małpa zjada {request}.");
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
            if (request == "orzech")
            {
                Console.WriteLine($"Wiewiórka zjada {request}.");
            }
            else
            {
                base.Handle(request);
            }
        }
    }
    public class DogHandler : AbstractHandler
    {
        public override void Handle(string request)
        {
            if (request == "plasterek szynki" || request == "mięso")
            {
                Console.WriteLine($"Pies zjada {request}.");
            }
            else
            {
                base.Handle(request);
            }
        }
    }
    public class CatHandler : AbstractHandler
    {
        public override void Handle(string request)
        {
            if (request == "mięso")
            {
                Console.WriteLine($"Kot zjada {request}.");
            }
            else
            {
                base.Handle(request);
            }
        }
    }
}
