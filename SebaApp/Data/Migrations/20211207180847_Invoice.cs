using Microsoft.EntityFrameworkCore.Migrations;

namespace SebaApp.Data.Migrations
{
    public partial class Invoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    feeType = table.Column<int>(type: "int", nullable: false),
                    paymentStatus = table.Column<int>(type: "int", nullable: false),
                    PayableTotal = table.Column<double>(type: "float", nullable: false),
                    DuoAmount = table.Column<double>(type: "float", nullable: false),
                    appointID = table.Column<int>(type: "int", nullable: false),
                    doctorID = table.Column<int>(type: "int", nullable: false),
                    PatienID = table.Column<int>(type: "int", nullable: false),
                    PatientPatienID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceID);
                    table.ForeignKey(
                        name: "FK_Invoices_Doctors_doctorID",
                        column: x => x.doctorID,
                        principalTable: "Doctors",
                        principalColumn: "doctorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_Patients_PatientPatienID",
                        column: x => x.PatientPatienID,
                        principalTable: "Patients",
                        principalColumn: "PatienID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_doctorID",
                table: "Invoices",
                column: "doctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_PatientPatienID",
                table: "Invoices",
                column: "PatientPatienID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");
        }
    }
}
