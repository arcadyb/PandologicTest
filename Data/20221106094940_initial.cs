using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PandologicTest.Data
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LandingPageId = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ActiveJobs = table.Column<int>(type: "INTEGER", nullable: true),
                    CumulativeViews = table.Column<int>(type: "INTEGER", nullable: true),
                    CumulativeViewsPredicted = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_Pages_LandingPageId",
                        column: x => x.LandingPageId,
                        principalTable: "Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 1, "xyz", "https://xyz.com/MainPage" });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 2, "yyy", "https://yyy.com/MainPage" });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 1, 21, 42, 62, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 27, null, null, 114, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 26, null, null, 112, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 25, null, null, 110, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 24, 44, 88, 108, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 23, 43, 86, 106, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 22, 42, 84, 104, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 21, 41, 82, 102, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 20, 40, 80, 100, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 19, 39, 78, 98, new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 18, 38, 76, 96, new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 17, 37, 74, 94, new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 16, 36, 72, 92, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 28, null, null, 116, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 15, 35, 70, 90, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 13, 33, 66, 86, new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 12, 32, 64, 84, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 11, 31, 62, 82, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 10, 30, 60, 80, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 9, 29, 58, 78, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 8, 28, 56, 76, new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 7, 27, 54, 74, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 6, 26, 52, 72, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 5, 25, 50, 70, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 4, 24, 48, 68, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 3, 23, 46, 66, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 2, 22, 44, 64, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 14, 34, 68, 88, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ActiveJobs", "CumulativeViews", "CumulativeViewsPredicted", "Date", "LandingPageId" },
                values: new object[] { 29, null, null, 118, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_LandingPageId",
                table: "Jobs",
                column: "LandingPageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Pages");
        }
    }
}
