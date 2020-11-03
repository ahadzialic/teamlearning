using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPageUI.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BillGSM",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductofferID = table.Column<string>(nullable: true),
                    ProductofferNameGSM = table.Column<string>(nullable: true),
                    UnitPriceGSM = table.Column<decimal>(nullable: true),
                    UnitPriceAmountGSM1 = table.Column<decimal>(nullable: true),
                    UnitPriceAmountGSM2 = table.Column<TimeSpan>(nullable: false),
                    ValueWithoutVAT = table.Column<decimal>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillGSM", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillGSM");
        }
    }
}
