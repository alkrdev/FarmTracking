using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendLibrary.Migrations
{
    public partial class DoubleToDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RunTime",
                table: "Machines",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "RunTime",
                table: "Machines",
                type: "double",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
