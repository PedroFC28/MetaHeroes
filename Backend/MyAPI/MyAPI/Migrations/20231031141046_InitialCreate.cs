using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hero",
                columns: new[] { "Name", "AlterEgo", "Power" },
                values: new object[] { "Nome do Herói", "Alter Ego do Herói", "Poder do Herói" });
        }



    }
}
