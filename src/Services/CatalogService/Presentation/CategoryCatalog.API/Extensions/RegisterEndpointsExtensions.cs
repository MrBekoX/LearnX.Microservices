using CategoryCatalog.API.Endpoints;

namespace CategoryCatalog.API.Extensions;

public static class RegisterEndpointsExtensions
{
    public static IEndpointRouteBuilder RegisterCatalogServiceAllEndpoints(this IEndpointRouteBuilder app)
    {
        app.RegisterCategoryEndpoints();
        return app;
    }
}
