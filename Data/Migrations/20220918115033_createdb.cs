using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bookwormbackend.Data.Migrations
{
    public partial class createdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BooksPurchased",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bid = table.Column<int>(type: "int", nullable: false),
                    userid = table.Column<int>(type: "int", nullable: false),
                    ordered = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksPurchased", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BooksRented",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bid = table.Column<int>(type: "int", nullable: false),
                    userid = table.Column<int>(type: "int", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ordered = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksRented", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BooksStock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksStock", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bid = table.Column<int>(type: "int", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bids = table.Column<int>(type: "int", nullable: false),
                    userid = table.Column<int>(type: "int", nullable: false),
                    totalordercost = table.Column<int>(type: "int", nullable: false),
                    purchaseType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    useremail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    useraddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ordered = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bid = table.Column<int>(type: "int", nullable: false),
                    purchaseType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ordered = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserCreds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCreds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserShelf",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bids = table.Column<int>(type: "int", nullable: false),
                    userid = table.Column<int>(type: "int", nullable: false),
                    rentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    booksRented = table.Column<int>(type: "int", nullable: true),
                    booksPurchased = table.Column<int>(type: "int", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ordered = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserShelf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BooksStockId = table.Column<int>(type: "int", nullable: true),
                    FilesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_BooksStock_BooksStockId",
                        column: x => x.BooksStockId,
                        principalTable: "BooksStock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Books_Files_FilesId",
                        column: x => x.FilesId,
                        principalTable: "Files",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    totalorderprice = table.Column<int>(type: "int", nullable: false),
                    bid = table.Column<int>(type: "int", nullable: false),
                    userid = table.Column<int>(type: "int", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ordered = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDetailsId = table.Column<int>(type: "int", nullable: true),
                    InvoicesId = table.Column<int>(type: "int", nullable: true),
                    UserShelfId = table.Column<int>(type: "int", nullable: true),
                    BooksPurchasedId = table.Column<int>(type: "int", nullable: true),
                    BooksRentedId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_BooksPurchased_BooksPurchasedId",
                        column: x => x.BooksPurchasedId,
                        principalTable: "BooksPurchased",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_BooksRented_BooksRentedId",
                        column: x => x.BooksRentedId,
                        principalTable: "BooksRented",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Invoices_InvoicesId",
                        column: x => x.InvoicesId,
                        principalTable: "Invoices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_OrderDetails_OrderDetailsId",
                        column: x => x.OrderDetailsId,
                        principalTable: "OrderDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_UserShelf_UserShelfId",
                        column: x => x.UserShelfId,
                        principalTable: "UserShelf",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wallet = table.Column<int>(type: "int", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCredsId = table.Column<int>(type: "int", nullable: true),
                    UserShelfId = table.Column<int>(type: "int", nullable: true),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserData_UserCreds_UserCredsId",
                        column: x => x.UserCredsId,
                        principalTable: "UserCreds",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserData_UserShelf_UserShelfId",
                        column: x => x.UserShelfId,
                        principalTable: "UserShelf",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_BooksStockId",
                table: "Books",
                column: "BooksStockId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_FilesId",
                table: "Books",
                column: "FilesId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BooksPurchasedId",
                table: "Orders",
                column: "BooksPurchasedId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BooksRentedId",
                table: "Orders",
                column: "BooksRentedId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_InvoicesId",
                table: "Orders",
                column: "InvoicesId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderDetailsId",
                table: "Orders",
                column: "OrderDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserShelfId",
                table: "Orders",
                column: "UserShelfId");

            migrationBuilder.CreateIndex(
                name: "IX_UserData_UserCredsId",
                table: "UserData",
                column: "UserCredsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserData_UserShelfId",
                table: "UserData",
                column: "UserShelfId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "UserData");

            migrationBuilder.DropTable(
                name: "BooksStock");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "BooksPurchased");

            migrationBuilder.DropTable(
                name: "BooksRented");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "UserCreds");

            migrationBuilder.DropTable(
                name: "UserShelf");
        }
    }
}
