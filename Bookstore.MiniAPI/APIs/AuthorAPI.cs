
namespace Bookstore.MiniAPI;

public class AuthorAPI : IApi
{
    public void Register(WebApplication app)
        => app.Register<Author, AuthorDTO, AuthorMiniDTO, AuthorBaseDTO>();
}