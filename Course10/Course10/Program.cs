using System;
using System.Collections.Generic;
using System.Linq;

namespace Course10
{
    public static class Extensions
    {
        public static void Display<T>(this IEnumerable<T> source)
        {
            foreach (var element in source)
            {
                Console.WriteLine(element);
            }
        }
    }
   
 
    
    class Program
    {
        static void Main(string[] args)
        {
            
            Library library = new Library();
            library.addBook();

            Console.WriteLine("List of all the books in the library:");
            library.displayBooks();

            library.deleteBook(2);
            Console.WriteLine("\nList of all the books after deleting one:");
            library.displayBooks();

            Console.WriteLine("\nList of all the books published after 1980:");
            library.booksPublished();

            Console.WriteLine("\nList of drama books:");
            library.dramaBooks();


            library.addAuthor();
            Console.WriteLine("\nThe authors that have at least 3 books are: ");
            library.booksCount();

           
            Console.WriteLine("\nThe books grouped by decade: ");
            library.groupBooks();
           
            Console.ReadKey();
        }
    }
}
