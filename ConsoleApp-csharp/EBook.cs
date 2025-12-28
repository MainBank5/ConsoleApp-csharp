using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_csharp
{
    internal class EBook : Book
    {
        public string? format { get; set; }   // e.g., "PDF", "EPUB"
        public double filesize { get; set; } // in MB

        public void printfileinfo()
        {
            Console.WriteLine($"format: {format}, filesize: {filesize} MB");
        }

        public bool islong()
        {
            return pages > 300;
        }

    }
}
