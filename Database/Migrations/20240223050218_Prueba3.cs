using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestorDePacientes.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Prueba3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Result_TestId",
                table: "Result");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Date",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientDateId",
                table: "Date",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Result_TestId",
                table: "Result",
                column: "TestId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Date_DoctorId",
                table: "Date",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Date_PatientDateId",
                table: "Date",
                column: "PatientDateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Date_Doctor_DoctorId",
                table: "Date",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Date_Patient_PatientDateId",
                table: "Date",
                column: "PatientDateId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Date_Doctor_DoctorId",
                table: "Date");

            migrationBuilder.DropForeignKey(
                name: "FK_Date_Patient_PatientDateId",
                table: "Date");

            migrationBuilder.DropIndex(
                name: "IX_Result_TestId",
                table: "Result");

            migrationBuilder.DropIndex(
                name: "IX_Date_DoctorId",
                table: "Date");

            migrationBuilder.DropIndex(
                name: "IX_Date_PatientDateId",
                table: "Date");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Date");

            migrationBuilder.DropColumn(
                name: "PatientDateId",
                table: "Date");

            migrationBuilder.CreateIndex(
                name: "IX_Result_TestId",
                table: "Result",
                column: "TestId");
        }
    }
}
