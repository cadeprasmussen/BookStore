using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public interface IBookRepository
    {
        //Creating the quearyable variable to be used in the EFBookRepository
        IQueryable<Book> Books { get; }
    }
}
