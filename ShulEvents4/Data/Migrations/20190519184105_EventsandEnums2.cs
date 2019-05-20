using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShulEvents4.Data.Migrations
{
    public partial class EventsandEnums2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreateYearlyEventsViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    StartingDate = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<string>(nullable: true),
                    EndingDate = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<string>(nullable: true),
                    SpecialEvents = table.Column<int>(nullable: false),
                    SpecialShabassos = table.Column<int>(nullable: false),
                    Months = table.Column<int>(nullable: false),
                    Parshios = table.Column<int>(nullable: false),
                    LifeEvents = table.Column<int>(nullable: false),
                    EventDescription = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreateYearlyEventsViewModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreateYearlyEventsViewModel_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CreateYearlyEventsViewModel_UserId",
                table: "CreateYearlyEventsViewModel",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreateYearlyEventsViewModel");
        }
    }
}
