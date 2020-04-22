using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendLibrary.Migrations
{
    public partial class DateTimeToTimeSpan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "RunTime",
                table: "Machines",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RunTime",
                table: "Machines",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(TimeSpan));
        }
    }
}
