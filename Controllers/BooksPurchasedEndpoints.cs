using Microsoft.EntityFrameworkCore;
using bookwormbackend.Data;
using bookwormbackend.Models;
namespace bookwormbackend.Controllers;

public static class BooksPurchasedEndpoints
{
    public static void MapBooksPurchasedEndpoints (this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/get_all_books_purchased", async (BookwormDbContext db) =>
        {
            return await db.BooksPurchased.ToListAsync();
        })
        .WithName("GetAllBooksPurchaseds")
        .Produces<List<BooksPurchased>>(StatusCodes.Status200OK);

        /*routes.MapGet("/api/BooksPurchased/{id}", async (int Id, BookwormDbContext db) =>
        {
            return await db.BooksPurchased.FindAsync(Id)
                is BooksPurchased model
                    ? Results.Ok(model)
                    : Results.NotFound();
        })
        .WithName("GetBooksPurchasedById")
        .Produces<BooksPurchased>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);*/

        /*routes.MapPut("/api/BooksPurchased/{id}", async (int Id, BooksPurchased booksPurchased, BookwormDbContext db) =>
        {
            var foundModel = await db.BooksPurchased.FindAsync(Id);

            if (foundModel is null)
            {
                return Results.NotFound();
            }
            //update model properties here

            await db.SaveChangesAsync();

            return Results.NoContent();
        })
        .WithName("UpdateBooksPurchased")
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status204NoContent);*/

        routes.MapPost("/api/BooksPurchased/", async (BooksPurchased booksPurchased, BookwormDbContext db) =>
        {
            db.BooksPurchased.Add(booksPurchased);
            await db.SaveChangesAsync();
            return Results.Created($"/BooksPurchaseds/{booksPurchased.Id}", booksPurchased);
        })
        .WithName("CreateBooksPurchased")
        .Produces<BooksPurchased>(StatusCodes.Status201Created);

        /*routes.MapDelete("/api/BooksPurchased/{id}", async (int Id, BookwormDbContext db) =>
        {
            if (await db.BooksPurchased.FindAsync(Id) is BooksPurchased booksPurchased)
            {
                db.BooksPurchased.Remove(booksPurchased);
                await db.SaveChangesAsync();
                return Results.Ok(booksPurchased);
            }

            return Results.NotFound();
        })
        .WithName("DeleteBooksPurchased")
        .Produces<BooksPurchased>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);*/
    }
}
