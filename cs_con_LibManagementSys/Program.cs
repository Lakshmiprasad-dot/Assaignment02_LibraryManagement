using System;
using System.Collections.Generic;

namespace cs_con_LibManagementSys
{
    class Program
    {
        static List<Book_Details> bookList = new List<Book_Details>();
        static List<Borrow_Details> borrowList = new List<Borrow_Details>();
        static Book_Details book = new Book_Details();
        static Borrow_Details borrow = new Borrow_Details();
        static void Main(string[] args)
        {
            Console.WriteLine("**** Welcome to Library Management Sysytem ******** ");
            Welcome();
        }
        public static void Welcome()
        {
            Console.WriteLine("\n **  Menu  **\n" +
                    "Enter : ( 1 )  Librarian\n" +
                    "Enter : (2)  Borrower\n" +
                    "Enter : ( 3 )  Exit\n\n");
            Console.Write("Choose your option from menu :");

            int option_person = int.Parse(Console.ReadLine());
            if (option_person == 1)
            {
                Console.Clear();
                Console.WriteLine("\nWelcome Mrs / Ms Librarian\n" +
                  "Please choose your option : \n" +
                  "Enter : (1) Books\n" +
                  "Enter : (2) NewsPapers\n");
                Console.Write("Choose your option :");
                Book();
            }
            else if (option_person == 2)
            {
                Console.Clear();
                bool close1 = true;
                while (close1)
                {
                    Console.WriteLine("\nWelcome Mrs / Ms Borrower\n" +
                    "Please choose your option :\n" +
                    "1)Borrow book\n" +
                    "2)Return book\n" +
                    "3)Close\n");
                    Console.Write("Choose your option from menu :");

                    int Borrow_Return = int.Parse(Console.ReadLine());

                    if (Borrow_Return == 1)
                    {
                        Borrow_Book_From_Library();
                    }
                    else if (Borrow_Return == 2)
                    {
                        Return_Book_To_Library();
                    }
                    else if (Borrow_Return == 3)
                    {
                        Console.WriteLine("Thank you");
                        close1 = false;
                        Welcome();
                    }
                    else
                    {
                        Console.WriteLine("Invalid option\nRetry !!!");
                    }
                }
            }
            else if (option_person == 3)
            {
                Console.WriteLine("Thank you \n" + " ** Exited from the application **");

            }
        }
        public static void Book()
        {
            int Books_Newspapers_option = int.Parse(Console.ReadLine());
            bool close = true;
            while (close)
            {
                if (Books_Newspapers_option == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\nMenu\n" +
                    "Please choose your option\n" +
                    "1)Add book\n" +
                    "2)Delete book\n" +
                    "3)Close\n" +
                    "4)Find Book Availabilty\n");
                    
                    Console.Write("Choose your option from menu :");

                    int Add_Del_option = int.Parse(Console.ReadLine());

                    if (Add_Del_option == 1)
                    {
                        Add_Book();
                    }
                    else if (Add_Del_option == 2)
                    {
                        Delete_Book();
                    }
                    else if (Add_Del_option == 3)
                    {
                        Console.WriteLine("Thank you");
                        close = false;
                        Welcome();

                    }
                    else if(Add_Del_option == 4)
                    {
                        Find_Book_Availability();
                    }
                    else
                    {
                        Console.WriteLine("Invalid option\nRetry !!!");
                    }
                }

                else if (Books_Newspapers_option == 2)
                {
                    Console.WriteLine("****  News papers Section  *****");
                    Console.WriteLine("No NewsPapers are available to do Modifications");
                }
            }
        }
        public static void Find_Book_Availability()
        {
            Book_Details book = new Book_Details();
            Console.Write("Search by BOOK id :");
            int find = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == find))
            {
                foreach (Book_Details searchId in bookList)
                {
                    if (searchId.bookId == find)
                    {
                        Console.WriteLine("Book id :{0}\n" +
                        "Book name :{1}\n" +
                        "Book Count :{2}", searchId.bookId, searchId.bookName, searchId.bookCount);
                    }
                    else
                    {
                        Console.WriteLine("Books are Not Available ..!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }
        public static void Add_Book()
        {
            Book_Details book = new Book_Details();
            Console.WriteLine("Book Id:{0}", book.bookId = bookList.Count + 1);
            Console.Write("Book Name:");
            book.bookName = Console.ReadLine();
            Console.Write("Number of Books:");
            book.Ref_x = book.bookCount = int.Parse(Console.ReadLine());
            bookList.Add(book);
        }
        public static void Delete_Book()
        {
            Book_Details book = new Book_Details();
            Console.Write("Enter Book id to be deleted : ");

            int Del = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == Del))
            {
                bookList.RemoveAt(Del - 1);
                Console.WriteLine("Book id - {0} has been deleted", Del);
            }
            else
            {
                Console.WriteLine("Invalid Book id");
            }
            bookList.Add(book);
        }
        public static void Borrow_Book_From_Library()
        {
            Book_Details book = new Book_Details();
            Borrow_Details borrow = new Borrow_Details();
            Console.WriteLine("User id : {0}", (borrow.userId = borrowList.Count + 1));
            Console.Write("Name :");

            borrow.userName = Console.ReadLine();

            Console.Write("Book id :");
            borrow.borrowBookId = int.Parse(Console.ReadLine());
            Console.Write("Number of Books : ");
            borrow.borrowCount = int.Parse(Console.ReadLine());
            borrow.borrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} ", borrow.borrowDate.ToShortDateString());

            if (bookList.Exists(x => x.bookId == borrow.borrowBookId))
            {
                foreach (Book_Details searchId in bookList)
                {
                    if (searchId.bookCount >= searchId.bookCount - borrow.borrowCount && searchId.bookCount - borrow.borrowCount >= 0)
                    {
                        if (searchId.bookId == borrow.borrowBookId)
                        {
                            searchId.bookCount = searchId.bookCount - borrow.borrowCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only {0} books are found", searchId.bookCount);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", borrow.borrowBookId);
            }
            borrowList.Add(borrow);
        }
        public static void Return_Book_To_Library()
        {
            Book_Details book = new Book_Details();
            Console.WriteLine("Enter following details :");

            Console.Write("Book id : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of Books:");
            int returnCount = int.Parse(Console.ReadLine());

            if (bookList.Exists(y => y.bookId == returnId))
            {
                foreach (Book_Details addReturnBookCount in bookList)
                {
                    if (addReturnBookCount.Ref_x >= returnCount + addReturnBookCount.bookCount)
                    {
                        if (addReturnBookCount.bookId == returnId)
                        {
                            addReturnBookCount.bookCount = addReturnBookCount.bookCount + returnCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Count exists the actual count");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", returnId);
            }
        }
    }
    class Book_Details
    {
        public int bookId;
        public string bookName;
        public int bookCount;
        public int Ref_x;
    }
    class Borrow_Details
    {
        public int userId;
        public string userName;
        public int borrowBookId;
        public DateTime borrowDate;
        public int borrowCount;
    }
}























