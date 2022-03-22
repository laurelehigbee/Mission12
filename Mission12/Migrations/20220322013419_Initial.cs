using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission12.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    TourId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AptDate = table.Column<string>(nullable: false),
                    AptTime = table.Column<string>(nullable: false),
                    GroupName = table.Column<string>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.TourId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "TourId", "AptDate", "AptTime", "Email", "GroupName", "Phone", "Size" },
                values: new object[] { 1, "January 1 2022", "12:00 pm", "randomEmail@gmail.com", "A Group", "555-555-5555", 12 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
