using ConsoleApp_csharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_csharp
{
    internal class Book
    {
        public required string author { get; init; }
        public required string name { get; init; } //means its required /mandatory 
        public string? description { get; init; } //means it can be null/optional  
        public int pages { get; init; } //int cant be null so unless you explicitl say it 
    }
}

// {get; init;} is a read only 
//get; → you can read the value

//init; → you can set it only during object initialization

//So this is read-only after construction. you cant change the value once initilized 
//Book book1 = new Book
//{
// Author = "George Orwell"
//};

//book.Author = "Huxley"; // ❌ compile-time error








// Conversely {get; set;} means its mutable /can be changed as often even after initilization 
//public string Author { get; set; }
// mens You can change it anytime:
//Book book2 = new Book{
// Author = "Orwell";
// };

//Book book3 = new Book{
//Author = "Huxley"}; // ✅ allowed
