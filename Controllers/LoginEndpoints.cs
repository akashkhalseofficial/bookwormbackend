using Microsoft.EntityFrameworkCore;
using bookwormbackend.Data;
using bookwormbackend.Models;
using System.Diagnostics;

namespace bookwormbackend.Controllers;

public static class LoginEndpoints
{
    public static void MapUserCredsEndpoints (this IEndpointRouteBuilder routes)
    {
        /*routes.MapGet("/api/UserCreds", async (BookwormDbContext db) =>
        {
            return await db.UserCreds.ToListAsync();
        })
        .WithName("GetAllUserCredss")
        .Produces<List<UserCreds>>(StatusCodes.Status200OK);*/

        /*routes.MapGet("/api/UserCreds/{id}", async (int Id, BookwormDbContext db) =>
        {
            return await db.UserCreds.FindAsync(Id)
                is UserCreds model
                    ? Results.Ok(model)
                    : Results.NotFound();
        })
        .WithName("GetUserCredsById")
        .Produces<UserCreds>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);*/

        /*routes.MapPut("/api/UserCreds/{id}", async (int Id, UserCreds userCreds, BookwormDbContext db) =>
        {
            var foundModel = await db.UserCreds.FindAsync(Id);

            if (foundModel is null)
            {
                return Results.NotFound();
            }
            //update model properties here

            await db.SaveChangesAsync();

            return Results.NoContent();
        })
        .WithName("UpdateUserCreds")
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status204NoContent);*/

        routes.MapPost("/api/login/", async (UserCreds userCreds, BookwormDbContext db) =>
        {
            var userid = 0;
            var loginDetails = await db.UserCreds.ToListAsync();
            foreach (var login in loginDetails)
            {
                if (login.Username == userCreds.Username && login.Password == userCreds.Password)
                {
                    userid = login.Id;
                 }
             }
            return userid;
        })
        .WithName("CreateUserCreds")
        .Produces<UserCreds>(StatusCodes.Status200OK)
        .Produces<UserCreds>(StatusCodes.Status404NotFound);

        /* routes.MapDelete("/api/UserCreds/{id}", async (int Id, BookwormDbContext db) =>
         {
             if (await db.UserCreds.FindAsync(Id) is UserCreds userCreds)
             {
                 db.UserCreds.Remove(userCreds);
                 await db.SaveChangesAsync();
                 return Results.Ok(userCreds);
             }

             return Results.NotFound();
         })
         .WithName("DeleteUserCreds")
         .Produces<UserCreds>(StatusCodes.Status200OK)
         .Produces(StatusCodes.Status404NotFound);*/
    }
}
