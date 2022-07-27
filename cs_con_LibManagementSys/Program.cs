using System;
using System.Collections.Generic;

namespace cs_con_LibManagementSys
{
    class Program
    {
        static List<Book_Details> bookList = new List<Book_Details>();
        static List<News_Paper_Details> newspaperList = new List<News_Paper_Details>();
        static List<Borrow_Details> borrowList = new List<Borrow_Details>();
        static News_Paper_Details paper = new News_Paper_Details();
        static Book_Details book = new Book_Details();
        static Borrow_Details borrow = new Borrow_Details();

        static void Main(string[] args)
        {
            Console.WriteLine("**** Welcome to Library Management Sysytem ******** ");
            Welcome();
        }
        public static void Welcome()
        {
            Console.WriteLine("\n ** Main Menu  **\n" +
                    "Enter : ( 1 )  Librarian\n" +
                    "Enter : ( 2 )  Borrower\n" +
                    "Enter : ( 3 )  Exit\n\n");
            Console.Write("Choose your option from menu :");

            int option_person = int.Parse(Console.ReadLine());
            if (option_person == 1)
            {
                Console.Clear();
                Console.WriteLine("\nWelcome Mrs / Ms Librarian\n" +
                  "Please choose your option : \n\n" +
                  "Enter : ( 1 ) Books\n" +
                  "Enter : ( 2 ) NewsPapers\n");
                Console.Write("Enter your option :");
                Librarian();
            }
            else if (option_person == 2)
            {
                Console.Clear();
                Console.WriteLine("\nWelcome Mrs / Ms Borrower\n" +
                  "Please choose your option  : \n\n" +
                  "Enter : ( 1 ) Books\n" +
                  "Enter : ( 2 ) NewsPapers\n");
                Console.Write("Enter your option :");
                Borrower();
            }
            else if (option_person == 3)
            {
                Console.WriteLine("Thank you \n" + " ** Exited from the application **");

            }
        }
        
