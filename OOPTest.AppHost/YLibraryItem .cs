using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest.AppHost
{
    public abstract class XLibraryItem : YIBorrowable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public bool IsBorrowed { get; private set; }

        public XLibraryItem(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            IsBorrowed = false;
        }

        public void Borrow()
        {
            if (IsBorrowed)
            {
                Console.WriteLine($"'{Title}' is already borrowed.");
            }
            else
            {
                IsBorrowed = true;
                Console.WriteLine($"'{Title}' has been borrowed.");
            }
        }

        public void Return()
        {
            if (!IsBorrowed)
            {
                Console.WriteLine($"'{Title}' was not borrowed.");
            }
            else
            {
                IsBorrowed = false;
                Console.WriteLine($"'{Title}' has been returned.");
            }
        }

        public override string ToString()
        {
            return $"{Title} by {Author} ({PublicationYear}) - {(IsBorrowed ? "Borrowed" : "Available")}";
        }
    }
}
