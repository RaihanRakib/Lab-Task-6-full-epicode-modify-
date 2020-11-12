using System;

namespace LabTask
{

    class Programgpa
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Write your name:");
            String na = Console.ReadLine();
            Console.WriteLine("Write your ID:");
            String i = Console.ReadLine();
            Console.WriteLine("Write your Department:");
            String dp = Console.ReadLine();
            Console.WriteLine("Write your CGPA:");
            float c = Console.Read();
            Students s = new Students(na, i, dp, c);

            Console.WriteLine("Enter your accout info");
            Console.WriteLine("Enter your accout Name: ");
            String accnm = Console.ReadLine();
            Console.WriteLine("Enter your accout ID: ");
            String accid = Console.ReadLine();

            Console.WriteLine("What you want to do: ");
            Console.WriteLine("1. Deposit.\n2.Withdrow. \n3.Transfer.\n4.Show Blance.\n5.Exit");
            String optn = Console.ReadLine();
            int val = 0;
            Account ac = new Account(accnm, accid, val);
            int depam, wa, trans;
            switch (optn)
            {
                case "1":
                    Console.WriteLine("Enter your Deposit amount: ");
                    depam = Console.Read();
                    ac.deposite(depam);
                    break;
                case "2":
                    Console.WriteLine("Enter your Withdrow amount: ");
                    wa = Console.Read();
                    ac.withdrow(wa);
                    break;
                case "3":
                    Console.WriteLine("Enter your Transfer amount: ");
                    trans = Console.Read();
                    Console.WriteLine("Enter your Transfer ID: ");
                    //Account rcv = 1;
                   // ac.Transfer(trans, rcv);
                    break;
                case "4":
                    ac.ShowBlance();
                    break;
                case "5":
                    Console.WriteLine("Thank You");
                    break;
                default:
                    Console.WriteLine("Wrong Key word \nYou can add only 1-5 value ");
                    break;
            }
            Console.WriteLine("Enter Library name: ");
            String ln = Console.ReadLine();
            Console.WriteLine("Enter Library Addres: ");
            String la = Console.ReadLine();
            Console.WriteLine("Enter Library Bookname: ");
            String[] lb = Console.ReadLine();
            Console.WriteLine("Enter Library Total book: ");
            int tb = Console.Read();
            Library lib = new Library(ln, la, lb, tb);
            Console.WriteLine("Enter bookName: ");
            String bookName = Console.ReadLine();
            Console.WriteLine("Enter bookAuthor: ");
            String bookAuthor = Console.ReadLine();
            Console.WriteLine("Enter bookId: ");
            String bookId = Console.ReadLine();
            Console.WriteLine("Enter bookType: ");
            String bookType = Console.ReadLine();
            Console.WriteLine("Enter bookCopy: ");
            int bookCopy = Console.Read();
            Book bk = new Book(bookName, bookAuthor, bookId, bookType, bookCopy);

            lib.Showallinfo();
            s.ShowInfo();
        }
    }
}
