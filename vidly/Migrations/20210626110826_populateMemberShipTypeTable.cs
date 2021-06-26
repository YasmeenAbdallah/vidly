using Microsoft.EntityFrameworkCore.Migrations;

namespace vidly.Migrations
{
    public partial class populateMemberShipTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MemberShipType",
                columns: new[] { "Id", "SignUpFee", "DurationInMonthes", "DiscountRate" },
                values:new object[] {1,0,0,0}
                );
            migrationBuilder.InsertData(
               table: "MemberShipType",
               columns: new[] { "Id", "SignUpFee", "DurationInMonthes", "DiscountRate" },
               values: new object[] { 2, 30, 1,10 }
               );
            migrationBuilder.InsertData(
               table: "MemberShipType",
               columns: new[] { "Id", "SignUpFee", "DurationInMonthes", "DiscountRate" },
               values: new object[] { 3, 50, 2, 50 }
               );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
