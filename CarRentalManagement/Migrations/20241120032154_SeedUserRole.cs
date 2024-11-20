using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "c8d894ab-4a83-40b8-bff4-c6b7cdee8814", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEEWmfMvb1Sskh8gNnOf3wNr7tb1TzBWzJSTVRFJSNqR9q6WaFUwCzzkmi5FZGb687A==", null, false, "a7ea16c7-926e-4350-b06b-b452ce309dec", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 21, 51, 882, DateTimeKind.Local).AddTicks(3631), new DateTime(2024, 11, 20, 11, 21, 51, 882, DateTimeKind.Local).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 21, 51, 882, DateTimeKind.Local).AddTicks(3679), new DateTime(2024, 11, 20, 11, 21, 51, 882, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 21, 51, 882, DateTimeKind.Local).AddTicks(4470), new DateTime(2024, 11, 20, 11, 21, 51, 882, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 21, 51, 882, DateTimeKind.Local).AddTicks(4478), new DateTime(2024, 11, 20, 11, 21, 51, 882, DateTimeKind.Local).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 21, 51, 882, DateTimeKind.Local).AddTicks(4761), new DateTime(2024, 11, 20, 11, 21, 51, 882, DateTimeKind.Local).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 21, 51, 882, DateTimeKind.Local).AddTicks(4767), new DateTime(2024, 11, 20, 11, 21, 51, 882, DateTimeKind.Local).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 21, 51, 882, DateTimeKind.Local).AddTicks(4772), new DateTime(2024, 11, 20, 11, 21, 51, 882, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 21, 51, 882, DateTimeKind.Local).AddTicks(4776), new DateTime(2024, 11, 20, 11, 21, 51, 882, DateTimeKind.Local).AddTicks(4778) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 21, 9, 598, DateTimeKind.Local).AddTicks(8566), new DateTime(2024, 11, 18, 12, 21, 9, 598, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 21, 9, 598, DateTimeKind.Local).AddTicks(8599), new DateTime(2024, 11, 18, 12, 21, 9, 598, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 21, 9, 598, DateTimeKind.Local).AddTicks(9249), new DateTime(2024, 11, 18, 12, 21, 9, 598, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 21, 9, 598, DateTimeKind.Local).AddTicks(9256), new DateTime(2024, 11, 18, 12, 21, 9, 598, DateTimeKind.Local).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 21, 9, 598, DateTimeKind.Local).AddTicks(9501), new DateTime(2024, 11, 18, 12, 21, 9, 598, DateTimeKind.Local).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 21, 9, 598, DateTimeKind.Local).AddTicks(9506), new DateTime(2024, 11, 18, 12, 21, 9, 598, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 21, 9, 598, DateTimeKind.Local).AddTicks(9511), new DateTime(2024, 11, 18, 12, 21, 9, 598, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 21, 9, 598, DateTimeKind.Local).AddTicks(9516), new DateTime(2024, 11, 18, 12, 21, 9, 598, DateTimeKind.Local).AddTicks(9517) });
        }
    }
}