        public static void Show_Book_List()
        {
            Console.WriteLine("Book id " + "    Book name " + "  Book Count");
            foreach (Book_Details find_Id in bookList)
            {
                Console.WriteLine("  {0}   " + "        {1}     " + "          {2}   ", find_Id.bookId, find_Id.bookName, find_Id.bookCount);
            }
           
        }
        public static void Show_News_Paper_List()
        {
            Console.WriteLine("News Paper id " + "    News Paper name " + "  News Papers Count");
            foreach (News_Paper_Details find_Id in newspaperList)
            {

                Console.WriteLine("  {0}   " + "          {1}     " + "             {2}   ", find_Id.News_Paper_Id, find_Id.News_Paper_Name, find_Id.News_Paper_Count);
            }
        }
        public static void Librarian()
        {
            int Books_Newspapers_option = int.Parse(Console.ReadLine());
            bool run = true;
            while (run)
            {
                if (Books_Newspapers_option == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\n **  Librarian Book Menu  **\n" +
                    "Please choose your option\n\n" +
                    "Enter : ( 1 ) Add book\n" +
                    "Enter : ( 2 ) Delete book\n" +
                    "Enter : ( 3 ) Close\n");

                    Console.Write("Choose your option from Librarian Menu :");

                    int Add_Del_option_Book = int.Parse(Console.ReadLine());

                    if (Add_Del_option_Book == 1)
                    {
                        Add_Book();
                    }
                    else if (Add_Del_option_Book == 2)
                    {
                        Delete_Book();
                    }
                    else if (Add_Del_option_Book == 3)
                    {
                        Console.WriteLine("Thank you");
                        run = false;
                        Welcome();

                    }
                    else
                    {
                        Console.WriteLine("Invalid option\nRetry !!!");

                    }
                }

                else if (Books_Newspapers_option == 2)
                {
                   // Console.WriteLine("****  News papers Section  *****");
                   // Console.WriteLine("No NewsPapers are available to do Modifications");
                    Console.Clear();
                    Console.WriteLine("\nLibrarian News Paper Menu\n" +
                    "Please choose your option\n\n" +
                    "Enter : ( 1 ) Add News Paper\n" +
                    "Enter : ( 2 ) Delete News Paper\n" +
                    "Enter : ( 3 ) Close\n");

                    Console.Write("Choose your option from menu :");

                    int Add_Del_option_NewsPaper = int.Parse(Console.ReadLine());

                    if (Add_Del_option_NewsPaper == 1)
                    {
                        Add_News_Paper();
                    }
                    else if (Add_Del_option_NewsPaper == 2)
                    {
                        Delete_News_Paper();
                    }
                    else if (Add_Del_option_NewsPaper == 3)
                    {
                        Console.WriteLine("Thank you");
                        run = false;
                        Welcome();
                    }
                    else
                    {
                        Console.WriteLine("Invalid option\nRetry !!!");

                    }
                }
            }
        }
        public static void Borrower()
        {
            int Books_Newspapers_option = int.Parse(Console.ReadLine());
            bool run = true;
            while (run)
            {
                if (Books_Newspapers_option == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\n **  Borrower Book Menu  **\n" +
                    "Please choose your option\n\n" +
                    "Enter : ( 1 ) Borrow Book\n" +
                    "Enter : ( 2 ) Return Book\n" +
                    "Enter : ( 3 ) Find Book Availabilty \n" +
                    "Enter : ( 4 ) Show Book List \n" +
                    "Enter : ( 5 ) Close\n");

                    Console.Write("Choose your option from Borrower Menu :");

                    int Add_Del_option_Book = int.Parse(Console.ReadLine());

                    if (Add_Del_option_Book == 1)
                    {
                        Borrow_Book_From_Library();
                    }
                    else if (Add_Del_option_Book == 2)
                    {
                        Return_Book_To_Library();
                    }
                    else if (Add_Del_option_Book == 3)
                    {
                        Find_Book_Availability();
                    }
                    else if (Add_Del_option_Book == 4)
                    {
                        Show_Book_List();
                    }
                    else if (Add_Del_option_Book == 5)
                    {
                        Console.WriteLine("Thank you");
                        run = false;
                        Welcome();

                    }
                    else
                    {
                        Console.WriteLine("Invalid option\nRetry !!!");

                    }
                }

                else if (Books_Newspapers_option == 2)
                {

                    Console.Clear();
                    Console.WriteLine("\nBorrower News Paper Menu\n" +
                    "Please choose your option\n\n" +
                    "Enter : ( 1 ) Borrow News Paper\n" +
                    "Enter : ( 2 ) Return News Paper\n" +
                    "Enter : ( 3 ) Find News Paper Availabilty\n" +
                    "Enter : ( 4 ) Show News Paper List\n" +
                    "Enter : ( 5 ) Close\n");

                    Console.Write("Choose your option from menu :");

                    int Add_Del_option_NewsPaper = int.Parse(Console.ReadLine());

                    if (Add_Del_option_NewsPaper == 1)
                    {
                        Borrow_Newspaper_From_Library();
                    }
                    else if (Add_Del_option_NewsPaper == 2)
                    {
                        Return_Newspaper_To_Library();
                    }
                    else if (Add_Del_option_NewsPaper == 3)
                    {
                        Find_Newspaper_Availability();
                    }
                    else if (Add_Del_option_NewsPaper == 4)
                    {
                        Show_News_Paper_List();
                    }
                    else if (Add_Del_option_NewsPaper == 5)
                    {
                        Console.WriteLine("Thank you");
                        run = false;
                        Welcome();
                    }
                    else
                    {
                        Console.WriteLine("Invalid option\nRetry !!!");

                    }
                }
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
            Console.WriteLine("Added Books Successfully");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Add_News_Paper()
        {
            News_Paper_Details Paper = new News_Paper_Details();
            Console.WriteLine("News Paper Id:{0}", Paper.News_Paper_Id = newspaperList.Count + 1);
            Console.Write("News Paper Name:");
            Paper.News_Paper_Name = Console.ReadLine();
            Console.Write("Number of News Papers:");
            Paper.Ref_Y = Paper.News_Paper_Count = int.Parse(Console.ReadLine());
            newspaperList.Add(Paper);
            Console.WriteLine("Added News Papers Successfully");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Delete_Book()
        {
            Book_Details book = new Book_Details();
            Console.Write("Enter Book id to be deleted : ");

            int Delete = int.Parse(Console.ReadLine());

            if (bookList.Exists(value => value.bookId == Delete))
            {
                bookList.RemoveAt(Delete - 1);
                Console.WriteLine("Book id - {0} has been deleted", Delete);
            }
            else
            {
                Console.WriteLine("Invalid Book id");
            }
            bookList.Add(book);
            Console.ReadKey();
            Console.Clear();
        }
        public static void Delete_News_Paper()
        {
            News_Paper_Details paper = new News_Paper_Details();
            Console.Write("Enter News Paper id to be deleted : ");

            int Delete = int.Parse(Console.ReadLine());

            if (newspaperList.Exists(val => val.News_Paper_Id == Delete))
            {
                newspaperList.RemoveAt(Delete - 1);
                Console.WriteLine("News Paper id - {0} has been deleted", Delete);
            }
            else
            {
                Console.WriteLine("Invalid News Paper id");
            }
            newspaperList.Add(paper);
            Console.ReadKey();
            Console.Clear();
        }
        public static void Find_Book_Availability()
        {
            Book_Details book = new Book_Details();
            Console.Write("Search by BOOK id :");
            int search = int.Parse(Console.ReadLine());

            if (bookList.Exists(val => val.bookId == search))
            {
                foreach (Book_Details find_Id in bookList)
                {
                    if (find_Id.bookId == search)
                    {
                        Console.WriteLine("Book id :{0}\n" +
                        "Book name :{1}\n" +
                        "Book Count :{2}", find_Id.bookId, find_Id.bookName, find_Id.bookCount);
                    }
                    else
                    {
                        Console.WriteLine("Books are Not Available ..!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", search);
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void Find_Newspaper_Availability()
        {
           // News_Paper_Details paper = new News_Paper_Details();
            Console.Write("Search by News Paper id :");
            int search = int.Parse(Console.ReadLine());

            if (newspaperList.Exists(val => val.News_Paper_Id == search))
            {
                foreach (News_Paper_Details find_Id in newspaperList)
                {
                    if (find_Id.News_Paper_Id == search)
                    {
                        Console.WriteLine("News Paper id :{0}\n" +
                        "News Paper name :{1}\n" +
                        "News Paper Count :{2}", find_Id.News_Paper_Id, find_Id.News_Paper_Name, find_Id.News_Paper_Count);
                    }
                    else
                    {
                        Console.WriteLine("News Papers are Not Available ..!");
                    }
                }
            }
            else
            {
                Console.WriteLine("News Paper id {0} not found", search);
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void Borrow_Book_From_Library()
        {
            Borrow_Details borrow = new Borrow_Details();
            Console.WriteLine("User id : {0}", (borrow.userId = borrowList.Count + 1));
            Console.Write("Borrower Name :");
            borrow.userName = Console.ReadLine();
            Console.Write("Book id :");
            borrow.borrowBook_newspaperId = int.Parse(Console.ReadLine());
            Console.Write("Number of Books : ");
            borrow.borrowCount = int.Parse(Console.ReadLine());
            borrow.borrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} ", borrow.borrowDate.ToShortDateString());

            if (bookList.Exists(val => val.bookId == borrow.borrowBook_newspaperId))
            {
                foreach (Book_Details find_Id in bookList)
                {
                    if (find_Id.bookCount >= find_Id.bookCount - borrow.borrowCount && find_Id.bookCount - borrow.borrowCount >= 0)
                    {
                        if (find_Id.bookId == borrow.borrowBook_newspaperId)
                        {
                            find_Id.bookCount = find_Id.bookCount - borrow.borrowCount;
                            Console.WriteLine("Books Borrowed Successfully");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only {0} books are found", find_Id.bookCount);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", borrow.borrowBook_newspaperId);
            }
            borrowList.Add(borrow);
            Console.ReadKey();
            Console.Clear();
        }
        public static void Borrow_Newspaper_From_Library()
        {
            Borrow_Details borrow = new Borrow_Details();
            Console.WriteLine("User id : {0}", (borrow.userId = borrowList.Count + 1));
            Console.Write("Borrower Name :");

            borrow.userName = Console.ReadLine();

            Console.Write("News Paper id :");
            borrow.borrowBook_newspaperId = int.Parse(Console.ReadLine());
            Console.Write("Number of News Papers : ");
            borrow.borrowCount = int.Parse(Console.ReadLine());
            borrow.borrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} ", borrow.borrowDate.ToShortDateString());

            if (newspaperList.Exists(val => val.News_Paper_Id == borrow.borrowBook_newspaperId))
            {
                foreach (News_Paper_Details find_Id in newspaperList)
                {
                    if (find_Id.News_Paper_Count >= find_Id.News_Paper_Count - borrow.borrowCount && find_Id.News_Paper_Count - borrow.borrowCount >= 0)
                    {
                        if (find_Id.News_Paper_Id == borrow.borrowBook_newspaperId)
                        {
                            find_Id.News_Paper_Count = find_Id.News_Paper_Count - borrow.borrowCount;
                            Console.WriteLine("News Papers Borrowed Successfully");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only {0} news papers are found", find_Id.News_Paper_Count);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("News Paper id {0} not found", borrow.borrowBook_newspaperId);
            }
            borrowList.Add(borrow);
            Console.ReadKey();
            Console.Clear();
        }
        public static void Return_Book_To_Library()
        {
            Book_Details book = new Book_Details();
            Console.WriteLine("Enter following details :");

            Console.Write("Book id : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of Books:");
            int returnCount = int.Parse(Console.ReadLine());

            if (bookList.Exists(val => val.bookId == returnId))
            {
                foreach (Book_Details addReturnBookCount in bookList)
                {
                    if (addReturnBookCount.Ref_x >= returnCount + addReturnBookCount.bookCount)
                    {
                        if (addReturnBookCount.bookId == returnId)
                        {
                            addReturnBookCount.bookCount = addReturnBookCount.bookCount + returnCount;
                            Console.WriteLine("Books Returned Successfully");
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
            Console.ReadKey();
            Console.Clear();
        }
        public static void Return_Newspaper_To_Library()
        {
            News_Paper_Details paper = new News_Paper_Details();
            Console.WriteLine("Enter following details :");

            Console.Write("News Paper id : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of News Papers :");
            int returnCount = int.Parse(Console.ReadLine());

            if (newspaperList.Exists(y => y.News_Paper_Id == returnId))
            {
                foreach (News_Paper_Details addReturnNewspaperCount in newspaperList)
                {
                    if (addReturnNewspaperCount.Ref_Y >= returnCount + addReturnNewspaperCount.News_Paper_Count)
                    {
                        if (addReturnNewspaperCount.News_Paper_Id == returnId)
                        {
                            addReturnNewspaperCount.News_Paper_Count = addReturnNewspaperCount.News_Paper_Count + returnCount;
                            Console.WriteLine("News Papers Returned Successfully");
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
                Console.WriteLine("News Paper id {0} not found", returnId);
            }
            Console.ReadKey();
            Console.Clear();
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
        public int borrowBook_newspaperId;
        public DateTime borrowDate;
        public int borrowCount;
    }
    class News_Paper_Details
    {
        public int News_Paper_Id;
        public string News_Paper_Name;
        public int News_Paper_Count;
        public int Ref_Y;
    }
}

