using System;
using System.Collections.Generic;

namespace cs_con_LibManagementSys
{
    class Program
    {
        static List<Book> bookList = new List<Book>();
        static List<BorrowDetails> borrowList = new List<BorrowDetails>();
        static Book book = new Book();
        static BorrowDetails borrow = new BorrowDetails();

        //Password verfication and Menu 
        static void Main(string[] args)
        {
            Console.Write("**** Welcome to Library Management Sysytem ******** ");
            Welcome();
        }
        public static void Welcome()
        {

            Console.WriteLine("\n **  Menu  **\n" +
                    "Enter : ( 1 )  Librarian\n" +
                    "Enter : (2)  Borrower\n"+
                    "Enter : ( 3 )  Exit\n\n");
            Console.Write("Choose your option from menu :");

            int option_person = int.Parse(Console.ReadLine());
            if (option_person == 1)
            {
                Console.Clear();
                Console.WriteLine("\nWelcome MRs / Miss Librarian\n" +
                  "Please choose your option : \n" +
                  "Enter : (1) Books\n" +
                  "Enter : (2) NewsPapers\n\n");
                Console.Write("Choose your option :");
                Book();
            }
            else if (option_person == 2)
            {
                Console.Clear();
                bool close1 = true;
                while (close1)
                {
                    Console.WriteLine("\nWelcome Mrs / Miss Borrower\n" +
                    "Please choose your option :\n" +
                    "1)Borrow book\n" +
                    "2)Return book\n" +
                    "3)Close\n");
                    Console.Write("Choose your option from menu :");

                    int Borrow_Return = int.Parse(Console.ReadLine());

                    if (Borrow_Return == 1)
                    {
                        Borrow();
                    }
                    else if (Borrow_Return == 2)
                    {
                        ReturnBook();
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
            else if(option_person == 3)
            {
                Console.WriteLine("Thank you \n"+" Exited from the application ");
                
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
                    "3)Close\n");
                    Console.Write("Choose your option from menu :");

                    int Add_Del_option = int.Parse(Console.ReadLine());

                    if (Add_Del_option == 1)
                    {
                        AddBook();
                    }
                    else if (Add_Del_option == 2)
                    {
                        RemoveBook();
                    }
                    else if (Add_Del_option == 3)
                    {
                        Console.WriteLine("Thank you");
                        close = false;
                        Welcome();
                       
                    }
                    else
                    {
                        Console.WriteLine("Invalid option\nRetry !!!");
                    }
                }

                else if (Books_Newspapers_option == 2)
                {
                    Console.WriteLine("News papers");
                }
            }
        }

        public static void AddBook()
        {
            Book book = new Book();
            Console.WriteLine("Book Id:{0}", book.bookId = bookList.Count + 1);
            Console.Write("Book Name:");
            book.bookName = Console.ReadLine();
            Console.Write("Number of Books:");
            book.x = book.bookCount = int.Parse(Console.ReadLine());
            bookList.Add(book);
        }

        public static void RemoveBook()
        {
            Book book = new Book();
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
        public static void Borrow()
        {
            Book book = new Book();
            BorrowDetails borrow = new BorrowDetails();
            Console.WriteLine("User id : {0}", (borrow.userId = borrowList.Count + 1));
            Console.Write("Name :");

            borrow.userName = Console.ReadLine();

            Console.Write("Book id :");
            borrow.borrowBookId = int.Parse(Console.ReadLine());
            Console.Write("Number of Books : ");
            borrow.borrowCount = int.Parse(Console.ReadLine());
            borrow.borrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} and Time - {1}", borrow.borrowDate.ToShortDateString(), borrow.borrowDate.ToShortTimeString());

            if (bookList.Exists(x => x.bookId == borrow.borrowBookId))
            {
                foreach (Book searchId in bookList)
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
        public static void ReturnBook()
        {
            Book book = new Book();
            Console.WriteLine("Enter following details :");

            Console.Write("Book id : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of Books:");
            int returnCount = int.Parse(Console.ReadLine());

            if (bookList.Exists(y => y.bookId == returnId))
            {
                foreach (Book addReturnBookCount in bookList)
                {
                    if (addReturnBookCount.x >= returnCount + addReturnBookCount.bookCount)
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
    class Book
    {
        public int bookId;
        public string bookName;
        public int bookCount;
        public int x;
    }
    class BorrowDetails
    {
        public int userId;
        public string userName;
        public int borrowBookId;
        public DateTime borrowDate;
        public int borrowCount;
    }
}






















