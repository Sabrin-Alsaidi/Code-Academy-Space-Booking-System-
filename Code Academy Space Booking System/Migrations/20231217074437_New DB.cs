using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Code_Academy_Space_Booking_System.Migrations
{
    public partial class NewDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    C_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_Fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C_Lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C_Phone = table.Column<int>(type: "int", nullable: false),
                    C_DOB = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.C_id);
                });

            migrationBuilder.CreateTable(
                name: "Spaces",
                columns: table => new
                {
                    S_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    availability_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spaces", x => x.S_id);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    B_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SId = table.Column<int>(type: "int", nullable: true),
                    CId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingNo);
                    table.ForeignKey(
                        name: "FK_Bookings_Clients_CId",
                        column: x => x.CId,
                        principalTable: "Clients",
                        principalColumn: "C_id");
                    table.ForeignKey(
                        name: "FK_Bookings_Spaces_SId",
                        column: x => x.SId,
                        principalTable: "Spaces",
                        principalColumn: "S_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CId",
                table: "Bookings",
                column: "CId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_SId",
                table: "Bookings",
                column: "SId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Spaces");
        }
    }
}
