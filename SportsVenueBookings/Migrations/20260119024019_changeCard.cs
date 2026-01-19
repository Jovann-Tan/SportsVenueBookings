using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsVenueBookings.Migrations
{
    /// <inheritdoc />
    public partial class changeCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "CardNumber",
                table: "Payment",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "long");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74ccc360-93a8-49df-923c-8e8bd4076797", "AQAAAAIAAYagAAAAEB0w+EVT/iRzYiT8cLx9ygs/aOvt1mOhZs0uhjeECxuP2Z9lZAJg4JyXzoUpLB9kXw==", "0a958f44-9fb7-44c8-a8a6-c3da15d75db7" });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Availability", "DateCreated", "DateUpdated", "TimeSlot" },
                values: new object[] { "Avaliable", new DateTime(2026, 1, 19, 10, 40, 18, 699, DateTimeKind.Local).AddTicks(9044), new DateTime(2026, 1, 19, 10, 40, 18, 699, DateTimeKind.Local).AddTicks(9053), new DateTime(2026, 1, 20, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "TimeSlot" },
                values: new object[] { new DateTime(2026, 1, 19, 10, 40, 18, 699, DateTimeKind.Local).AddTicks(9057), new DateTime(2026, 1, 19, 10, 40, 18, 699, DateTimeKind.Local).AddTicks(9057), new DateTime(2026, 1, 19, 10, 40, 18, 699, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "TimeSlot" },
                values: new object[] { new DateTime(2026, 1, 19, 10, 40, 18, 699, DateTimeKind.Local).AddTicks(9060), new DateTime(2026, 1, 19, 10, 40, 18, 699, DateTimeKind.Local).AddTicks(9060), new DateTime(2026, 1, 19, 10, 40, 18, 699, DateTimeKind.Local).AddTicks(9059) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CardNumber",
                table: "Payment",
                type: "long",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5555b0c-3413-4e17-a3b9-2b40d33bb312", "AQAAAAIAAYagAAAAEIRdQuFQYd5+aJGMvM8gFPYvRDA/Fm35/9RHY7aOvfsxCK+tJn13v4npgiW8cQwPlg==", "6d7014b7-f340-4914-a4f0-3d50cc78d600" });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Availability", "DateCreated", "DateUpdated", "TimeSlot" },
                values: new object[] { "Available", new DateTime(2026, 1, 16, 18, 59, 21, 635, DateTimeKind.Local).AddTicks(6644), new DateTime(2026, 1, 16, 18, 59, 21, 635, DateTimeKind.Local).AddTicks(6645), new DateTime(2026, 1, 16, 18, 59, 21, 635, DateTimeKind.Local).AddTicks(6631) });

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
    }
}
