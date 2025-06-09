using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest.AppHost
{
    internal class YBook : XLibraryItem
    {
        public YBook(string title, string author, int year) : base(title, author, year) { }
    }
}
