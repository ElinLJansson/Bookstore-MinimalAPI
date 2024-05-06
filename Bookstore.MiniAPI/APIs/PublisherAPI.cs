
namespace Bookstore.MiniAPI;

public class PublisherAPI : IApi
{
    public void Register(WebApplication app)
        => app.Register<Publisher, PublisherDTO, PublisherMiniDTO, PublisherBaseDTO>();
}