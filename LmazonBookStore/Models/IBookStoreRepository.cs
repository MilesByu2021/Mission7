using System;
using System.Linq;

namespace LmazonBookStore.Models
{
    public interface IBookStoreRepository
    {
        IQueryable<Books> Books { get; }
    }
}
