using makingYourOwnClasses;
using System;

internal static class Class1Helpers
{

    private static void Main(string[] args)
    {
        Class1 book = new Class1("harry potter", "story of a boy called harry who selected to be a wizard", 256);

        book.setTitle("harry potter and the priznor of askaban");

        Console.WriteLine(book.getTitle());

    }
}