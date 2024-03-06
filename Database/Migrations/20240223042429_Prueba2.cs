using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestorDePacientes.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Prueba2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Test",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Result",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TestId",
                table: "Result",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Test_PatientId",
                table: "Test",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_PatientId",
                table: "Result",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_TestId",
                table: "Result",
                column: "TestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Patient_PatientId",
                table: "Result",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Test_TestId",
                table: "Result",
                column: "TestId",
                principalTable: "Test",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Test_Patient_PatientId",
                table: "Test",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Result_Patient_PatientId",
                table: "Result");

            migrationBuilder.DropForeignKey(
                name: "FK_Result_Test_TestId",
                table: "Result");

            migrationBuilder.DropForeignKey(
                name: "FK_Test_Patient_PatientId",
                table: "Test");

            migrationBuilder.DropIndex(
                name: "IX_Test_PatientId",
                table: "Test");

            migrationBuilder.DropIndex(
                name: "IX_Result_PatientId",
                table: "Result");

            migrationBuilder.DropIndex(
                name: "IX_Result_TestId",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Test");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "TestId",
                table: "Result");
        }
    }
}
