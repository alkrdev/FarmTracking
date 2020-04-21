using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendLibrary.Migrations
{
    public partial class ActiveMachineStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "ActiveMachines",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "ActiveMachines");
        }
    }
}
