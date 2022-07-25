using System;

namespace cs_con_LibManagementSys
{
    internal class Program
    {
        public static void Startmeathod(int For_Person_Identify)
        {
            if (For_Person_Identify == 1)
            {
                Console.Clear();
                Console.WriteLine("You are a Librarian");
               // Librarian_Menu.Librarian__Option();
            }
            else if (For_Person_Identify == 2)
            {
                Console.Clear();
                Console.WriteLine("Borrower");
            }
            else
            {
                Console.WriteLine("You Chosen a Wrong Option, Please Choose Again");
                Console.WriteLine();
                Console.WriteLine("Choose your option Here ");
                For_Person_Identify = int.Parse(Console.ReadLine());
                Startmeathod(For_Person_Identify);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***** Welcome to the Library Management System *********");
            Console.WriteLine();
            Console.WriteLine("MENU");
            Console.WriteLine();
            Console.WriteLine("Who Are you ? (Librarian / Borrower):");
            Console.WriteLine("If you are Librarian  : Click 1");
            Console.WriteLine("If you are Borrower  : Click 2");
            Console.WriteLine();
            Console.Write("Choose your option Here :");
            int value = int.Parse(Console.ReadLine());
            Startmeathod(value);
        }
    }
}
