using Microsoft.AspNetCore.Mvc;
using RA.Library.Web.Models;

namespace RA.Library.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BookController : ControllerBase
    {
        public IEnumerable<Book> List()
        {
            var bookList = new List<Book>();
            bookList.Add(new Book
            {
                ID = 1,
                Title = "Vampire Diaries",
                AuthorName = "Mohamed Ramadan",
                Brief = "It's a really good book.",
                Description = "It's a really good book It's a really good book It's a really good book It's a really good book.",
                ImageUrl = "https://flxt.tmsimg.com/assets/p8182631_b1t_v9_aa.jpg",
            });
            bookList.Add(new Book
            {
                ID = 2,
                Title = "The Originals",
                AuthorName = "Mohamed Ramadan",
                Brief = "It's a really good book.",
                Description = "It's a really good book It's a really good book It's a really good book It's a really good book.",
                ImageUrl = "https://images.justwatch.com/poster/56995336/s718/the-originals.%7Bformat%7D",
            });
            bookList.Add(new Book
            {
                ID = 3,
                Title = "Arrow",
                AuthorName = "Mohamed Ramadan",
                Brief = "It's a really good book.",
                Description = "It's a really good book It's a really good book It's a really good book It's a really good book.",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTI0NTMwMDgtYTMzZC00YmJhLTg4NzMtMTc1NjI4MWY4NmQ4XkEyXkFqcGdeQXVyNTY3MTYzOTA@._V1_.jpg",
            });
            bookList.Add(new Book
            {
                ID = 4,
                Title = "The flash",
                AuthorName = "Mohamed Ramadan",
                Brief = "It's a really good book.",
                Description = "It's a really good book It's a really good book It's a really good book It's a really good book.",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDIzNzYwNTctZWY4Mi00YjQ2LWI5YWYtMzdmNDgwMGI4Yzk1XkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_FMjpg_UX1000_.jpg",
            });
            bookList.Add(new Book
            {
                ID = 5,
                Title = "Game of thrones",
                AuthorName = "Mohamed Ramadan",
                Brief = "It's a really good book.",
                Description = "It's a really good book It's a really good book It's a really good book It's a really good book.",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BYTRiNDQwYzAtMzVlZS00NTI5LWJjYjUtMzkwNTUzMWMxZTllXkEyXkFqcGdeQXVyNDIzMzcwNjc@._V1_.jpg",
            });

            return bookList;
        } 
    }
}
