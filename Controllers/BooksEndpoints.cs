using Microsoft.EntityFrameworkCore;
using bookwormbackend.Data;
using bookwormbackend.Models;
namespace bookwormbackend.Controllers;

public static class BooksEndpoints
{
    public static void MapBooksEndpoints (this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/get_all_books", async (BookwormDbContext db) =>
        {
            return await db.Books.ToListAsync();
        })
        .WithName("GetAllBookss")
        .Produces<List<Books>>(StatusCodes.Status200OK);

        routes.MapGet("/api/get_book/{id}", async (int Id, BookwormDbContext db) =>
        {
            return await db.Books.FindAsync(Id)
                is Books model
                    ? Results.Ok(model)
                    : Results.NotFound();
        })
        .WithName("GetBooksById")
        .Produces<Books>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);

        routes.MapPut("/api/update_book/{id}", async (int Id, Books books, BookwormDbContext db) =>
        {
            var foundModel = await db.Books.FindAsync(Id);

            if (foundModel is null)
            {
                return Results.NotFound();
            }
            //update model properties here

            await db.SaveChangesAsync();

            return Results.NoContent();
        })
        .WithName("UpdateBooks")
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status204NoContent);

        routes.MapPost("/api/add_new_book/", async (Books books, BookwormDbContext db) =>
        {
            db.Books.Add(books);
            await db.SaveChangesAsync();
            return Results.Created($"/Bookss/{books.Id}", books);
        })
        .WithName("CreateBooks")
        .Produces<Books>(StatusCodes.Status201Created);

        routes.MapDelete("/api/delete_book/{id}", async (int Id, BookwormDbContext db) =>
        {
            if (await db.Books.FindAsync(Id) is Books books)
            {
                db.Books.Remove(books);
                await db.SaveChangesAsync();
                return Results.Ok(books);
            }

            return Results.NotFound();
        })
        .WithName("DeleteBooks")
        .Produces<Books>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);
    }
}
