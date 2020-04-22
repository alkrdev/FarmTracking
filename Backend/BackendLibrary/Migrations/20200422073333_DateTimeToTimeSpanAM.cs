using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendLibrary.Migrations
{
    public partial class DateTimeToTimeSpanAM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "TimeLeft",
                table: "ActiveMachines",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeLeft",
                table: "ActiveMachines",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(TimeSpan));
        }
    }
}
