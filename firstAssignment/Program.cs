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
                object book1 = new Book { Title = "change your mind", pages = 50 };
                Console.WriteLine(book1.ToString());
                Console.WriteLine(book1.Equals(book1));
                Console.WriteLine(book1.GetHashCode());
                Console.WriteLine(book1.GetType());
            
                

            #endregion
        }
    }
}
