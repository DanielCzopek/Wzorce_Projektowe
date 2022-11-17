using System;
using System.Collections.Generic;

namespace Pamiatka
{

    public interface IMovie
    {
        //
        //
        //
    }

    class BackToTheFuture : IMovie
    {
        private int Year;

        public BackToTheFuture(int year)
        {
            // początkowa wartość
            Console.WriteLine("Początkowy rok: " + year);
        }

        public void SetYear(int year)
        {
            // ustawia pole na właściwą wartość
            // print
        }

        public IMemento Save()
        {
            return new Memento(this.Year);
        }

        public void Restore(IMemento memento)
        {
            // przywraca wartość pola
        }
    }

    public interface IMemento
    {
        //
    }

    class Memento : IMemento
    {
        private int Year;

        // konstruktor

        public int GetYear()
        {
            // zwraca rok
        }
    }

    class Caretaker
    {
        private List<IMemento> Mementos = new List<IMemento>();

        private // pole o nazwie?

        public Caretaker(IMovie movie)
        {
            this.movie = movie;
        }

        public void Save()
        {
            // dodaje pamiętkę do listy pamiątek
            // print o zapisie
        }

        public void Undo()
        {
            // print jeśli nie ma pamiątek do przywrócenia

            var memento = this.Mementos[this.Mementos.Count - 1];

            // wyciągniętą pamiątkę trzeba skasować
            // i przywrócić (metoda)

            Console.WriteLine("Przywrócony rok: " + memento.GetYear());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BackToTheFuture favoriteMovie = new BackToTheFuture(1985);
            Caretaker caretaker = new Caretaker(favoriteMovie);

            caretaker.Undo(); // test ;)

            Console.WriteLine();

            Console.WriteLine("Część I:");
            favoriteMovie.SetYear(1955);
            caretaker.Save();
            favoriteMovie.SetYear(1985);

            Console.WriteLine();

            Console.WriteLine("Część II:");
            favoriteMovie.SetYear(2015);
            caretaker.Save();
            favoriteMovie.SetYear(1985);
            caretaker.Undo();
            favoriteMovie.SetYear(1985);
            caretaker.Save();

            Console.WriteLine();

            Console.WriteLine("Część III:");
            favoriteMovie.SetYear(1885);
            caretaker.Undo();

        }
    }
}