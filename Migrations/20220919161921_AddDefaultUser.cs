using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myApi.Migrations
{
    public partial class AddDefaultUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "created_on", "deleted", "deleted_on", "email", "hashed_password", "username" },
                values: new object[] { 1, new DateTime(2022, 9, 19, 23, 19, 21, 790, DateTimeKind.Utc).AddTicks(1500), false, null, "sllash.arthur@gmail.com", "@Wordpass123", "arthur" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
