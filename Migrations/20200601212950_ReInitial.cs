using Microsoft.EntityFrameworkCore.Migrations;

namespace University.Migrations
{
    public partial class ReInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_Categories_CourseId",
                table: "CourseStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Courses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_Courses_CourseId",
                table: "CourseStudent",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_Courses_CourseId",
                table: "CourseStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_Categories_CourseId",
                table: "CourseStudent",
                column: "CourseId",
                principalTable: "Categories",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
