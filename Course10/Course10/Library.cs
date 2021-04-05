using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course10
{
    
    public class Library
    {
        List<Book> book = new List<Book>();
        List<Author> author = new List<Author>();

        //add an author
        public void addAuthor()
        {
           
            List<Book> books1 = new List<Book>();
            books1.Add(new Book { IdBook = "3", Title = "Harry Potter and the chamber of secrets", Year = "1998", Category = "SF", Author = "J.K.Rowling" });
            books1.Add(new Book { IdBook = "6", Title = "Harry Potter and the philosopher's stone", Year = "1997", Category = "SF", Author = "J.K.Rowling" });
            books1.Add(new Book { IdBook = "7", Title = "Harry Potter and the Goblet of Fire", Year = "2000", Category = "SF", Author = "J.K.Rowling" });
            books1.Add(new Book { IdBook = "8", Title = "Harry Potter and the Order of Pheonix", Year = "2000", Category = "SF", Author = "J.K.Rowling" });
            author.Add(new Author { IdAuthor = "1", Name = "J.K.Rowling", DateOfBirth = new DateTime(1965, 07, 31), Books = books1 });


            List<Book> books2 = new List<Book>();
            books2.Add(new Book { IdBook = "5", Title = "Ugly Love", Year = "2014", Category = "Romance, Drama", Author = "Colleen Hoover" });
            books2.Add(new Book { IdBook = "9", Title = "Confess", Year = "2010", Category = "Romance, Drama", Author = "Colleen Hoover" });
            books2.Add(new Book { IdBook = "5", Title = "Verity", Year = "2015", Category = "Romance, Drama", Author = "Colleen Hoover" });
            author.Add(new Author { IdAuthor = "2", Name = "Collen Hoover", DateOfBirth = new DateTime(1979, 12, 09), Books = books2 });

            List<Book> books3 = new List<Book>();
            books3.Add(new Book { IdBook = "1", Title = "Gone with the wind", Year = "1936", Category = "Historical Fiction, Drama", Author = "Margaret Mitchell" });
            author.Add(new Author { IdAuthor = "3", Name = "Margaret Mitchell", DateOfBirth = new DateTime(1900, 11, 08), Books = books3 });

            List<Book> books4 = new List<Book>();
            books4.Add(new Book { IdBook = "2", Title = "The Great Gatsby", Year = "1925", Category = "Historical Fiction, Drama", Author = "F. Scott Fitzgerald" });
            author.Add(new Author { IdAuthor = "4", Name = "F.Scott.Fitzgerald", DateOfBirth = new DateTime(1896, 09, 24), Books = books4 });
            


        }


        //display a list of the authors that have 3 books or more
        public void booksCount()
        {
            var filterCount = author.Where(p => p.Books.Count >= 3);
            filterCount.Display();
           
        }

        //group books by decade
        public void groupBooks()
        {
            var groups = book.GroupBy(p => p.Year );
            foreach(var group in groups)
            {
                Console.WriteLine(group.Key);
                foreach(Book item in group)
                {
                    Console.WriteLine(item.Title);
                }
                
            }
        }


        public void authorsBirth() 
        {
            //var filterBirth = author.Where(p => p.DateOfBirth.Year > 1900).Where(p => p.Books.Contains("SF"));
            //var filterBook = book.Where(p => p.Category.Contains("SF"));
            
        }

        //add books to the library
       public void addBook()
        {
            book.Add(new Book { IdBook = "1", Title = "Gone with the wind", Year = "1936", Category = "Historical Fiction, Drama", Author = "Margaret Mitchell" });
            book.Add(new Book { IdBook = "2", Title = "The Great Gatsby", Year = "1925", Category = "Historical Fiction, Drama", Author = "F. Scott Fitzgerald" });
            book.Add(new Book { IdBook = "3", Title = "Harry Potter and the chamber of secrets", Year = "1998", Category = "SF", Author = "J.K.Rowling" });
            book.Add(new Book { IdBook = "4", Title = "Harry Potter and the philosopher's stone", Year = "1997", Category = "SF", Author = "J.K.Rowling" });
            book.Add(new Book { IdBook = "5", Title = "Ugly Love", Year = "2014", Category = "Romance, Drama", Author = "Collen Hoover" });
        }
        
        //display all the books in the library
        public void displayBooks()
        {
            book.Display();
        }

        //delete a book 
        public void deleteBook(int i)
        {
            book.RemoveAt(i);
        }

      
        //display a list of all the books written after a X year(in this case 1980)
        public void booksPublished()
        {
            var filterYear = book.Where(p => Int16.Parse(p.Year) > 1980);
            filterYear.Display();
            

        }

        //display a list of all the drama books
        public void dramaBooks()
        {
            var filterDrama = book.Where(p => p.Category.Contains("Drama"));
            filterDrama.Display();
            
        }

       

    }
}
