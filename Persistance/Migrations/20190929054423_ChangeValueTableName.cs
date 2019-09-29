using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class ChangeValueTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropPrimaryKey(
            //     name: "PK_MyProperty",
            //     table: "MyProperty");

            // migrationBuilder.RenameTable(
            //     name: "MyProperty",
            //     newName: "Values");

            // migrationBuilder.AddPrimaryKey(
            //     name: "PK_Values",
            //     table: "Values",
            //     column: "Id");

            migrationBuilder.CreateTable(
                name: "Values",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Value", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropPrimaryKey(
            //     name: "PK_Values",
            //     table: "Values");

            // migrationBuilder.RenameTable(
            //     name: "Values",
            //     newName: "MyProperty");

            // migrationBuilder.AddPrimaryKey(
            //     name: "PK_MyProperty",
            //     table: "MyProperty",
            //     column: "Id");

            migrationBuilder.DropTable(
                name : "MyProperty"
            );
        }
    }
}
