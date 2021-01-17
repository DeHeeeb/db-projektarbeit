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
                    ProductId = table.Column<int>(type: "int", nullable: false),
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    GroupId1 = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductGroups_GroupId1",
                        column: x => x.GroupId1,
                        principalTable: "ProductGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomerId1 = table.Column<int>(type: "int", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId1",
                        column: x => x.CustomerId1,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    OrderId1 = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_Positions_Orders_OrderId1",
                        column: x => x.OrderId1,
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
                columns: new[] { "Id", "Name", "ParentId", "ProductId" },
                values: new object[,]
                {
                    { 1, "Büromöbel", null, 140068752 },
                    { 5, "Drucker", null, 123456789 },
                    { 11, "Ordner", null, 140468752 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "GroupId", "GroupId1", "Price" },
                values: new object[,]
                {
                    { 4, "RT-9000", 6, null, 360.50m },
                    { 5, "Polaroid Thermo", 8, null, 89.90m },
                    { 2, "Stuhl Comfort", 2, null, 170m },
                    { 7, "HP M321YY", 9, null, 321m },
                    { 8, "Brother Deluxe", 9, null, 430m },
                    { 9, "HP all-in-one", 10, null, 999.90m },
                    { 10, "Meier (gelb)", 11, null, 2.90m },
                    { 11, "Meier (blau)", 11, null, 2.30m },
                    { 12, "Meier (grau)", 11, null, 3m },
                    { 1, "Stuhl mit Armlehnen", 2, null, 140m },
                    { 3, "Rolli", 3, null, 199.90m },
                    { 6, "HP M123XX", 9, null, 349m }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CityId", "Name", "Street" },
                values: new object[,]
                {
                    { 1, 2, "Marc Traber AG", "Hauptstrasse 12" },
                    { 2, 3, "Heeb GmbH", "Winkelstrasse 2" }
                });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "Name", "ParentId", "ProductId" },
                values: new object[,]
                {
                    { 2, "Bürostuhl", 1, 745213689 },
                    { 3, "Korpus", 1, 963258741 },
                    { 4, "Schreibtisch", 1, 987456321 },
                    { 6, "Belegdrucker", 5, 954068252 },
                    { 7, "Farbdrucker", 5, 427806752 },
                    { 10, "Toner", 5, 647068712 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Comment", "CustomerId", "CustomerId1", "Date" },
                values: new object[,]
                {
                    { 1, "3456_Haus_Kohl", 1, null, new DateTime(2020, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "123_Haus_Tranz", 1, null, new DateTime(2020, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "000_Haus_google", 2, null, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "Name", "ParentId", "ProductId" },
                values: new object[,]
                {
                    { 8, "Fotodrucker", 7, 770075678 },
                    { 9, "Multifunktionsdrucker", 7, 190069952 }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Counter", "OrderId", "OrderId1", "ProductId", "Total" },
                values: new object[,]
                {
                    { 1, 1, 1, null, 1, 0m },
                    { 2, 3, 1, null, 4, 0m },
                    { 3, 2, 1, null, 5, 0m },
                    { 4, 1, 2, null, 8, 0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CityId",
                table: "Customers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId1",
                table: "Orders",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_OrderId",
                table: "Positions",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_OrderId1",
                table: "Positions",
                column: "OrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_ProductId",
                table: "Positions",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_ParentId",
                table: "ProductGroups",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GroupId1",
                table: "Products",
                column: "GroupId1");
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
