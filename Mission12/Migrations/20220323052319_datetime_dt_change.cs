using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission12.Migrations
{
    public partial class datetime_dt_change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "TourId",
                keyValue: 1,
                columns: new[] { "AptDate", "AptTime" },
                values: new object[] { new DateTime(2022, 3, 22, 23, 23, 18, 856, DateTimeKind.Local).AddTicks(8920), 20 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
    

            migrationBuilder.UpdateData(
                table: "responses",
                keyColumn: "TourId",
                keyValue: 1,
                columns: new[] { "AptDate", "AptTime" },
                values: new object[] { "January 1 2022", "12:00 pm" });
        }
    }
}
