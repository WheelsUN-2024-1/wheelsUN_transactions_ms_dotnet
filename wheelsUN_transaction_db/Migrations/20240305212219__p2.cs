using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wheelsUN_transaction_db.Migrations
{
    /// <inheritdoc />
    public partial class _p2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreditCards_Transactions_TransactionstransactionID",
                table: "CreditCards");

            migrationBuilder.DropColumn(
                name: "currency",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "driverAddress",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "driverCity",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "driverCountry",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "driverEmail",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "driverHomephone",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "driverId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "driverName",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "driverPhone",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "driverPostalCode",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "userAddress",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "userCity",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "userCountry",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "userEmail",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "userHomephone",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "userName",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "userPhone",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "userPostalCode",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "transactionID",
                table: "Transactions",
                newName: "transactionId");

            migrationBuilder.RenameColumn(
                name: "TransactionstransactionID",
                table: "CreditCards",
                newName: "TransactionstransactionId");

            migrationBuilder.RenameIndex(
                name: "IX_CreditCards_TransactionstransactionID",
                table: "CreditCards",
                newName: "IX_CreditCards_TransactionstransactionId");

            migrationBuilder.AddColumn<int>(
                name: "tripId",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditCards_Transactions_TransactionstransactionId",
                table: "CreditCards",
                column: "TransactionstransactionId",
                principalTable: "Transactions",
                principalColumn: "transactionId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreditCards_Transactions_TransactionstransactionId",
                table: "CreditCards");

            migrationBuilder.DropColumn(
                name: "tripId",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "transactionId",
                table: "Transactions",
                newName: "transactionID");

            migrationBuilder.RenameColumn(
                name: "TransactionstransactionId",
                table: "CreditCards",
                newName: "TransactionstransactionID");

            migrationBuilder.RenameIndex(
                name: "IX_CreditCards_TransactionstransactionId",
                table: "CreditCards",
                newName: "IX_CreditCards_TransactionstransactionID");

            migrationBuilder.AddColumn<string>(
                name: "currency",
                table: "Transactions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "driverAddress",
                table: "Transactions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "driverCity",
                table: "Transactions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "driverCountry",
                table: "Transactions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "driverEmail",
                table: "Transactions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "driverHomephone",
                table: "Transactions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "driverId",
                table: "Transactions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "driverName",
                table: "Transactions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "driverPhone",
                table: "Transactions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "driverPostalCode",
                table: "Transactions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "userAddress",
                table: "Transactions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "userCity",
                table: "Transactions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "userCountry",
                table: "Transactions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "userEmail",
                table: "Transactions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "userHomephone",
                table: "Transactions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Transactions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "userName",
                table: "Transactions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "userPhone",
                table: "Transactions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "userPostalCode",
                table: "Transactions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_CreditCards_Transactions_TransactionstransactionID",
                table: "CreditCards",
                column: "TransactionstransactionID",
                principalTable: "Transactions",
                principalColumn: "transactionID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
