using Microsoft.EntityFrameworkCore;
using bookwormbackend.Data;
using bookwormbackend.Models;
namespace bookwormbackend.Controllers;

public static class UserDataEndpoints
{
    public static void MapUserDataEndpoints (this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/get_all_users", async (BookwormDbContext db) =>
        {
            return await db.UserData.ToListAsync();
        })
        .WithName("GetAllUserDatas")
        .Produces<List<UserData>>(StatusCodes.Status200OK);

        routes.MapGet("/api/get_user/{id}", async (int Id, BookwormDbContext db) =>
        {
            return await db.UserData.FindAsync(Id)
                is UserData model
                    ? Results.Ok(model)
                    : Results.NotFound();
        })
        .WithName("GetUserDataById")
        .Produces<UserData>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);

        routes.MapPut("/api/update_user/{id}", async (int Id, UserData userData, BookwormDbContext db) =>
        {
            var foundModel = await db.UserData.FindAsync(Id);

            if (foundModel is null)
            {
                return Results.NotFound();
            }
            //update model properties here

            await db.SaveChangesAsync();

            return Results.NoContent();
        })
        .WithName("UpdateUserData")
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status204NoContent);

        routes.MapPost("/api/register/", async (UserData userData, BookwormDbContext db) =>
        {
            db.UserData.Add(userData);
            await db.SaveChangesAsync();
            return Results.Created($"/UserDatas/{userData.Id}", userData);
        })
        .WithName("CreateUserData")
        .Produces<UserData>(StatusCodes.Status201Created);

        routes.MapDelete("/api/delete_user/{id}", async (int Id, BookwormDbContext db) =>
        {
            if (await db.UserData.FindAsync(Id) is UserData userData)
            {
                db.UserData.Remove(userData);
                await db.SaveChangesAsync();
                return Results.Ok(userData);
            }

            return Results.NotFound();
        })
        .WithName("DeleteUserData")
        .Produces<UserData>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);
    }
}
