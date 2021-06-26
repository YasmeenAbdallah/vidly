using Microsoft.EntityFrameworkCore.Migrations;

namespace vidly.Migrations
{
    public partial class AddMemberShipType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemberShipTypeId",
                table: "customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MemberShipType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SignUpFee = table.Column<short>(type: "smallint", nullable: false),
                    DurationInMonthes = table.Column<byte>(type: "tinyint", nullable: false),
                    DiscountRate = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberShipType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_customers_MemberShipTypeId",
                table: "customers",
                column: "MemberShipTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_MemberShipType_MemberShipTypeId",
                table: "customers",
                column: "MemberShipTypeId",
                principalTable: "MemberShipType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_MemberShipType_MemberShipTypeId",
                table: "customers");

            migrationBuilder.DropTable(
                name: "MemberShipType");

            migrationBuilder.DropIndex(
                name: "IX_customers_MemberShipTypeId",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "MemberShipTypeId",
                table: "customers");
        }
    }
}
