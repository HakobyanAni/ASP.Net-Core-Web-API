using System.Collections.Generic;
using Data_Access_Layer;
using Data_Access_Layer.Entities;
using WebAPI.Models;

namespace WebAPI
{
    public static class Helper
    {
        public static List<AuthorModel> DBAuthorsListToAuthorsModelList(List<Author> dbAuthors)
        {
            List<AuthorModel> modelAuthors = new List<AuthorModel>();
            foreach (var dbAuthor in dbAuthors)
            {
                AuthorModel temp = DBAuthorsToAuthorsModel(dbAuthor);
                modelAuthors.Add(temp);
            }
            return modelAuthors;
        }

        public static AuthorModel DBAuthorsToAuthorsModel(Author dbAuthor)
        {
            AuthorModel temp = new AuthorModel();
            temp.FirstName = dbAuthor.FirstName;
            temp.LastName = dbAuthor.LastName;
            temp.BirthDeathDate = dbAuthor.BirthDeathDate;
            temp.Nationality = dbAuthor.Nationality;
            temp.Books = dbAuthor.Books;
            return temp;
        }

        public static Author AuthorsModelToDBAuthors(AuthorModel authorModel)
        {
            Author temp = new Author();
            temp.FirstName = authorModel.FirstName;
            temp.LastName = authorModel.LastName;
            temp.BirthDeathDate = authorModel.BirthDeathDate;
            temp.Nationality = authorModel.Nationality;
            temp.Books = authorModel.Books;
            return temp;
        }

        public static List<BookModel> DBBooksListToBooksModelList(List<Book> dbBooks)
        {
            List<BookModel> modelBooks = new List<BookModel>();
            foreach (var dbBook in dbBooks)
            {
                BookModel temp = DBBookToBooksModel(dbBook);
                modelBooks.Add(temp);
            }
            return modelBooks;
        }

        public static BookModel DBBookToBooksModel(Book dbBook)
        {
            BookModel temp = new BookModel();
            temp.Title = dbBook.Title;
            temp.Genre = dbBook.Genre;
            temp.PublicationDate = dbBook.PublicationDate;
            temp.NumberOfPages = dbBook.NumberOfPages;
            return temp;
        }

        public static Book BooksModelToDBBook(BookModel bookModel)
        {
            Book temp = new Book();
            temp.Title = bookModel.Title;
            temp.Genre = bookModel.Genre;
            temp.PublicationDate = bookModel.PublicationDate;
            temp.NumberOfPages = bookModel.NumberOfPages;
            return temp;
        }
    }
}
