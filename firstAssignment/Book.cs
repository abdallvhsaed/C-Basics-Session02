using System;
using System.Collections.Generic;
using System.Text;

namespace firstAssignment
{
    internal class Book
    {
        public String Title { get; set; }
        public int pages { get; set; }

        public override string ToString()
        {
            return $"Title = {Title} **** pages = {pages}";
        }
    }
}
