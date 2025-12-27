using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp_csharp
{
    internal class BookMutable
    {
        public string  Author { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Pages { get; set; }

        public void printinfo()
        {
            Console.WriteLine($"{Name} by {Author} ({Pages} pages)");
        }

        public bool islong()
        {
            return Pages > 300;
        }
    }
}
