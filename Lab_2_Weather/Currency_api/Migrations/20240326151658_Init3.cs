using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Weather_api.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "timestamp_number",
                value: 4.5);

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Exchange", "Tag", "timestamp_number" },
                values: new object[] { 2, 4.5f, "TEST2", 4.5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "timestamp_number",
                value: 0.0);
        }
    }
}
