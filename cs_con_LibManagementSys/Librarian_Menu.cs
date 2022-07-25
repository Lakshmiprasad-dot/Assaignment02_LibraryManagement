using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_LibManagementSys
{
    internal class Librarian_Menu
    {
        public string Book_Name;
        private int Book_Id;
        public static void Librarian__Option()
        {
            Console.WriteLine("What do you want to manage today ");
            Console.WriteLine("For 'Books' Enter [ 1 ]");
            Console.WriteLine("For 'NewsPapers' Enter [ 2 ]");
            Console.WriteLine("Choose your option Here ");
            int Librarian_Option = int.Parse(Console.ReadLine());
            if (Librarian_Option == 1)
            {
                Console.WriteLine("***Welcome to the  'Books' Section");
                Console.WriteLine();
                Console.WriteLine("Please Select your option ,");
                Console.WriteLine("Add Book");
                Console.WriteLine("Remove Book");
                Console.WriteLine("Show the list of books ");
                create_book();
            }
            else if (Librarian_Option == 2)
            {
                Console.WriteLine("You had chosen 'Newspapres' Option");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You Chosen a Wrong Option, Please Choose Again");
                Console.WriteLine();
                Librarian__Option();
            }
            void create_book()
            {
                Librarian_Menu book1 = new Librarian_Menu();
                Console.Write("Enter the book name here :");
                book1.Book_Name = (Console.ReadLine());
                Console.Write("Enter the book Id here :");
                book1.Book_Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Book is " + book1.Book_Name + " and book ID is " + book1.Book_Id);

            }
        }
    }
}

