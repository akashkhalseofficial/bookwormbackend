using Microsoft.EntityFrameworkCore;
using bookwormbackend.Data;
using bookwormbackend.Models;
namespace bookwormbackend.Controllers;

public static class UserShelfEndpoints
{
    public static void MapUserShelfEndpoints (this IEndpointRouteBuilder routes)
    {
        /*routes.MapGet("/api/UserShelf", async (BookwormDbContext db) =>
        {
            return await db.UserShelf.ToListAsync();
        })
        .WithName("GetAllUserShelfs")
        .Produces<List<UserShelf>>(StatusCodes.Status200OK);*/

        /*routes.MapGet("/api/UserShelf/{id}", async (int Id, BookwormDbContext db) =>
        {
            return await db.UserShelf.FindAsync(Id)
                is UserShelf model
                    ? Results.Ok(model)
                    : Results.NotFound();
        })
        .WithName("GetUserShelfById")
        .Produces<UserShelf>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);*/

        /*routes.MapPut("/api/UserShelf/{id}", async (int Id, UserShelf userShelf, BookwormDbContext db) =>
        {
            var foundModel = await db.UserShelf.FindAsync(Id);

            if (foundModel is null)
            {
                return Results.NotFound();
            }
            //update model properties here

            await db.SaveChangesAsync();

            return Results.NoContent();
        })
        .WithName("UpdateUserShelf")
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status204NoContent);*/

        /* routes.MapPost("/api/UserShelf/", async (UserShelf userShelf, BookwormDbContext db) =>
         {
             db.UserShelf.Add(userShelf);
             await db.SaveChangesAsync();
             return Results.Created($"/UserShelfs/{userShelf.Id}", userShelf);
         })
         .WithName("CreateUserShelf")
         .Produces<UserShelf>(StatusCodes.Status201Created);

         routes.MapDelete("/api/UserShelf/{id}", async (int Id, BookwormDbContext db) =>
         {
             if (await db.UserShelf.FindAsync(Id) is UserShelf userShelf)
             {
                 db.UserShelf.Remove(userShelf);
                 await db.SaveChangesAsync();
                 return Results.Ok(userShelf);
             }

             return Results.NotFound();
         })
         .WithName("DeleteUserShelf")
         .Produces<UserShelf>(StatusCodes.Status200OK)
         .Produces(StatusCodes.Status404NotFound);*/

        routes.MapPost("/api/get_user_shelf/{id}", async (int userid, BookwormDbContext db) =>
        {

            var us = new List<UserShelf>();
            var usList = await db.UserShelf.ToListAsync();

            for (var i = 0; i < usList.Count; i++)
            {
                if (usList[i].userid == userid)
                {
                    us.Add(usList[i]);
                }
            }
            return us.Count > 0
                    ? Results.Ok(us)
                    : Results.NotFound();
        })
        .WithName("GetUserShelfId")
        .Produces<UserShelf>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);
    }
}
