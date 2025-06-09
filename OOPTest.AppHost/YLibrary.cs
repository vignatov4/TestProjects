using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest.AppHost
{
    public class YLibrary
    {
        private List<XLibraryItem> items = new List<XLibraryItem>();

        public void AddItem(XLibraryItem item)
        {
            items.Add(item);
            Console.WriteLine($"Added: {item.Title}");
        }

        public void BorrowItem(string title)
        {
            var item = items.FirstOrDefault(i => i.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (item != null)
            {
                item.Borrow();
            }
            else
            {
                Console.WriteLine($"Item '{title}' not found.");
            }
        }

        public void ReturnItem(string title)
        {
            var item = items.FirstOrDefault(i => i.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (item != null)
            {
                item.Return();
            }
            else
            {
                Console.WriteLine($"Item '{title}' not found.");
            }
        }

        public void DisplayAllItems()
        {
            Console.WriteLine("Library Inventory:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
