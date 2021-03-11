using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Infastructure;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStore.Pages.Shared
{
    public class CartModel : PageModel
    {

        private IBookRepository repository;

        //Constructor
        public CartModel (IBookRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        //Properties
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
/*            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();*/
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            /*            Book book = repository.Books.FirstOrDefault(b => b.BookId == bookId);

                        Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

                        Cart.AddItem(book, 1);

                        HttpContext.Session.SetJson("cart", Cart);

                        return RedirectToPage(new { returnUrl = returnUrl });*/

            Book book = repository.Books
                .FirstOrDefault(b => b.BookId == bookId);
            Cart.AddItem(book, 1);
            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl => cl.Book.BookId == bookId).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
