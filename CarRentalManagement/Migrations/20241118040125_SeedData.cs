using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 12, 1, 23, 472, DateTimeKind.Local).AddTicks(586), new DateTime(2024, 11, 18, 12, 1, 23, 472, DateTimeKind.Local).AddTicks(609), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 12, 1, 23, 472, DateTimeKind.Local).AddTicks(614), new DateTime(2024, 11, 18, 12, 1, 23, 472, DateTimeKind.Local).AddTicks(615), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 12, 1, 23, 472, DateTimeKind.Local).AddTicks(1063), new DateTime(2024, 11, 18, 12, 1, 23, 472, DateTimeKind.Local).AddTicks(1064), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 12, 1, 23, 472, DateTimeKind.Local).AddTicks(1070), new DateTime(2024, 11, 18, 12, 1, 23, 472, DateTimeKind.Local).AddTicks(1072), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 12, 1, 23, 472, DateTimeKind.Local).AddTicks(1284), new DateTime(2024, 11, 18, 12, 1, 23, 472, DateTimeKind.Local).AddTicks(1286), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 12, 1, 23, 472, DateTimeKind.Local).AddTicks(1290), new DateTime(2024, 11, 18, 12, 1, 23, 472, DateTimeKind.Local).AddTicks(1291), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 12, 1, 23, 472, DateTimeKind.Local).AddTicks(1295), new DateTime(2024, 11, 18, 12, 1, 23, 472, DateTimeKind.Local).AddTicks(1296), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 12, 1, 23, 472, DateTimeKind.Local).AddTicks(1299), new DateTime(2024, 11, 18, 12, 1, 23, 472, DateTimeKind.Local).AddTicks(1300), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
