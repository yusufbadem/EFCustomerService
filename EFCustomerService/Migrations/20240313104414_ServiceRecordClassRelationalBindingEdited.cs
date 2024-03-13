using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCustomerService.Migrations
{
    /// <inheritdoc />
    public partial class ServiceRecordClassRelationalBindingEdited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_CustomerId",
                table: "ServiceRecords",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_StatusId",
                table: "ServiceRecords",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecords_Customers_CustomerId",
                table: "ServiceRecords",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecords_ServiceStatuses_StatusId",
                table: "ServiceRecords",
                column: "StatusId",
                principalTable: "ServiceStatuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRecords_Customers_CustomerId",
                table: "ServiceRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRecords_ServiceStatuses_StatusId",
                table: "ServiceRecords");

            migrationBuilder.DropIndex(
                name: "IX_ServiceRecords_CustomerId",
                table: "ServiceRecords");

            migrationBuilder.DropIndex(
                name: "IX_ServiceRecords_StatusId",
                table: "ServiceRecords");
        }
    }
}
