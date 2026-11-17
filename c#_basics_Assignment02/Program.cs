using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace c__basics_Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Qَ01

            // Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print 
            // both title and upperTitle to show that title did not change.
            Console.WriteLine("--------------- Q01 ---------------");
            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine($"Title        : {title}\n" +
                              $"Upper Titel  : {upperTitle}");
            Console.WriteLine();

            #endregion

            #region Q02

            // Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() 
            // to check if they point to the same object in memory.

            Console.WriteLine("--------------- Q02 ---------------");
            string cleanCode01 = "Clean Code";
            string cleanCode02 = "Clean Code";
            Console.WriteLine(string.ReferenceEquals(cleanCode01,cleanCode02));
            Console.WriteLine();

            #endregion

            #region Q03

            // Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same 
            // object.Print the final result.

            Console.WriteLine("--------------- Q03 ---------------");
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Book List");
            stringBuilder.Append(" - Updated");
            Console.WriteLine(stringBuilder);
            Console.WriteLine();

            #endregion

            #region Q04

            // Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". 
            // Print the result.

            Console.WriteLine("--------------- Q04 ---------------");
            stringBuilder.Replace("Book List", "Library");
            Console.WriteLine(stringBuilder);
            Console.WriteLine();

            #endregion

            #region Q05

            // Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, 
            // Pages: 464" using the + operator.


            Console.WriteLine("--------------- Q05 ---------------");
            //string title = "Clean Code";
            int pages = 464;
            Console.WriteLine("Book: " + title + ", Pages: " + pages);
            Console.WriteLine();

            #endregion

            #region Q06

            // Build the same sentence as above, but using string interpolation ($"..."). 

            Console.WriteLine("--------------- Q06 ---------------");
            Console.WriteLine($"Book: {title}, Pages: {pages}");
            Console.WriteLine();

            #endregion

            #region Q07

            // Build the same sentence again, but using string.Format().

            Console.WriteLine("--------------- Q07 ---------------");
            Console.WriteLine(string.Format("Book: {0}, Pages: {1}",title,pages));
            Console.WriteLine();
            //throw new NotImplementedException();
            //Console.WriteLine(string.Format());
            #endregion

            #region Q08

            // Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 
            //300, otherwise prints "Short Book".

            Console.WriteLine("--------------- Q08 ---------------");
            /*int*/
            pages = 464;
            if( pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            Console.WriteLine();

            #endregion

            #region Q09

            // Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is 
            //greater than 300 and isAvailable is true.Use the && operator. 

            Console.WriteLine("--------------- Q09 ---------------");
            /*int*/
            pages = 464;
            bool isAvailable = true;
            if (pages > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }
            Console.WriteLine();

            #endregion

            #region Q10

            // Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is 
            //"Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else. 

            Console.WriteLine("--------------- Q10 ---------------");
            /*string*/
            title = "Refactoring";
            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }

            #endregion


            #region Q11

            // Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a 
            //variable sizeLabel(same rule as question 8: long if pages > 300).

            Console.WriteLine("--------------- Q11 ---------------");
            /*int*/
            pages = 464;
            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);
            Console.WriteLine();

            #endregion

            #region Q12

            // Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop 
            // to print each book with its position number, like 1.Clean Code.

            Console.WriteLine("--------------- Q12 ---------------");
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++) {
                Console.WriteLine($"{i + 1}.{books[i]}");
            }
            Console.WriteLine();
            #endregion

            #region Q13

            // Using the same books array, use a while loop to print every book title. 

            Console.WriteLine("--------------- Q13 ---------------");
            // Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int counter = 0;
            while (counter < books.Length) {
                Console.WriteLine($"{counter + 1}.{books[counter]}");
                ++counter;
            }
            Console.WriteLine();

            #endregion

            #region Q14

            // Write a do-while loop that prints "Checking book..." exactly 3 times. 

            Console.WriteLine("--------------- Q14 ---------------");
            counter = 0;
            do
            {
                Console.WriteLine("Checking book...");
                ++counter;
            } while (counter <= 2);
            Console.WriteLine();

            #endregion

            #region Q15

            // Using the same books array, use a foreach loop to print every book title.

            Console.WriteLine("--------------- Q15 ---------------");
            // Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine();

            #endregion

            #region Q16

            // Using the same books array, loop through it and print each title, but stop completely (break) once 
            // you reach "Refactoring".

            Console.WriteLine("--------------- Q16 ---------------");
            // Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books)
            {
                if (book == "Refactoring")
                    break;
                Console.WriteLine(book);
            }
            Console.WriteLine();

            #endregion

            #region Q17
            // Using the same books array, print every title except "The Pragmatic Programmer" (skip it with 
            // continue, don't stop the loop).

            Console.WriteLine("--------------- Q17 ---------------");
            // Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                    continue;
                Console.WriteLine(book);
            }
            Console.WriteLine();

            #endregion

            #region Q18

            // Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty, 
            //use return to exit the method early instead of printing anything.

            Console.WriteLine("--------------- Q18 ---------------");
            PrintFirstBook(books);
            PrintFirstBook(null);
            PrintFirstBook([]);

            #endregion
        }

        #region Q18
        public static void PrintFirstBook(string[] books)
        {
            if(books == null || books.Length == 0)
                return;
            Console.WriteLine(books[0]);
        }
        #endregion
    }
}
