using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCustomerService.Migrations
{
    /// <inheritdoc />
    public partial class ServiceRecordClassEdited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "ServiceRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "ServiceRecords");
        }
    }
}
