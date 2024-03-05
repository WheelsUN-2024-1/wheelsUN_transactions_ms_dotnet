﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wheelsUN_transaction_db.Data;

#nullable disable

namespace wheelsUN_transaction_db.Migrations
{
    [DbContext(typeof(wheelsUN_transaction_context))]
    [Migration("20240305212219__p2")]
    partial class _p2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("wheelsUN_transaction_db.Data.CreditCard", b =>
                {
                    b.Property<int>("creditCardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("creditCardId"));

                    b.Property<int>("TransactionstransactionId")
                        .HasColumnType("int");

                    b.Property<string>("expirationDate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("number")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("securityCode")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("creditCardId");

                    b.HasIndex("TransactionstransactionId");

                    b.ToTable("CreditCards");
                });

            modelBuilder.Entity("wheelsUN_transaction_db.Data.Transaction", b =>
                {
                    b.Property<int>("transactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("transactionId"));

                    b.Property<int>("creditCardId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("orderId")
                        .HasColumnType("int");

                    b.Property<string>("paymentMethod")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("referenceCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("transactionIdPay")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("tripId")
                        .HasColumnType("int");

                    b.Property<int>("value")
                        .HasColumnType("int");

                    b.HasKey("transactionId");

                    b.HasIndex("creditCardId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("wheelsUN_transaction_db.Data.CreditCard", b =>
                {
                    b.HasOne("wheelsUN_transaction_db.Data.Transaction", "Transactions")
                        .WithMany("CreditCards")
                        .HasForeignKey("TransactionstransactionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("wheelsUN_transaction_db.Data.Transaction", b =>
                {
                    b.HasOne("wheelsUN_transaction_db.Data.CreditCard", "CreditCard")
                        .WithMany()
                        .HasForeignKey("creditCardId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CreditCard");
                });

            modelBuilder.Entity("wheelsUN_transaction_db.Data.Transaction", b =>
                {
                    b.Navigation("CreditCards");
                });
#pragma warning restore 612, 618
        }
    }
}
