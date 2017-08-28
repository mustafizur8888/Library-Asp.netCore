using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchHours_LibraryBranches_LibraryBranchId",
                table: "BranchHours");

            migrationBuilder.RenameColumn(
                name: "LibraryBranchId",
                table: "BranchHours",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_BranchHours_LibraryBranchId",
                table: "BranchHours",
                newName: "IX_BranchHours_BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchHours_LibraryBranches_BranchId",
                table: "BranchHours",
                column: "BranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchHours_LibraryBranches_BranchId",
                table: "BranchHours");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "BranchHours",
                newName: "LibraryBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_BranchHours_BranchId",
                table: "BranchHours",
                newName: "IX_BranchHours_LibraryBranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchHours_LibraryBranches_LibraryBranchId",
                table: "BranchHours",
                column: "LibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
