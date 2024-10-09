﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManager.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaoModelo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Books_BookId",
                table: "Loans");

            migrationBuilder.DropIndex(
                name: "IX_Loans_BookId",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Loans");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_IdBook",
                table: "Loans",
                column: "IdBook");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Books_IdBook",
                table: "Loans",
                column: "IdBook",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Books_IdBook",
                table: "Loans");

            migrationBuilder.DropIndex(
                name: "IX_Loans_IdBook",
                table: "Loans");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Loans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Loans_BookId",
                table: "Loans",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Books_BookId",
                table: "Loans",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
