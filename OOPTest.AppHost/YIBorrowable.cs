using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest.AppHost
{
    internal interface YIBorrowable
    {
        bool IsBorrowed { get; }
        void Borrow();
        void Return();
    }
}
