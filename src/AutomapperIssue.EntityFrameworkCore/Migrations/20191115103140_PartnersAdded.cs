using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutomapperIssue.Migrations
{
    public partial class PartnersAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PartnerId",
                table: "AbpUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_PartnerId",
                table: "AbpUsers",
                column: "PartnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUsers_Partners_PartnerId",
                table: "AbpUsers",
                column: "PartnerId",
                principalTable: "Partners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpUsers_Partners_PartnerId",
                table: "AbpUsers");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropIndex(
                name: "IX_AbpUsers_PartnerId",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "PartnerId",
                table: "AbpUsers");
        }
    }
}
