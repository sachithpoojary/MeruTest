using Microsoft.EntityFrameworkCore.Migrations;

namespace MeruTest.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    AreaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaName = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.AreaId);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustName = table.Column<string>(nullable: true),
                    CustMobNo = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    SubAreaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustId);
                });

            migrationBuilder.CreateTable(
                name: "SubAreas",
                columns: table => new
                {
                    SubAreaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubAreaName = table.Column<string>(nullable: true),
                    AreaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAreas", x => x.SubAreaId);
                });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "AreaId", "AreaName", "CityId" },
                values: new object[,]
                {
                    { 1, "West", 1 },
                    { 2, "South", 2 }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName", "State" },
                values: new object[,]
                {
                    { 1, "Mumbai", "MH" },
                    { 2, "Banglore", "KAR" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustId", "Address", "CustMobNo", "CustName", "SubAreaId" },
                values: new object[,]
                {
                    { 1, "Malad", "1234567890", "Sachith", 1 },
                    { 2, "Andheri", "1472583690", "Suyash", 2 },
                    { 3, "Kurla", "7894561230", "Jeetu", 2 }
                });

            migrationBuilder.InsertData(
                table: "SubAreas",
                columns: new[] { "SubAreaId", "AreaId", "SubAreaName" },
                values: new object[,]
                {
                    { 1, 1, "South West" },
                    { 2, 2, "South" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "SubAreas");
        }
    }
}
