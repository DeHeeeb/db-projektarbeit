﻿using System;
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
                    CityId = table.Column<int>(type: "int", nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 2, 13, 19, 46, 58, 83, DateTimeKind.Local).AddTicks(3255)),
                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999))
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
                    Count = table.Column<int>(type: "int", nullable: false),
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
                    { 16, 15, "Sport Säntis", "Didier", "3", "Cuche", "Unter den Linden" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CityId", "CompanyName", "CustomerNr", "FirstName", "HouseNumber", "LastName", "Street", "ValidTo" },
                values: new object[] { 41, 15, null, 9001, "Dominic", "32", "Kunz", "Grubstrasse", new DateTime(2021, 2, 6, 19, 46, 58, 83, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CityId", "CompanyName", "CustomerNr", "FirstName", "HouseNumber", "LastName", "Street", "ValidFrom" },
                values: new object[] { 42, 15, null, 9001, "Dominic", "9", "Kunz", "Grabweg", new DateTime(2021, 2, 6, 19, 46, 58, 83, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CityId", "CompanyName", "FirstName", "HouseNumber", "LastName", "Street" },
                values: new object[,]
                {
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
                    { 15, 14, "Stampino AG", "Tina", "16", "Mächler", "Hinterwaldstrasse" },
                    { 12, 11, null, "Marianne", "7", "Stettler", "Bachstrasse" },
                    { 23, 1, "Blumeria GmbH", "Remo", "88", "Santiago", "Bahnhofstrasse" },
                    { 36, 1, null, "Bernhard", "22", "Lutz", "Fähnernweg" },
                    { 2, 2, "Heeb GmbH", "Lukas", "2", "Heeb", "Winkelstrasse" },
                    { 3, 3, "CableTec AG", "Eric", "25", "Lüchinger", "Bergstrasse" },
                    { 37, 3, "Orthopädie Lüchinger", "Dorothea", "19", "Mittermeier", "Hauptstrasse" },
                    { 38, 3, "Sonnenbräu AG", "Fritz", "5", "Baumann", "Hinterstrasse" },
                    { 32, 11, "CompuTrade GmbH", "Daniel", "10", "Brunner", "Bachstrasse" },
                    { 5, 5, "Swisscom AG", "Fred", "2", "Chatwick", "Burggasse" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CityId", "CompanyName", "CustomerNr", "FirstName", "HouseNumber", "LastName", "Street", "ValidTo" },
                values: new object[] { 43, 5, "Weber und Söhne", 9002, "Christian", null, "Weber", "Kleinweg", new DateTime(2021, 1, 4, 19, 46, 58, 83, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CityId", "CompanyName", "CustomerNr", "FirstName", "HouseNumber", "LastName", "Street", "ValidFrom", "ValidTo" },
                values: new object[] { 44, 5, "Weber und Söhne", 9002, "Christian", "500", "Weber", "Grossweg", new DateTime(2021, 1, 4, 19, 46, 58, 83, DateTimeKind.Local).AddTicks(3255), new DateTime(2021, 2, 11, 19, 46, 58, 83, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CityId", "CompanyName", "FirstName", "HouseNumber", "LastName", "Street" },
                values: new object[,]
                {
                    { 4, 4, null, "Charlotte", "9", "Segmüller", "Weiherweg" },
                    { 6, 6, null, "Selina", null, "Schmidt", "Im Bohl" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CityId", "CompanyName", "CustomerNr", "FirstName", "HouseNumber", "LastName", "Street", "ValidFrom" },
                values: new object[] { 45, 5, "Weber AG", 9002, "Christian", "500", "Weber", "Grossweg", new DateTime(2021, 2, 11, 19, 46, 58, 83, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CityId", "CompanyName", "FirstName", "HouseNumber", "LastName", "Street" },
                values: new object[,]
                {
                    { 10, 10, "Contacta GmbH", "Andreas", "1", "Hugentobler", "Hauptstrasse" },
                    { 21, 9, "BCJ AG", "Davide", "7", "Kluser", "Mühlackerweg" },
                    { 9, 9, null, "Thorsten", "2", "Müller", "Waldweg" },
                    { 11, 11, "Stadtverwaltung Arbon", "Esther", null, "Amgarten", "Rathausplatz" },
                    { 8, 8, "Bau Köster AG", "Michelle", "5", "Terzic", "Settlerstrasse" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CityId", "CompanyName", "FirstName", "HouseNumber", "LastName", "Street" },
                values: new object[,]
                {
                    { 39, 7, null, "Alexander", "15", "Marty", "Kugelgasse" },
                    { 7, 7, "Setca GmbH", "Paul", "21", "Del Curto", "Bahnhofstrasse" },
                    { 25, 8, null, "Jan", "62", "Steiger", "Rorschacherstrasse" }
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
                    { 21, "Garten_Haus", 4, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "Skiferien", 4, new DateTime(2020, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Familenfest", 4, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Brühwiler_Ferienhaus", 4, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Privat", 4, new DateTime(2020, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "999_Karten_Schnutz", 3, new DateTime(2020, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "149_Böhni_Urs", 3, new DateTime(2020, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "730_Martins", 3, new DateTime(2020, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "403_Haus_Torsten", 3, new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "396_Björn_Kortu", 2, new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Brügger_Baden", 3, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Butz_Herkingen", 2, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "123_Haus_Tranz", 1, new DateTime(2020, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "719_Kratt_Manuel", 2, new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Dubli", 1, new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "642_Gieger_Peter", 1, new DateTime(2020, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "750_Gotinger_Martin", 1, new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, "123_holdergarten_Gerd", 1, new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "000_Haus_google", 2, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "730_Martins", 2, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "639_Spielman_Gorden", 1, new DateTime(2020, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { 9, "Multifunktionsdrucker", 7 },
                    { 8, "Fotodrucker", 7 }
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
                columns: new[] { "Id", "Count", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { 10, 3, 6, 10 },
                    { 2, 3, 1, 4 },
                    { 39, 2, 22, 3 },
                    { 35, 1, 20, 3 },
                    { 31, 2, 18, 3 },
                    { 29, 1, 17, 3 },
                    { 28, 1, 16, 3 },
                    { 13, 8, 7, 3 },
                    { 5, 1, 3, 3 },
                    { 22, 3, 13, 9 },
                    { 23, 2, 13, 2 },
                    { 17, 3, 9, 2 },
                    { 27, 1, 16, 2 },
                    { 1, 1, 1, 1 },
                    { 15, 2, 8, 12 },
                    { 34, 1, 19, 12 },
                    { 33, 2, 19, 11 },
                    { 32, 2, 19, 10 },
                    { 26, 1, 15, 12 },
                    { 25, 2, 15, 11 },
                    { 19, 1, 10, 12 },
                    { 12, 3, 6, 12 },
                    { 11, 1, 6, 11 },
                    { 16, 1, 8, 1 },
                    { 30, 1, 18, 9 }
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
                columns: new[] { "Id", "Count", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { 3, 2, 1, 5 },
                    { 18, 2, 10, 5 },
                    { 24, 1, 14, 5 },
                    { 36, 3, 21, 5 },
                    { 6, 3, 3, 7 },
                    { 20, 4, 11, 7 },
                    { 4, 1, 2, 8 },
                    { 7, 2, 4, 8 },
                    { 8, 2, 5, 8 },
                    { 9, 2, 5, 8 },
                    { 14, 1, 7, 8 },
                    { 21, 1, 12, 8 },
                    { 37, 1, 21, 8 },
                    { 38, 1, 22, 8 }
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
