using System;
using System.Data.Entity;//MovieDBContext繼承了Entity Framework中的DbContext的Class，為了能夠引用DbContext和DbSet，必須在頂部添加using語句

namespace MyMVC.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
    public class MovieDBContext : DbContext//MovieDBContext繼承了Entity Framework中的DbContext的Class，為了能夠引用DbContext和DbSet，必須在頂部添加using語句
    {
        public DbSet<Movie> Movies { get; set; }
    }
}