using System;
using System.Linq;

namespace LmazonBookStore.Models.ViewModels
{
    public class BooksViewModel
    {
        public IQueryable<Books> Books { get; set; }

        public PageInfo PageInfo { get; set; }
    }
}
