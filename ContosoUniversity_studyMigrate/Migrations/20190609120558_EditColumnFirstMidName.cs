﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity_studyMigrate.Migrations
{
    public partial class EditColumnFirstMidName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstMidName",
                table: "Student",
                newName: "FirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Student",
                newName: "FirstMidName");
        }
    }
}
