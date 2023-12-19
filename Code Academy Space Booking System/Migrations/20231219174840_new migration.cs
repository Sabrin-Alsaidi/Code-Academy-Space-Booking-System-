using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Code_Academy_Space_Booking_System.Migrations
{
    public partial class newmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "S_Location",
                table: "Spaces");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "S_Location",
                table: "Spaces",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
