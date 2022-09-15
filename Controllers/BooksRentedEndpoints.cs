using Microsoft.EntityFrameworkCore;
using bookwormbackend.Data;
using bookwormbackend.Models;
namespace bookwormbackend.Controllers;

public static class BooksRentedEndpoints
{
    public static void MapBooksRentedEndpoints (this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/get_all_books_rented", async (BookwormDbContext db) =>
        {
            return await db.BooksRented.ToListAsync();
        })
        .WithName("GetAllBooksRenteds")
        .Produces<List<BooksRented>>(StatusCodes.Status200OK);

        /*routes.MapGet("/api/BooksRented/{id}", async (int Id, BookwormDbContext db) =>
        {
            return await db.BooksRented.FindAsync(Id)
                is BooksRented model
                    ? Results.Ok(model)
                    : Results.NotFound();
        })
        .WithName("GetBooksRentedById")
        .Produces<BooksRented>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);*/

        /*routes.MapPut("/api/BooksRented/{id}", async (int Id, BooksRented booksRented, BookwormDbContext db) =>
        {
            var foundModel = await db.BooksRented.FindAsync(Id);

            if (foundModel is null)
            {
                return Results.NotFound();
            }
            //update model properties here

            await db.SaveChangesAsync();

            return Results.NoContent();
        })
        .WithName("UpdateBooksRented")
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status204NoContent);*/

        routes.MapPost("/api/BooksRented/", async (BooksRented booksRented, BookwormDbContext db) =>
        {
            db.BooksRented.Add(booksRented);
            await db.SaveChangesAsync();
            return Results.Created($"/BooksRenteds/{booksRented.Id}", booksRented);
        })
        .WithName("CreateBooksRented")
        .Produces<BooksRented>(StatusCodes.Status201Created);

        /*routes.MapDelete("/api/BooksRented/{id}", async (int Id, BookwormDbContext db) =>
        {
            if (await db.BooksRented.FindAsync(Id) is BooksRented booksRented)
            {
                db.BooksRented.Remove(booksRented);
                await db.SaveChangesAsync();
                return Results.Ok(booksRented);
            }

            return Results.NotFound();
        })
        .WithName("DeleteBooksRented")
        .Produces<BooksRented>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);*/
    }
}
