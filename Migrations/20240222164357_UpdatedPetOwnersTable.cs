using Microsoft.EntityFrameworkCore.Migrations;

namespace pet_hotel.Migrations
{
    public partial class UpdatedPetOwnersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "petCount",
                table: "PetOwners",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "petCount",
                table: "PetOwners");
        }
    }
}
