using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_commerce_backend.Migrations
{
    public partial class WhislistTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Whislist_Users_UserId",
                table: "Whislist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Whislist",
                table: "Whislist");

            migrationBuilder.RenameTable(
                name: "Whislist",
                newName: "Whislists");

            migrationBuilder.RenameIndex(
                name: "IX_Whislist_UserId",
                table: "Whislists",
                newName: "IX_Whislists_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Whislists",
                table: "Whislists",
                column: "WhislistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Whislists_Users_UserId",
                table: "Whislists",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Whislists_Users_UserId",
                table: "Whislists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Whislists",
                table: "Whislists");

            migrationBuilder.RenameTable(
                name: "Whislists",
                newName: "Whislist");

            migrationBuilder.RenameIndex(
                name: "IX_Whislists_UserId",
                table: "Whislist",
                newName: "IX_Whislist_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Whislist",
                table: "Whislist",
                column: "WhislistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Whislist_Users_UserId",
                table: "Whislist",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
