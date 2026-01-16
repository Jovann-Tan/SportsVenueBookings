using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsVenueBookings.Migrations
{
    /// <inheritdoc />
    public partial class idk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "Age", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "a5555b0c-3413-4e17-a3b9-2b40d33bb312", "AQAAAAIAAYagAAAAEIRdQuFQYd5+aJGMvM8gFPYvRDA/Fm35/9RHY7aOvfsxCK+tJn13v4npgiW8cQwPlg==", "6d7014b7-f340-4914-a4f0-3d50cc78d600" });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "TimeSlot" },
                values: new object[] { new DateTime(2026, 1, 16, 18, 59, 21, 635, DateTimeKind.Local).AddTicks(6644), new DateTime(2026, 1, 16, 18, 59, 21, 635, DateTimeKind.Local).AddTicks(6645), new DateTime(2026, 1, 16, 18, 59, 21, 635, DateTimeKind.Local).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "TimeSlot" },
                values: new object[] { new DateTime(2026, 1, 16, 18, 59, 21, 635, DateTimeKind.Local).AddTicks(6648), new DateTime(2026, 1, 16, 18, 59, 21, 635, DateTimeKind.Local).AddTicks(6649), new DateTime(2026, 1, 16, 18, 59, 21, 635, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "TimeSlot" },
                values: new object[] { new DateTime(2026, 1, 16, 18, 59, 21, 635, DateTimeKind.Local).AddTicks(6651), new DateTime(2026, 1, 16, 18, 59, 21, 635, DateTimeKind.Local).AddTicks(6651), new DateTime(2026, 1, 16, 18, 59, 21, 635, DateTimeKind.Local).AddTicks(6650) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "935fdcd9-304e-424e-8e43-591afa5da550", "AQAAAAIAAYagAAAAELgbtZZrj43GvS8XR1mnPN0G/97MYcpcYLz/0n0lEDGYL8gVRAhkk4T8Ph/rAxGM/w==", "63039510-d4a5-4119-b14d-67942560f9a8" });

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
        }
    }
}
