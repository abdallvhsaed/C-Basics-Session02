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
            int pages = 300;
            double pagesDouble = pages;
            Console.WriteLine($"pagesDouble = {pagesDouble}");
            #endregion
        }
    }
}
