using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wheelsUN_transaction_db.Migrations
{
    /// <inheritdoc />
    public partial class _p4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreditCards_Transactions_TransactionstransactionId",
                table: "CreditCards");

            migrationBuilder.DropIndex(
                name: "IX_CreditCards_TransactionstransactionId",
                table: "CreditCards");

            migrationBuilder.DropColumn(
                name: "TransactionstransactionId",
                table: "CreditCards");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TransactionstransactionId",
                table: "CreditCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CreditCards_TransactionstransactionId",
                table: "CreditCards",
                column: "TransactionstransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CreditCards_Transactions_TransactionstransactionId",
                table: "CreditCards",
                column: "TransactionstransactionId",
                principalTable: "Transactions",
                principalColumn: "transactionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
