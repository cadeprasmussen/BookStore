using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{


    public class EFBookRepository : IBookRepository
    {
        //Creating a private variable to be used in the Repository variable
        private BookDBContext _context;


        //Creating a repository of book context
        public EFBookRepository (BookDBContext context)
        {
            _context = context;
        }

        //Making a querable lambda fucntion of books
        public IQueryable<Book> Books => _context.Books;
    }
}
