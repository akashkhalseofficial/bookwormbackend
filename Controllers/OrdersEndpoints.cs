using Microsoft.EntityFrameworkCore;
using bookwormbackend.Data;
using bookwormbackend.Models;
namespace bookwormbackend.Controllers;

public static class OrdersEndpoints
{
    public static void MapOrdersEndpoints (this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/get_all_orders", async (BookwormDbContext db) =>
        {
            return await db.Orders.ToListAsync();
        })
        .WithName("GetAllOrderss")
        .Produces<List<Orders>>(StatusCodes.Status200OK);

        routes.MapGet("/api/get_order/{id}", async (int Id, BookwormDbContext db) =>
        {
            return await db.Orders.FindAsync(Id)
                is Orders model
                    ? Results.Ok(model)
                    : Results.NotFound();
        })
        .WithName("GetOrdersById")
        .Produces<Orders>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);

        /*routes.MapPut("/api/Orders/{id}", async (int Id, Orders orders, BookwormDbContext db) =>
        {
            var foundModel = await db.Orders.FindAsync(Id);

            if (foundModel is null)
            {
                return Results.NotFound();
            }
            //update model properties here

            await db.SaveChangesAsync();

            return Results.NoContent();
        })
        .WithName("UpdateOrders")
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status204NoContent);*/

        routes.MapPost("/api/new_order/", async (Orders orders, BookwormDbContext db) =>
        {
            db.Orders.Add(orders);
            await db.SaveChangesAsync();
            return Results.Created($"/Orderss/{orders.Id}", orders);
        })
        .WithName("CreateOrders")
        .Produces<Orders>(StatusCodes.Status201Created);

        /*routes.MapDelete("/api/Orders/{id}", async (int Id, BookwormDbContext db) =>
        {
            if (await db.Orders.FindAsync(Id) is Orders orders)
            {
                db.Orders.Remove(orders);
                await db.SaveChangesAsync();
                return Results.Ok(orders);
            }

            return Results.NotFound();
        })
        .WithName("DeleteOrders")
        .Produces<Orders>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);*/

        /*  routes.MapPost("/api/my_shelf/", async (int userid, BookwormDbContext db) =>
          {

              var cities = new List<string>();
              var allbooks = await db.OrderDetails.ToListAsync();

              for(var i = 0; i < allbooks.Count; i++)
              {
                  if(allbooks[i].Id == userid)
                  {

                  }
              }
              *//*db.Orders.Add(orders);
              await db.SaveChangesAsync();
              return Results.Created($"/Orderss/{orders.Id}", orders);*//*
          })
          .WithName("GetShelf")
          .Produces<List<Books>>(StatusCodes.Status200OK);*/

    }
}
