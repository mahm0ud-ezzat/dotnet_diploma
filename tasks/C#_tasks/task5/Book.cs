using LibararyManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibararyMangementSystem
{
    class Book(string title , string author,string isbn  )
    {
        public string Title { get; private set; } = title;
        public string Author { get; private set; } = author;
        public string Isbn { get;private set; } = isbn;
        public bool IsAvaliable { get; set; } = false; // is avaliable in the libaray at all  
        public bool IsBorrowed { get; set; } = false;
        // i searched aboput that i tried to like applay fine at being late when return book  like my assignment :):) 
        // but i cant so i make a reverse when a book is borrowed 
        //waiting for your feed back and thank you 
        public DateTime? BorrowedDate { get; set; } = null;
        public DateTime? ReturnedData { get; set; } = null; 
        

    }
}
