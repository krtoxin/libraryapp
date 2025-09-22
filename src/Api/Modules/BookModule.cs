namespace Api.Modules;
using Application.Services;

public static class BookModule
{
    public static IServiceCollection AddBookModule(this IServiceCollection services)
    {
        services.AddScoped<IBookService, BookService>();
        services.AddScoped<IAuthorService, AuthorService>(); 
        return services;
    }
}