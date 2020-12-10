using Microsoft.EntityFrameworkCore.Migrations;

namespace Planner.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "whenDone",
                table: "Task",
                newName: "WhenDone");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Task",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "isDone",
                table: "Task",
                newName: "IsDone");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Task",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "deadLine",
                table: "Task",
                newName: "DeadLine");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Task",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "dateCriation",
                table: "Task",
                newName: "DateCreation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WhenDone",
                table: "Task",
                newName: "whenDone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Task",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "IsDone",
                table: "Task",
                newName: "isDone");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Task",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "DeadLine",
                table: "Task",
                newName: "deadLine");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Task",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DateCreation",
                table: "Task",
                newName: "dateCriation");
        }
    }
}
