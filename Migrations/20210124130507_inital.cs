using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace db_projektarbeit.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "shared");

            migrationBuilder.CreateSequence<int>(
                name: "CustomerNr",
                schema: "shared",
                startValue: 1000L);

            migrationBuilder.CreateSequence<int>(
                name: "ProductNr",
                schema: "shared",
                startValue: 10000L);

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zip = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductGroups_ProductGroups_ParentId",
                        column: x => x.ParentId,
                        principalTable: "ProductGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerNr = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR shared.CustomerNr"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductNr = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR shared.ProductNr"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "ProductGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Counter = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Positions_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Positions_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1, "St. Gallen", 9000 },
                    { 2, "Niederuzwil", 9244 },
                    { 3, "Bettwiesen", 9553 }
                });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { 1, "Büromöbel", null },
                    { 5, "Drucker", null },
                    { 11, "Ordner", null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CityId", "CompanyName", "FirstName", "HouseNumber", "LastName", "Street" },
                values: new object[,]
                {
                    { 1, 2, "Traber Corp", "Marc", null, "Traber", "Hauptstrasse 12" },
                    { 2, 3, "Heeb GmbH", "Lukas", null, "Heeb", "Winkelstrasse 2" }
                });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { 2, "Bürostuhl", 1 },
                    { 3, "Korpus", 1 },
                    { 4, "Schreibtisch", 1 },
                    { 6, "Belegdrucker", 5 },
                    { 7, "Farbdrucker", 5 },
                    { 10, "Toner", 5 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "GroupId", "Price" },
                values: new object[,]
                {
                    { 10, new DateTime(2020, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meier (gelb)", 11, 2.90m },
                    { 11, new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meier (blau)", 11, 2.30m },
                    { 12, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meier (grau)", 11, 3m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Comment", "CustomerId", "Date" },
                values: new object[,]
                {
                    { 1, "3456_Haus_Kohl", 1, new DateTime(2020, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "123_Haus_Tranz", 1, new DateTime(2020, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "000_Haus_google", 2, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { 8, "Fotodrucker", 7 },
                    { 9, "Multifunktionsdrucker", 7 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "GroupId", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stuhl mit Armlehnen", 2, 140m },
                    { 2, new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stuhl Comfort", 2, 170m },
                    { 3, new DateTime(2020, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rolli", 3, 199.90m },
                    { 4, new DateTime(2020, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "RT-9000", 6, 360.50m },
                    { 9, new DateTime(2020, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "HP all-in-one", 10, 999.90m }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Counter", "OrderId", "ProductId", "Total" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 0m },
                    { 2, 3, 1, 4, 0m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "GroupId", "Price" },
                values: new object[,]
                {
                    { 5, new DateTime(2020, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Polaroid Thermo", 8, 89.90m },
                    { 6, new DateTime(2020, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "HP M123XX", 9, 349m },
                    { 7, new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "HP M321YY", 9, 321m },
                    { 8, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brother Deluxe", 9, 430m }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Counter", "OrderId", "ProductId", "Total" },
                values: new object[] { 3, 2, 1, 5, 0m });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Counter", "OrderId", "ProductId", "Total" },
                values: new object[] { 4, 1, 2, 8, 0m });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CityId",
                table: "Customers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_OrderId",
                table: "Positions",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_ProductId",
                table: "Positions",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_ParentId",
                table: "ProductGroups",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GroupId",
                table: "Products",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ProductGroups");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropSequence(
                name: "CustomerNr",
                schema: "shared");

            migrationBuilder.DropSequence(
                name: "ProductNr",
                schema: "shared");
        }
    }
}
