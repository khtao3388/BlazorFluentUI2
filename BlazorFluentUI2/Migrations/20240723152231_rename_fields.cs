using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorFluentUI2.Migrations
{
    /// <inheritdoc />
    public partial class rename_fields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Systotic",
                table: "BloodPressures",
                newName: "Systolic");

            migrationBuilder.RenameColumn(
                name: "Dialatic",
                table: "BloodPressures",
                newName: "Diastolic");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Systolic",
                table: "BloodPressures",
                newName: "Systotic");

            migrationBuilder.RenameColumn(
                name: "Diastolic",
                table: "BloodPressures",
                newName: "Dialatic");
        }
    }
}
