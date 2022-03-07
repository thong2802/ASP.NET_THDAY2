using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH_LAB3.Models;

namespace TH_LAB3.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListBook()
        {
            var books = new List<string>();
            books.Add("Head First Design Pattern - Author Thong");
            books.Add("Head First Design Pattern - Author Thong");
            books.Add("Head First Design Pattern - Author Thong");
            ViewBag.Books = books;
            return View();
        }
        public ActionResult ListBookModel()
        {
            var books = new List<Book>();
            books.Add(new Book(1, "Head First Design Pattern", "Learn More 23 Design Pattern Popular", "Kathy Sierra", "/Content/Images/book1.png"));
            books.Add(new Book(2, "Head First Kotlin", "Head First Kotlin is a complete introduction to coding in Kotlin...", "Dawn Griffiths", "/Content/Images/book2.png"));
            books.Add(new Book(3, "Head First Java", "Head First Javacombines puzzles, strong visuals, mysteries", "Kathy Sierra", "/Content/Images/book3.png"));
            books.Add(new Book(4, "Cracking Coding Interview", "CodingInterview.com gives you all the information...", "Thong Backend Engineer at ZaloPay", "/Content/Images/book4.png"));
            return View(books);
        }

        // GET BOOK / EDITbOOK/ID
        public ActionResult EditBook(int id)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "Head First Design Pattern", "Learn More 23 Design Pattern Popular", "Kathy Sierra", "/Content/Images/book1.png"));
            books.Add(new Book(2, "Head First Kotlin", "Head First Kotlin is a complete introduction to coding in Kotlin...", "Dawn Griffiths", "/Content/Images/book2.png"));
            books.Add(new Book(3, "Head First Java", "Head First Javacombines puzzles, strong visuals, mysteries", "Kathy Sierra", "/Content/Images/book3.png"));
            books.Add(new Book(4, "Cracking Coding Interview", "CodingInterview.com gives you all the information...", "Thong Backend Engineer at ZaloPay", "/Content/Images/book4.png"));


            // check if not exit
            Book book = new Book();
            foreach(Book b in books)
            {
                if(b.Id == id)
                {
                    book = b;
                    break;
                }
            }
            if(book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // Post: Book/EditBook/id
        [HttpPost, ActionName("EditBook")]
        [ValidateAntiForgeryToken]

        public ActionResult EditBook(int id, string Title, string Description, string Author, string Image_Cover)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "Head First Design Pattern", "Learn More 23 Design Pattern Popular", "Kathy Sierra", "/Content/Images/book1.png"));
            books.Add(new Book(2, "Head First Kotlin", "Head First Kotlin is a complete introduction to coding in Kotlin...", "Dawn Griffiths", "/Content/Images/book2.png"));
            books.Add(new Book(3, "Head First Java", "Head First Javacombines puzzles, strong visuals, mysteries", "Kathy Sierra", "/Content/Images/book3.png"));
            books.Add(new Book(4, "Cracking Coding Interview", "CodingInterview.com gives you all the information...", "Thong Backend Engineer at ZaloPay", "/Content/Images/book4.png"));

            if (id == null)
            { 
                return HttpNotFound();
            }
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    b.Title = Title;
                    b.Description = Description;
                    b.Author = Author;
                    b.Image_Cover = Image_Cover;
                    break;
                }
            }
            return View("ListBookModel", books);
        }

        public ActionResult CreateBook()
        {
            return View();
        }
        [HttpPost, ActionName("CreateBook")]
        [ValidateAntiForgeryToken]

        public ActionResult CreateBook([Bind(Include = "Id, Title, Description, Author, Image_Cover")] Book book)
        {

            var books = new List<Book>();
            books.Add(new Book(1, "Head First Design Pattern", "Learn More 23 Design Pattern Popular", "Kathy Sierra", "/Content/Images/book1.png"));
            books.Add(new Book(2, "Head First Kotlin", "Head First Kotlin is a complete introduction to coding in Kotlin...", "Dawn Griffiths", "/Content/Images/book2.png"));
            books.Add(new Book(3, "Head First Java", "Head First Javacombines puzzles, strong visuals, mysteries", "Kathy Sierra", "/Content/Images/book3.png"));
            books.Add(new Book(4, "Cracking Coding Interview", "CodingInterview.com gives you all the information...", "Thong Backend Engineer at ZaloPay", "/Content/Images/book4.png"));

            try
            {
                if(ModelState.IsValid)
                {
                    // THEM SACH MOI
                    books.Add(book);
                }
            }
            catch (Exception ex /* dex */)
            {
                ModelState.AddModelError("", "Error Save Data");
            }
            // tra ve trang xcem sach voi new danh sach moi
            return View("ListBookModel", books);
        }

  
        public ActionResult Details(int id)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "Head First Design Pattern", "Learn More 23 Design Pattern Popular", "Kathy Sierra", "/Content/Images/book1.png"));
            books.Add(new Book(2, "Head First Kotlin", "Head First Kotlin is a complete introduction to coding in Kotlin...", "Dawn Griffiths", "/Content/Images/book2.png"));
            books.Add(new Book(3, "Head First Java", "Head First Javacombines puzzles, strong visuals, mysteries", "Kathy Sierra", "/Content/Images/book3.png"));
            books.Add(new Book(4, "Cracking Coding Interview", "CodingInterview.com gives you all the information...", "Thong Backend Engineer at ZaloPay", "/Content/Images/book4.png"));


            // check if not exit
            Book book = new Book();
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    book = b;
                    break;
                }
            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }


        // delete
        public ActionResult Delete(int id)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "Head First Design Pattern", "Learn More 23 Design Pattern Popular", "Kathy Sierra", "/Content/Images/book1.png"));
            books.Add(new Book(2, "Head First Kotlin", "Head First Kotlin is a complete introduction to coding in Kotlin...", "Dawn Griffiths", "/Content/Images/book2.png"));
            books.Add(new Book(3, "Head First Java", "Head First Javacombines puzzles, strong visuals, mysteries", "Kathy Sierra", "/Content/Images/book3.png"));
            books.Add(new Book(4, "Cracking Coding Interview", "CodingInterview.com gives you all the information...", "Thong Backend Engineer at ZaloPay", "/Content/Images/book4.png"));


            // check if not exit
            Book book = new Book();
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    book = b;
                    break;
                }
            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "Head First Design Pattern", "Learn More 23 Design Pattern Popular", "Kathy Sierra", "/Content/Images/book1.png"));
            books.Add(new Book(2, "Head First Kotlin", "Head First Kotlin is a complete introduction to coding in Kotlin...", "Dawn Griffiths", "/Content/Images/book2.png"));
            books.Add(new Book(3, "Head First Java", "Head First Javacombines puzzles, strong visuals, mysteries", "Kathy Sierra", "/Content/Images/book3.png"));
            books.Add(new Book(4, "Cracking Coding Interview", "CodingInterview.com gives you all the information...", "Thong Backend Engineer at ZaloPay", "/Content/Images/book4.png"));

            // check if not exit
            Book book = new Book();
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    books.Remove(b);
                    break;
                }
            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }


    }
}