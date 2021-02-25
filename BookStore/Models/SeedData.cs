using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookDBContext>();


            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        BookTitle = "Les Miserables",
                        AuthorFirstName = "Victor",
                        AuthorLastName = "Hugo",
                        BookPublisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        NumPages = 1488,
                        Price = 9.95F

                    },
                    new Book
                    {
                        BookTitle = "Team of Rivals",
                        AuthorFirstName = "Doris",
                        AuthorMiddleName = "Kearns",
                        AuthorLastName = "Goodwin",
                        BookPublisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        NumPages = 944,
                        Price = 14.58F
                    },
                    new Book
                    {
                        BookTitle = "The Snowball",
                        AuthorFirstName = "Alice",
                        AuthorLastName = "Schroeder",
                        BookPublisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        NumPages = 832,
                        Price = 21.54F
                    },
                    new Book
                    {
                        BookTitle = "American Ulysses",
                        AuthorFirstName = "Ronald",
                        AuthorMiddleName = "C.",
                        AuthorLastName = "White",
                        BookPublisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        NumPages = 864,
                        Price = 11.61F
                    },
                    new Book
                    {
                        BookTitle = "Unbroken",
                        AuthorFirstName = "Laura",
                        AuthorLastName = "Hillenbrand",
                        BookPublisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        NumPages = 528,
                        Price = 13.33F
                    },
                    new Book
                    {
                        BookTitle = "The Great Train Robbery",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Crichton",
                        BookPublisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        NumPages = 288,
                        Price = 15.95F
                    },
                    new Book
                    {
                        BookTitle = "Deep Work",
                        AuthorFirstName = "Cal",
                        AuthorLastName = "Newport",
                        BookPublisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        NumPages = 304,
                        Price = 14.99F
                    },
                    new Book
                    {
                        BookTitle = "It's Your Ship",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Abrashoff",
                        BookPublisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        NumPages = 240,
                        Price = 21.66F
                    },
                    new Book
                    {
                        BookTitle = "The Virgin Way",
                        AuthorFirstName = "Richard",
                        AuthorLastName = "Branson",
                        BookPublisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        NumPages = 400,
                        Price = 29.16F
                    },
                    new Book
                    {
                        BookTitle = "Sycamore Row",
                        AuthorFirstName = "John",
                        AuthorLastName = "Grisham",
                        BookPublisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        NumPages = 642,
                        Price = 15.03F
                    },
                    new Book
                    {
                        BookTitle = "Harry Potter and the Deathly Hallows",
                        AuthorFirstName = "Joanne",
                        AuthorMiddleName = "K",
                        AuthorLastName = "Rowling",
                        BookPublisher = "Scholastic",
                        ISBN = "978-0545029377",
                        Classification = "Fiction",
                        Category = "Magic",
                        NumPages = 759,
                        Price = 8.47F
                    },
                    new Book
                    {
                        BookTitle = "The Return of the King",
                        AuthorFirstName = "John",
                        AuthorMiddleName = "Ronald Reuel",
                        AuthorLastName = "Tolkien",
                        BookPublisher = "George Allen & Unwin",
                        ISBN = "978-0358380252",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        NumPages = 416,
                        Price = 11.19F
                    },
                    new Book
                    {
                        BookTitle = "Crime and Punishment",
                        AuthorFirstName = "Fyodor",
                        AuthorLastName = "Dostoevsky",
                        BookPublisher = "Vintage",
                        ISBN = "978-0679734505",
                        Classification = "Fiction",
                        Category = "Crime",
                        NumPages = 531,
                        Price = 15.95F
                    }
                );

                context.SaveChanges();
            }
        }

    }
}
