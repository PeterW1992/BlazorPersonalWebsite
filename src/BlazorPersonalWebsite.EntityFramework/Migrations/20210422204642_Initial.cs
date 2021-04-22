using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorPersonalWebsite.EntityFramework.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobApplication",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobApplicationRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateApplied = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Outcome = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplication", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoftwareProject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftwareProject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WoodworkProject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WoodworkProject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoftwareProjectImage",
                columns: table => new
                {
                    ImageUrl = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoftwareProjectId = table.Column<int>(type: "int", nullable: false),
                    SoftwareProjectId1 = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftwareProjectImage", x => x.ImageUrl);
                    table.ForeignKey(
                        name: "FK_SoftwareProjectImage_SoftwareProject_SoftwareProjectId",
                        column: x => x.SoftwareProjectId,
                        principalTable: "SoftwareProject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SoftwareProjectImage_SoftwareProject_SoftwareProjectId1",
                        column: x => x.SoftwareProjectId1,
                        principalTable: "SoftwareProject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WoodworkImage",
                columns: table => new
                {
                    ImageUrl = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WoodworkProjectId = table.Column<int>(type: "int", nullable: false),
                    WoodworkProjectId1 = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WoodworkImage", x => x.ImageUrl);
                    table.ForeignKey(
                        name: "FK_WoodworkImage_WoodworkProject_WoodworkProjectId",
                        column: x => x.WoodworkProjectId,
                        principalTable: "WoodworkProject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WoodworkImage_WoodworkProject_WoodworkProjectId1",
                        column: x => x.WoodworkProjectId1,
                        principalTable: "WoodworkProject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "SoftwareProject",
                columns: new[] { "Id", "DateCreated", "Description", "Name", "ProjectRef" },
                values: new object[] { 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skill action calculator for video game Runescape", "Runescape Calculator", "rsCalc" });

            migrationBuilder.InsertData(
                table: "SoftwareProjectImage",
                columns: new[] { "ImageUrl", "Description", "SoftwareProjectId", "SoftwareProjectId1" },
                values: new object[,]
                {
                    { "images\\software-images\\rs-calculator\\1.png", "Agility skill calculator", 1, null },
                    { "images\\software-images\\rs-calculator\\2.png", "Fishing skill calculator", 1, null },
                    { "images\\software-images\\rs-calculator\\3.png", "Dropdown showing which skills are included", 1, null },
                    { "images\\software-images\\rs-calculator\\4.png", "Dropdown showing skill subcategories", 1, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareProjectImage_SoftwareProjectId",
                table: "SoftwareProjectImage",
                column: "SoftwareProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareProjectImage_SoftwareProjectId1",
                table: "SoftwareProjectImage",
                column: "SoftwareProjectId1");

            migrationBuilder.CreateIndex(
                name: "IX_WoodworkImage_WoodworkProjectId",
                table: "WoodworkImage",
                column: "WoodworkProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_WoodworkImage_WoodworkProjectId1",
                table: "WoodworkImage",
                column: "WoodworkProjectId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobApplication");

            migrationBuilder.DropTable(
                name: "SoftwareProjectImage");

            migrationBuilder.DropTable(
                name: "WoodworkImage");

            migrationBuilder.DropTable(
                name: "SoftwareProject");

            migrationBuilder.DropTable(
                name: "WoodworkProject");
        }
    }
}
