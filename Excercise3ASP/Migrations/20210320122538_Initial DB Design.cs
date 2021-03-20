using Microsoft.EntityFrameworkCore.Migrations;

namespace Excercise3ASP.Migrations
{
    public partial class InitialDBDesign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentRegistrationForm",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idnumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Course = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    TshirtColor = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    AmountPaid = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentRegistrationForm", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentRegistrationForm");
        }
    }
}
