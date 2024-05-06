
namespace Bookstore.MiniAPI;

public class BookAPI : IApi
{
    public void Register(WebApplication app)
        => app.Register<Book, BookDTO, BookMiniDTO, BookBaseDTO>();
}