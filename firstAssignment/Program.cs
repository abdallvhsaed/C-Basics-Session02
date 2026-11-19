using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace firstAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region question 1 
            // create a book class with a title (string) and pages (int) create a book object and store it in a variable of type object 
            //object book1 = new Book { Title = "change your mind", pages = 50 };

            #endregion
            #region question 2
            //using the book class above, print the result of calling ToSring() equals() GetHashCode() GetType() on book
            //object book1 = new Book { Title = "change your mind", pages = 50 };
            //Console.WriteLine(book1.ToString());
            //Console.WriteLine(book1.Equals(book1));
            //Console.WriteLine(book1.GetHashCode());
            //Console.WriteLine(book1.GetType());



            #endregion
            #region question 3
            //is it a compile time error , a run time error or a logical error
            //the anwer is it is a compile time error because int data type doesn't accept String values
            //int pages = 464;
            #endregion
            #region question 4
            //try {
            //    int x = 10;
            //    int y = 0;
            //    int z = x / y;
            //    Console.WriteLine(z);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("you can't divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("done");
            //}
            #endregion
            #region question 5
            //declare an int pages = 300; then store it in a double variable without using a cast
            //int pages = 300;
            //double pagesDouble = pages;
            //Console.WriteLine($"pagesDouble = {pagesDouble}");
            #endregion
            #region question 6 
            //declare a double price =49.99 then convert it into an int using cast
            //double price = 49.99;
            //int priceInt = (int)price;
            //Console.WriteLine($"priceInt = {priceInt}");
            #endregion
            #region question 7
            //Given string pagesText = "464";, convert it into an int using the Convert class
            //string pagesText = "464";
            //int pagesInt = Convert.ToInt32(pagesText);
            //Console.WriteLine($"pagesInt = {pagesInt}");
            #endregion
            #region question 8
            //Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
            //use int.TryParse() to safely try converting it, and print "Invalid number" if it fails
            //string yearText = "2023";
            //int yearInt = int.Parse(yearText);

            //string badText = "abc";
            //if(int.TryParse(badText, out int badInt))
            //{
            //    Console.WriteLine($"successfully operation , badInt = {badInt}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}
            #endregion
            #region question 9 
            //Given int pages = 464;, convert it into a string using ToString() and print its type using GetType()
            //to prove it's now a string.
            int pages = 464;
            string pagesString = pages.ToString();
            Console.WriteLine($"pagesString = {pagesString}");
            Console.WriteLine($"Type of pagesString = {pagesString.GetType()}");
            #endregion
        }
    }
}
