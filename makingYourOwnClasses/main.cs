using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makingYourOwnClasses
{
    internal class main
    {
        public static void Main(string[] args)
        {
            Class1 book = new Class1("harry potter", "story of a boy called harry who selected to be a wizard", 256);

            book.setTitle("harry potter and the priznor of askaban");

            Console.WriteLine(book.getTitle());

        }
    }
}
