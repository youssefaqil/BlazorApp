using BlazorApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    interface IAuthorService
    {
        Task<List<Author>> GetAuthors();
        Task<Author> GetAuthorById(int authorId);
        Task<bool> SaveAuthor(Author author);
        Task<bool> DeleteAuthor(string authorId);
        DateTime GetCreateDate();
        string GetVersion();
    }
}
