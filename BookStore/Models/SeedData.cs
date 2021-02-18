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
                        Price = 15.03F
                    }
                );

                context.SaveChanges();
            }
        }

    }
}
