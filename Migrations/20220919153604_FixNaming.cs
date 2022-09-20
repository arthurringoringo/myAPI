using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myApi.Migrations
{
    public partial class FixNaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "hashedpassword",
                table: "Users",
                newName: "hashed_password");

            migrationBuilder.RenameColumn(
                name: "deletedon",
                table: "Users",
                newName: "deleted_on");

            migrationBuilder.RenameColumn(
                name: "createdon",
                table: "Users",
                newName: "created_on");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "hashed_password",
                table: "Users",
                newName: "hashedpassword");

            migrationBuilder.RenameColumn(
                name: "deleted_on",
                table: "Users",
                newName: "deletedon");

            migrationBuilder.RenameColumn(
                name: "created_on",
                table: "Users",
                newName: "createdon");
        }
    }
}
