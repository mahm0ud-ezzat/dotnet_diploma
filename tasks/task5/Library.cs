using LibararyManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LibararyMangementSystem
{
    class Library()
    {
        public List<Book> Books { get; set; } = [];
        public List<List<string>> Names { get; set; } = [];
        // this list to store companat words of
        // every book name to achive the logic you ask about in main  
        /* i solved it but  i realized the add is the key so i returned bak and 
         solve it agin i tryed to use struct as a search data type that contain thge index and avaliabilty
        and searched by using two for loop  tell me feed back about way of thinking thank you :)
    */
        // searhdt here just to clearify the way i was thinking on it that search function return 


        public bool AddBook(Book book)
        {
            if (book != null)
            {
                // i know that wasnot the best solution i tried to cast array of string dirct  to list<string> and i cant and searched 
                // about that tell me if there a solution better than that or tell me a hint to find it /:
                List<string> l = new List<string>(book.Title.ToLower().Split(" "));
                Names.Add(l);
                Books.Add(book);
                book.IsAvaliable = true; // that mean its avaliable in the libarary ;

                return true;
            }
            return false;
        }
        // we can use something like sorted set   in c++ and using binary search but i dont know it here  
        public int SerachForBook(string s) // paramter he is the name or isbn or part of of name or full author name 
        {
            s = s.ToLower();
            int i = 0;
            if (Books == null || Books.Count == 0)
            {
                return -1;
            }
            
            
                if (Books[i].Isbn.ToLower() == s || Books[i].Title.ToLower() == s || Books[i].Author.ToLower() == s)
                {
                    return i;
                }
                for (i = 0; i < Names.Count; ++i)
                {
                    for (int j = 0; j < Names[i].Count; j++)
                    {
                        if (s == Names[i][j])
                        {
                            return i;
                        }
                    }
                }
            
                return -1; 

        }
        // waiting feed back for search function 
        public bool BorrowBook(string book) // paramter here is the name or isbn or part of name 
        {
            int index = SerachForBook(book);

            if (book != null && index  != -1 && Books[index].IsAvaliable && !Books[index].IsBorrowed)
            {
                Books[index].IsBorrowed = true;
                Books[index].BorrowedDate = DateTime.Now;
                Books[index].ReturnedData = DateTime.Now.AddDays(6);
                Console.WriteLine($"the book borrowed succesfuly , please return it at time {Books[index].ReturnedData} ");

                return true;
            }
            Console.WriteLine("the book arenot there maybe it borrowd or not avaliable at our libarary  try to reverse it ");
            return false; 
        }

        public bool ReturnBook(string book)
        {
            int index = SerachForBook(book);

            if (book != null && index != -1 && Books[index].IsAvaliable && Books[index].IsBorrowed )
            {

                Books[index].IsBorrowed = false ;
                Console.WriteLine("the book returned successfully ");

                return true;
            }
            Console.WriteLine("the book isn,t what you have to return or not our book ,check it,");

            return false;

        }
        public bool Reserve(string book)
        {
            int index = SerachForBook(book); 
            if (book != null && index != -1 && Books[index].IsAvaliable && Books[index].IsBorrowed)
            {
                Console.WriteLine($"The book revserve successfully you can take the book at {Books[index].ReturnedData}");
                return true;
            }

            return false; 
        }
    }

}
