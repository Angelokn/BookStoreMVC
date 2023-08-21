using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectWeb.Migrations
{
    /// <inheritdoc />
    public partial class addCompanyRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Tech City", "Tech Solutions", "55987643210", "12121", "IL", "123 Tech Street" },
                    { 2, "Book City", "Joseph's Bookstore", "55944442222", "89898", "UJ", "631 Train Street" },
                    { 3, "Read City", "Readers Club", "55915153030", "06789", "LS", "890 Read Street" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
