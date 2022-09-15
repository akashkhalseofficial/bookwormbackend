using Microsoft.EntityFrameworkCore;
using bookwormbackend.Data;
using bookwormbackend.Models;
namespace bookwormbackend.Controllers;

public static class InvoicesEndpoints
{
    public static void MapInvoicesEndpoints (this IEndpointRouteBuilder routes)
    {
        /*routes.MapGet("/api/Invoices", async (BookwormDbContext db) =>
        {
            return await db.Invoices.ToListAsync();
        })
        .WithName("GetAllInvoicess")
        .Produces<List<Invoices>>(StatusCodes.Status200OK);

        routes.MapGet("/api/Invoices/{id}", async (int Id, BookwormDbContext db) =>
        {
            return await db.Invoices.FindAsync(Id)
                is Invoices model
                    ? Results.Ok(model)
                    : Results.NotFound();
        })
        .WithName("GetInvoicesById")
        .Produces<Invoices>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);

        routes.MapPut("/api/Invoices/{id}", async (int Id, Invoices invoices, BookwormDbContext db) =>
        {
            var foundModel = await db.Invoices.FindAsync(Id);

            if (foundModel is null)
            {
                return Results.NotFound();
            }
            //update model properties here

            await db.SaveChangesAsync();

            return Results.NoContent();
        })
        .WithName("UpdateInvoices")
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status204NoContent);*/

        routes.MapPost("/api/get_invoices/{id}", async (int userid, BookwormDbContext db) =>
        {

            var inv = new List<Invoices>();
            var invoiceList = await db.Invoices.ToListAsync();

            for (var i = 0; i < invoiceList.Count; i++)
            {
                if (invoiceList[i].userid == userid)
                {
                    inv.Add(invoiceList[i]);
                }
            }
            return inv.Count > 0
                    ? Results.Ok(inv)
                    : Results.NotFound();
        })
        .WithName("GetInvoicesById")
        .Produces<Invoices>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);
    }
}
