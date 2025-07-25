﻿using OOPTest.AppHost;
using OOPTest.AppHost.Aditional;

class Program
{
    static void Main(string[] args)
    {
        #region Previous
        //var employees = new List<Employee>
        //    {
        //        new FullTimeEmployee("Alice", 1, 4000),
        //        new PartTimeEmployee("Bob", 2, 2000)
        //    };


        //foreach (var emp in employees)
        //{
        //    emp.CalculateAnnualSalary();  // Each class runs its own version!
        //}


        //YLibrary library = new YLibrary();

        //library.AddItem(new YBook("Pride and Prejudice", "Jane Austen", 1813));
        //library.AddItem(new YMagazine("National Geographic", "Various", 2021));
        //library.AddItem(new YDVD("Inception", "Christopher Nolan", 2010));

        //library.DisplayAllItems();

        //library.BorrowItem("Pride and Prejudice");
        //library.BorrowItem("Pride and Prejudice"); // deja împrumutat

        //library.ReturnItem("Pride and Prejudice");
        //library.ReturnItem("Pride and Prejudice"); // deja returnat

        //library.BorrowItem("To Kill a Mockingbird"); // nu există

        //library.DisplayAllItems();
        #endregion


        #region Current
        //Ex1:Utilizarea unei clase statice.
        //Helper.GenerareCodUnic("ABCD");


        // Ex2: Utilizarea proprietăților și metodelor într-o clasă.
        //Carte carte = new Carte("The Great Gatsby", "F. Scott Fitzgerald", 1925, 500);
        //carte.AfisareDetalii();


        //Ex3: Utilizarea constructorului de copiere într-o clasă.
        Student student1 = new Student("Ion", 22, "Chimie");
        Student student2 = new Student(student1);

        student1.AfisareDetalii();
        student2.AfisareDetalii();

        student1.Varsta = 24;
        student2.Varsta = 30;

        student1.AfisareDetalii();
        student2.AfisareDetalii();
        #endregion
    }

}