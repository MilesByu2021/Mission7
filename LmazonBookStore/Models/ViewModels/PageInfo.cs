using System;
namespace LmazonBookStore.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumBooks { get; set; }

        public int BooksPerPage { get; set; }

        public int CurrentPage { get; set; }

        // Figure out how many pages we need
        // double means floating and cast into int 
        public int TotalPages => (int)Math.Ceiling((double)TotalNumBooks / BooksPerPage);
    }
}
