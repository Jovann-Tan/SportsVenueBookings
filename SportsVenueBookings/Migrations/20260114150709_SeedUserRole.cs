using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsVenueBookings.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateofBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

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
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateofBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "935fdcd9-304e-424e-8e43-591afa5da550", new DateOnly(1, 1, 1), "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAELgbtZZrj43GvS8XR1mnPN0G/97MYcpcYLz/0n0lEDGYL8gVRAhkk4T8Ph/rAxGM/w==", null, false, "63039510-d4a5-4119-b14d-67942560f9a8", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "TimeSlot" },
                values: new object[] { new DateTime(2026, 1, 14, 23, 7, 8, 509, DateTimeKind.Local).AddTicks(7564), new DateTime(2026, 1, 14, 23, 7, 8, 509, DateTimeKind.Local).AddTicks(7564), new DateTime(2026, 1, 14, 23, 7, 8, 509, DateTimeKind.Local).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "TimeSlot" },
                values: new object[] { new DateTime(2026, 1, 14, 23, 7, 8, 509, DateTimeKind.Local).AddTicks(7567), new DateTime(2026, 1, 14, 23, 7, 8, 509, DateTimeKind.Local).AddTicks(7568), new DateTime(2026, 1, 14, 23, 7, 8, 509, DateTimeKind.Local).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "TimeSlot" },
                values: new object[] { new DateTime(2026, 1, 14, 23, 7, 8, 509, DateTimeKind.Local).AddTicks(7570), new DateTime(2026, 1, 14, 23, 7, 8, 509, DateTimeKind.Local).AddTicks(7570), new DateTime(2026, 1, 14, 23, 7, 8, 509, DateTimeKind.Local).AddTicks(7569) });

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
                name: "DateofBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "TimeSlot" },
                values: new object[] { new DateTime(2026, 1, 14, 22, 54, 23, 986, DateTimeKind.Local).AddTicks(4870), new DateTime(2026, 1, 14, 22, 54, 23, 986, DateTimeKind.Local).AddTicks(4871), new DateTime(2026, 1, 14, 22, 54, 23, 986, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "TimeSlot" },
                values: new object[] { new DateTime(2026, 1, 14, 22, 54, 23, 986, DateTimeKind.Local).AddTicks(4874), new DateTime(2026, 1, 14, 22, 54, 23, 986, DateTimeKind.Local).AddTicks(4874), new DateTime(2026, 1, 14, 22, 54, 23, 986, DateTimeKind.Local).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "TimeSlot" },
                values: new object[] { new DateTime(2026, 1, 14, 22, 54, 23, 986, DateTimeKind.Local).AddTicks(4876), new DateTime(2026, 1, 14, 22, 54, 23, 986, DateTimeKind.Local).AddTicks(4876), new DateTime(2026, 1, 14, 22, 54, 23, 986, DateTimeKind.Local).AddTicks(4875) });
        }
    }
}
