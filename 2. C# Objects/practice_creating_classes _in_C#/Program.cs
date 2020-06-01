using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
var album = new Album("Kind of Blue", "Miles Davis");

var book = new Book("TRIZ", "Altshuller");

var movie = new Movie("Kin-dza-dza", "Director");
                                
                                
          Console.WriteLine("Album: " + album.Title + " by " + album.Artist);
          Console.WriteLine("Book: " + book.Title + " by " + book.Author);
          Console.WriteLine("Movie: " + movie.Title + " by " + movie.Director);
        }
    }
}