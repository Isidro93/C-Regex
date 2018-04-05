using System;
using System.Collections.Generic;


namespace cSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Series Numericas");
            Console.ReadKey();

        }
    }

    #region creational patterns, inhiretance, poliformism
    #region Abstract Factory
    
    #endregion    
    class Library
    {
        public string Name {set; get;}
        public List<Book> Books {set; get;}
    }
    class Book
    {
        public Book()
        {

        }
        public int Id { get; set; }
        public string Title { get; set; }
        public Gender  Gender{ get; set; }
        public string Author { get; set; }
        public DateTime publishedYear  { get; set; }

    }
    enum Gender
    {
        Drama,
        Comedy,
        SyFy,
        Romance,
        Horror        
    }
    #endregion
    
    #region Structural Patterns
    
    #endregion 
    #region Behavioral patterns
    
    #endregion

    //fin del doc
}
