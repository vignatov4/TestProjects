using OOPTest.AppHost;

class Program
{
    static void Main(string[] args)
    {

        //var employees = new List<Employee>
        //    {
        //        new FullTimeEmployee("Alice", 1, 4000),
        //        new PartTimeEmployee("Bob", 2, 2000)
        //    };


        //foreach (var emp in employees)
        //{
        //    emp.CalculateAnnualSalary();  // Each class runs its own version!
        //}


        YLibrary library = new YLibrary();

        library.AddItem(new YBook("Pride and Prejudice", "Jane Austen", 1813));
        library.AddItem(new YMagazine("National Geographic", "Various", 2021));
        library.AddItem(new YDVD("Inception", "Christopher Nolan", 2010));

        library.DisplayAllItems();

        library.BorrowItem("Pride and Prejudice");
        library.BorrowItem("Pride and Prejudice"); // deja împrumutat

        library.ReturnItem("Pride and Prejudice");
        library.ReturnItem("Pride and Prejudice"); // deja returnat

        library.BorrowItem("To Kill a Mockingbird"); // nu există

        library.DisplayAllItems();
    }

}