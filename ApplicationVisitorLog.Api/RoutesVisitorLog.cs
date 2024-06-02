public static class VisitorLog
{
    public static void AddRoutesVisitorLog(this WebApplication app)
    {
        var group = app.MapGroup("/visitorlog").AddEndpointFilter(async (context, next) =>
        {
            return await next(context);
        });

        group.MapDelete("/delete", Delete);

        group.MapGet("/get", Get);

        group.MapGet("/", GetList);

        group.MapPost("/insert", Insert);

        group.MapPut("/update", Update);

        static IResult Delete(Guid id)
        {
            return Results.StatusCode(204);
        };

        static IResult Get(Guid id)
        {
            return Results.Ok(id);
        };

        static IResult GetList()
        {
            return Results.Ok();
        };

        static IResult Insert()
        {
            return Results.Created("/", Guid.NewGuid());
        }

        static IResult Update()
        {
            return Results.StatusCode(204);
        }
    }
}