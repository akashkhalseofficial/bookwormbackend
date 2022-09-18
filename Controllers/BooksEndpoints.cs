using Microsoft.EntityFrameworkCore;
using bookwormbackend.Data;
using bookwormbackend.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.OpenApi.Any;
using Microsoft.Data.SqlClient;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;

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

        routes.MapPost("/api/get_book", async (int Id, BookwormDbContext db) =>
        {
            return await db.Books.FindAsync(Id)
                is Books model
                    ? Results.Ok(model)
                    : Results.NotFound();
        })
        .WithName("GetBooksById")
        .Produces<Books>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);

        routes.MapPut("/api/update_book/{Id}", async (int Id, Books books, BookwormDbContext db) =>
        {
            var foundModel = await db.Books.FindAsync(Id);
         
            

            if (foundModel is null)
            {
                Console.WriteLine("null");
                return Results.NotFound();
            }
            //update model properties here

            foundModel.Name = books.Name;
            foundModel.Author = books.Author;
            foundModel.Language = books.Language;
            foundModel.image = books.image;
            foundModel.Pages = books.Pages;
            foundModel.Category = books.Category;
            foundModel.Price = books.Price;
            foundModel.stock = books.stock;

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
