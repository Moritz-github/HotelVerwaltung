using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace HotelverwaltungAPI.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    GuestID = table.Column<int>(type: "int", nullable: false),
                    Payed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PaymentTarget = table.Column<DateTime>(type: "datetime", nullable: false),
                    PaymentMethod = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillID);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    GuestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Firstname = table.Column<string>(type: "text", nullable: true),
                    Lastname = table.Column<string>(type: "text", nullable: true),
                    Birthdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Language = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.GuestID);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CountBeds = table.Column<int>(type: "int", nullable: false),
                    HasKitchen = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HasBalcony = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HasTerrac = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NightlyPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                });

            migrationBuilder.CreateTable(
                name: "BillRoom",
                columns: table => new
                {
                    BillsBillID = table.Column<int>(type: "int", nullable: false),
                    RoomsRoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillRoom", x => new { x.BillsBillID, x.RoomsRoomId });
                    table.ForeignKey(
                        name: "FK_BillRoom_Bills_BillsBillID",
                        column: x => x.BillsBillID,
                        principalTable: "Bills",
                        principalColumn: "BillID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillRoom_Rooms_RoomsRoomId",
                        column: x => x.RoomsRoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomsBills",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    BillId = table.Column<int>(type: "int", nullable: false),
                    RoomDiscount = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomsBills", x => new { x.RoomId, x.BillId });
                    table.ForeignKey(
                        name: "FK_RoomsBills_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "BillID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomsBills_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillRoom_RoomsRoomId",
                table: "BillRoom",
                column: "RoomsRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomsBills_BillId",
                table: "RoomsBills",
                column: "BillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillRoom");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "RoomsBills");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
