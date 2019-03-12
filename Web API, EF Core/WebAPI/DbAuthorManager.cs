using Data_Access_Layer;
using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI
{
    public class DbAuthorManager : IDisposable
    {
        private EFContext MyDBContext;

        public DbAuthorManager()
        {
            MyDBContext = new EFContext();
        }

        public List<AuthorModel> GetAllAuthors()
        {
            List<Author> dbAuthors = MyDBContext.Authors.ToList();
            return Helper.DBAuthorsListToAuthorsModelList(dbAuthors);
        }

        public AuthorModel GetAnAuthor(int id)
        {
            Author dbAuthors = MyDBContext.Authors.Find(id);
            if (dbAuthors == null)
            {
                AuthorModel nullModel = new AuthorModel();
                nullModel = null;
                return nullModel;
            }
            return Helper.DBAuthorsToAuthorsModel(dbAuthors);
        }

        public bool AddAuthor(AuthorModel author)
        {
            try
            {
                MyDBContext.Authors.Add(Helper.AuthorsModelToDBAuthors(author));
                MyDBContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditAuthotr(int id, AuthorModel author)
        {
            Author dbAuthors = MyDBContext.Authors.Find(id);
            if (dbAuthors == null)
            {
                return false;
            }

            dbAuthors.FirstName = author.FirstName;
            dbAuthors.LastName = author.LastName;
            dbAuthors.Nationality = author.Nationality;
            dbAuthors.BirthDeathDate = author.BirthDeathDate;

            MyDBContext.Entry(dbAuthors).State = EntityState.Modified;
            MyDBContext.SaveChanges();
            return true;
        }

        public bool DeleteAuthor(int id)
        {
            var author = MyDBContext.Authors.Find(id);
            if (author == null)
            {
                return false;
            }

            MyDBContext.Authors.Remove(author);
            MyDBContext.SaveChanges();
            return true;
        }

        public void Dispose()
        {
            MyDBContext.Dispose();
        }
    }
}
