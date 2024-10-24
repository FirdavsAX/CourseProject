using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseProject.Migrations
{
    /// <inheritdoc />
    public partial class Changed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forms_AspNetUsers_UserId1",
                table: "Forms");

            migrationBuilder.DropForeignKey(
                name: "FK_Templates_AspNetUsers_AuthorId1",
                table: "Templates");

            migrationBuilder.DropIndex(
                name: "IX_Templates_AuthorId1",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "AuthorId1",
                table: "Templates");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Templates",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "Forms",
                newName: "AuthorId1");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Forms",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Forms_UserId1",
                table: "Forms",
                newName: "IX_Forms_AuthorId1");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "Templates",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Templates_AuthorId",
                table: "Templates",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Forms_AspNetUsers_AuthorId1",
                table: "Forms",
                column: "AuthorId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Templates_AspNetUsers_AuthorId",
                table: "Templates",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forms_AspNetUsers_AuthorId1",
                table: "Forms");

            migrationBuilder.DropForeignKey(
                name: "FK_Templates_AspNetUsers_AuthorId",
                table: "Templates");

            migrationBuilder.DropIndex(
                name: "IX_Templates_AuthorId",
                table: "Templates");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Templates",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "AuthorId1",
                table: "Forms",
                newName: "UserId1");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Forms",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Forms_AuthorId1",
                table: "Forms",
                newName: "IX_Forms_UserId1");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Templates",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "AuthorId1",
                table: "Templates",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Templates_AuthorId1",
                table: "Templates",
                column: "AuthorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Forms_AspNetUsers_UserId1",
                table: "Forms",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Templates_AspNetUsers_AuthorId1",
                table: "Templates",
                column: "AuthorId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
