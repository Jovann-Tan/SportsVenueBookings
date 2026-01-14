using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsVenueBookings.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Venue",
                columns: new[] { "Id", "Address", "Availability", "CourtNumber", "CreatedBy", "DateCreated", "DateUpdated", "TimeSlot", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Over Here", "Available", 1, "System", new DateTime(2026, 1, 14, 10, 30, 35, 928, DateTimeKind.Local).AddTicks(6423), new DateTime(2026, 1, 14, 10, 30, 35, 928, DateTimeKind.Local).AddTicks(6424), new DateTime(2026, 1, 14, 10, 30, 35, 928, DateTimeKind.Local).AddTicks(6405), "System" },
                    { 2, "Over There", "Not Available", 1, "System", new DateTime(2026, 1, 14, 10, 30, 35, 928, DateTimeKind.Local).AddTicks(6433), new DateTime(2026, 1, 14, 10, 30, 35, 928, DateTimeKind.Local).AddTicks(6434), new DateTime(2026, 1, 14, 10, 30, 35, 928, DateTimeKind.Local).AddTicks(6431), "System" },
                    { 3, "Under There", "Available", 2, "System", new DateTime(2026, 1, 14, 10, 30, 35, 928, DateTimeKind.Local).AddTicks(6440), new DateTime(2026, 1, 14, 10, 30, 35, 928, DateTimeKind.Local).AddTicks(6441), new DateTime(2026, 1, 14, 10, 30, 35, 928, DateTimeKind.Local).AddTicks(6439), "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
