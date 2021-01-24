using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace db_projektarbeit.Migrations
{
    public partial class initial : Migration
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
                    { 1, "Niederuzwil", 9244 },
                    { 30, "Thal", 9425 },
                    { 29, "Buchs", 9470 },
                    { 28, "Rheineck", 9424 },
                    { 27, "Hohentannen", 9216 },
                    { 26, "Andwil (SG)", 9204 },
                    { 25, "Jonschwil", 9243 },
                    { 24, "Oberbüren", 9245 },
                    { 23, "Bischofszell", 9220 },
                    { 22, "Flawil", 9230 },
                    { 21, "Gossau", 9200 },
                    { 20, "Untereggen", 9033 },
                    { 19, "Hundwil", 9064 },
                    { 18, "Grub", 9035 },
                    { 16, "Rehetobel", 9038 },
                    { 17, "Trogen", 9043 },
                    { 7, "Au", 9434 },
                    { 14, "Teufen", 9053 },
                    { 13, "Berg (SG)", 9305 },
                    { 12, "Tübach", 9327 },
                    { 11, "Arbon", 9320 },
                    { 10, "Mörschwil", 9402 },
                    { 9, "Sevelen", 9475 },
                    { 8, "Diepoldsau", 9444 },
                    { 15, "Gais", 9056 },
                    { 6, "Rorschach", 9400 },
                    { 5, "Goldach", 9403 },
                    { 4, "St. Gallen", 9000 },
                    { 3, "Rebstein", 9445 },
                    { 2, "Bettwiesen", 9553 }
                });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { 5, "Drucker", null },
                    { 1, "Büromöbel", null },
                    { 11, "Ordner", null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CityId", "CompanyName", "FirstName", "HouseNumber", "LastName", "Street" },
                values: new object[,]
                {
                    { 1, 1, "Traber Corp", "Marc", "12", "Traber", "Hauptstrasse" },
                    { 14, 13, "Raiffeisenbank Berg", "Antonio", "13", "Perugia", "Schlossgasse" },
                    { 15, 14, "Stampino AG", "Tina", "16", "Mächler", "Hinterwaldstrasse" },
                    { 17, 16, null, "Stefano", null, "Dalbacco", "Birkenau" },
                    { 18, 17, "Sägerei Fenk", "Michael", "10", "Graf", "Fuchsweg" },
                    { 19, 18, null, "Angela", "75", "Wick", "Dammstrasse" },
                    { 20, 19, "Sounddog GmbH", "Patrick", "5", "Viera", "Sonnengasse" },
                    { 22, 20, "Enderli Buch AG", "Erich", "18", "Kästner", "Feldwiesenstrasse" },
                    { 24, 21, "Velomech.ch AG", "Beat", "1", "Breu", "Gartenstrasse" },
                    { 26, 22, "Anton Kehrer AG", "Nadine", null, "Niedermann", "Am Bühl" },
                    { 27, 23, "Tres Amigos Ristorante", "Fabian", "2", "Buhmann", "Hauptstrasse" },
                    { 28, 24, "Birreria", "Tatjana", "92", "Kekarova", "Meistergasse" },
                    { 29, 25, "Pizzeria Antonio", "Selina", "3", "Gabenthuler", "Postplatz" },
                    { 30, 26, null, "Alessia", null, "Eichholzer", "Im Tobel" },
                    { 31, 27, "TeleVisio Corporation", "Tobias", "32", "Savello", "Marktgasse" },
                    { 33, 28, "Car Import GmbH", "Ignazio", "2", "Torres", "Rheinstrasse" },
                    { 34, 29, "NetworkTrade GmbH", "Rolf", "56", "Fringer", "Pizolerstrasse" },
                    { 35, 30, "Gasser Bau AG", "Hubert", "11", "Gasser", "Studenbach" },
                    { 13, 12, "Eon Pharma AG", "Ernst", "2", "Hediger", "Dinkelweg" },
                    { 40, 11, null, "Manuel", "28", "Stähli", "Lindenweg" },
                    { 16, 15, "Sport Säntis", "Didier", "3", "Cuche", "Unter den Linden" },
                    { 12, 11, null, "Marianne", "7", "Stettler", "Bachstrasse" },
                    { 23, 1, "Blumeria GmbH", "Remo", "88", "Santiago", "Bahnhofstrasse" },
                    { 36, 1, null, "Bernhard", "22", "Lutz", "Fähnernweg" },
                    { 2, 2, "Heeb GmbH", "Lukas", "2", "Heeb", "Winkelstrasse" },
                    { 3, 3, "CableTec AG", "Eric", "25", "Lüchinger", "Bergstrasse" },
                    { 37, 3, "Orthopädie Lüchinger", "Dorothea", "19", "Mittermeier", "Hauptstrasse" },
                    { 32, 11, "CompuTrade GmbH", "Daniel", "10", "Brunner", "Bachstrasse" },
                    { 4, 4, null, "Charlotte", "9", "Segmüller", "Weiherweg" },
                    { 5, 5, "Swisscom AG", "Fred", "2", "Chatwick", "Burggasse" },
                    { 6, 6, null, "Selina", null, "Schmidt", "Im Bohl" },
                    { 38, 3, "Sonnenbräu AG", "Fritz", "5", "Baumann", "Hinterstrasse" },
                    { 39, 7, null, "Alexander", "15", "Marty", "Kugelgasse" },
                    { 8, 8, "Bau Köster AG", "Michelle", "5", "Terzic", "Settlerstrasse" },
                    { 25, 8, null, "Jan", "62", "Steiger", "Rorschacherstrasse" },
                    { 9, 9, null, "Thorsten", "2", "Müller", "Waldweg" },
                    { 21, 9, "BCJ AG", "Davide", "7", "Kluser", "Mühlackerweg" },
                    { 10, 10, "Contacta GmbH", "Andreas", "1", "Hugentobler", "Hauptstrasse" },
                    { 11, 11, "Stadtverwaltung Arbon", "Esther", null, "Amgarten", "Rathausplatz" },
                    { 7, 7, "Setca GmbH", "Paul", "21", "Del Curto", "Bahnhofstrasse" }
                });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { 10, "Toner", 5 },
                    { 7, "Farbdrucker", 5 }
                });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { 6, "Belegdrucker", 5 },
                    { 2, "Bürostuhl", 1 },
                    { 3, "Korpus", 1 },
                    { 4, "Schreibtisch", 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "GroupId", "Price" },
                values: new object[,]
                {
                    { 11, new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meier (blau)", 11, 2.30m },
                    { 10, new DateTime(2020, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meier (gelb)", 11, 2.90m },
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
                    { 1, 1, 1, 1, 1m },
                    { 2, 3, 1, 4, 15m }
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
                values: new object[] { 3, 2, 1, 5, 2.50m });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Counter", "OrderId", "ProductId", "Total" },
                values: new object[] { 4, 1, 2, 8, 17.69m });

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
