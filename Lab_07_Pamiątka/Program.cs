using System;
using System.Collections.Generic;

namespace Pamiatka
{
    public interface IMovie
    {
        public void SetYear(int year);
        public IMemento Save();
        public void Restore(IMemento memento);
    }

    public interface IMemento
    {
        public int GetYear();
    }

    internal sealed class BackToTheFuture : IMovie
    {
        private int Year;

        public BackToTheFuture(int year)
        {
            // początkowa wartość
            Year = year;
            Console.WriteLine("Początkowy rok: " + year);
        }

        public void SetYear(int year)
        {
            // ustawia pole na właściwą wartość
            // print
            Year = year;
            Console.WriteLine("Rok zmieniony na: " + year);
        }

        public IMemento Save()
        {
            Console.WriteLine("Zapisano pamiątkę z roku: " + Year);
            return new Memento(Year);
        }

        public void Restore(IMemento memento)
        {
            Year = memento.GetYear();
          //przywraca pamiątke
        }
    }

    internal sealed class Memento : IMemento
    {
        //
        private int Year;

        public Memento(int year)
        {
            // konstruktor
            Year = year;
        }

        public int GetYear()
        {
            // zwraca rok
            return Year;
        }
    }

    internal sealed class Caretaker
    {
        private List<IMemento> Mementos = new List<IMemento>(); // pole o nazwie?

        private IMovie movie;

        public Caretaker(IMovie movie)
        {
            this.movie = movie;
        }

        public void Save()
        {
            // dodaje pamiętkę do listy pamiątek
            // print o zapisie
            Mementos.Add(movie.Save());
        }

        public void Undo()
        {
            // print jeśli nie ma pamiątek do przywrócenia
            if (Mementos.Count == 0)
            {
                Console.WriteLine("Nie można cofnąć - brak zapisanych danych");
                return;
            }

            var memento = Mementos[Mementos.Count - 1];

            // wyciągniętą pamiątkę trzeba skasować
            // i przywrócić (metoda)

            Mementos.RemoveAt(Mementos.Count - 1);
            movie.Restore(memento);

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