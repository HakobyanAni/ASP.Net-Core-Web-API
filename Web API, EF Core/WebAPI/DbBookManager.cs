using Data_Access_Layer;
using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI
{
    public class DbBookManager : IDisposable
    {
        private EFContext MyDBContext;

        public DbBookManager()
        {
            MyDBContext = new EFContext();
        }

        public List<BookModel> GetAllBooks()
        {
            List<Book> dbBooks = MyDBContext.Books.ToList();
            return Helper.DBBooksListToBooksModelList(dbBooks);
        }

        public BookModel GetABook(int id)
        {
            Book dbBooks = MyDBContext.Books.Find(id);
            if (dbBooks == null)
            {
                BookModel nullModel = new BookModel();
                nullModel = null;
                return nullModel;
            }
            return Helper.DBBookToBooksModel(dbBooks);
        }

        public bool AddBook(BookModel book)
        {
            try
            {
                MyDBContext.Books.Add(Helper.BooksModelToDBBook(book));
                MyDBContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditBook(int id, BookModel book)
        {
            Book dbBooks = MyDBContext.Books.Find(id);
            if (dbBooks == null)
            {
                return false;
            }

            dbBooks.Title = book.Title;
            dbBooks.Genre = book.Genre;
            dbBooks.NumberOfPages = book.NumberOfPages;
            dbBooks.PublicationDate = book.PublicationDate;

            MyDBContext.Entry(dbBooks).State = EntityState.Modified;
            MyDBContext.SaveChanges();

            return true;
        }

        public bool DeleteBook(int id)
        {
            var book = MyDBContext.Books.Find(id);
            if (book == null)
            {
                return false;
            }

            MyDBContext.Books.Remove(book);
            MyDBContext.SaveChanges();
            return true;
        }

        public void Dispose()
        {
            MyDBContext.Dispose();
        }
    }
}
