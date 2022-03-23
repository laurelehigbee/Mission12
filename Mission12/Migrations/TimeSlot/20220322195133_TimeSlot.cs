using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission12.Migrations.TimeSlot
{
    public partial class TimeSlot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Slots",
                columns: table => new
                {
                    TimeSlotId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<string>(nullable: true),
                    Time = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slots", x => x.TimeSlotId);
                });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 1, "2022-03-23", "8:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 66, "2022-03-28", "8:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 65, "2022-03-27", "8:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 64, "2022-03-27", "7:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 63, "2022-03-27", "6:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 62, "2022-03-27", "5:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 61, "2022-03-27", "4:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 60, "2022-03-27", "3:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 59, "2022-03-27", "2:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 58, "2022-03-27", "1:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 57, "2022-03-27", "12:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 56, "2022-03-27", "11:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 55, "2022-03-27", "10:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 54, "2022-03-27", "9:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 53, "2022-03-27", "8:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 52, "2022-03-26", "8:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 51, "2022-03-26", "7:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 50, "2022-03-26", "6:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 49, "2022-03-26", "5:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 48, "2022-03-26", "4:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 67, "2022-03-28", "9:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 47, "2022-03-26", "3:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 68, "2022-03-28", "10:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 70, "2022-03-28", "12:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 89, "2022-03-29", "6:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 88, "2022-03-29", "5:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 87, "2022-03-29", "4:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 86, "2022-03-29", "3:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 85, "2022-03-29", "2:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 84, "2022-03-29", "1:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 83, "2022-03-29", "12:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 82, "2022-03-29", "11:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 81, "2022-03-29", "10:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 80, "2022-03-29", "9:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 79, "2022-03-29", "8:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 78, "2022-03-28", "8:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 77, "2022-03-28", "7:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 76, "2022-03-28", "6:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 75, "2022-03-28", "5:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 74, "2022-03-28", "4:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 73, "2022-03-28", "3:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 72, "2022-03-28", "2:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 71, "2022-03-28", "1:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 69, "2022-03-28", "11:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 90, "2022-03-29", "7:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 46, "2022-03-26", "2:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 44, "2022-03-26", "12:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 20, "2022-03-24", "2:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 19, "2022-03-24", "1:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 18, "2022-03-24", "12:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 17, "2022-03-24", "11:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 16, "2022-03-24", "10:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 15, "2022-03-24", "9:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 14, "2022-03-24", "8:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 13, "2022-03-23", "8:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 12, "2022-03-23", "7:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 11, "2022-03-23", "6:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 10, "2022-03-23", "5:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 9, "2022-03-23", "4:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 8, "2022-03-23", "3:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 7, "2022-03-23", "2:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 6, "2022-03-23", "1:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 5, "2022-03-23", "12:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 4, "2022-03-23", "11:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 3, "2022-03-23", "10:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 2, "2022-03-23", "9:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 21, "2022-03-24", "3:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 45, "2022-03-26", "1:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 22, "2022-03-24", "4:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 24, "2022-03-24", "6:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 43, "2022-03-26", "11:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 42, "2022-03-26", "10:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 41, "2022-03-26", "9:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 40, "2022-03-26", "8:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 39, "2022-03-25", "8:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 38, "2022-03-25", "7:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 37, "2022-03-25", "6:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 36, "2022-03-25", "5:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 35, "2022-03-25", "4:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 34, "2022-03-25", "3:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 33, "2022-03-25", "2:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 32, "2022-03-25", "1:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 31, "2022-03-25", "12:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 30, "2022-03-25", "11:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 29, "2022-03-25", "10:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 28, "2022-03-25", "9:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 27, "2022-03-25", "8:00 am" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 26, "2022-03-24", "8:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 25, "2022-03-24", "7:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 23, "2022-03-24", "5:00 pm" });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "TimeSlotId", "Date", "Time" },
                values: new object[] { 91, "2022-03-29", "8:00 pm" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Slots");
        }
    }
}
