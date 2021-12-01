using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SebaApp.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    doctorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mobile = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    created = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.doctorID);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatienID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mobile = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatienCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    created = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatienID);
                });

            migrationBuilder.CreateTable(
                name: "DoctorImages",
                columns: table => new
                {
                    DimageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doctorImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doctorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorImages", x => x.DimageID);
                    table.ForeignKey(
                        name: "FK_DoctorImages_Doctors_doctorID",
                        column: x => x.doctorID,
                        principalTable: "Doctors",
                        principalColumn: "doctorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorInformation",
                columns: table => new
                {
                    infoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecialistIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experiance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Hospital = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    officeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailingAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateofBirth = table.Column<DateTime>(type: "date", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doctorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorInformation", x => x.infoID);
                    table.ForeignKey(
                        name: "FK_DoctorInformation_Doctors_doctorID",
                        column: x => x.doctorID,
                        principalTable: "Doctors",
                        principalColumn: "doctorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ScheduleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SetDay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doctorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ScheduleID);
                    table.ForeignKey(
                        name: "FK_Schedules_Doctors_doctorID",
                        column: x => x.doctorID,
                        principalTable: "Doctors",
                        principalColumn: "doctorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "visitingPrices",
                columns: table => new
                {
                    priceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstVisit = table.Column<int>(type: "int", nullable: false),
                    SecondVisit = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    doctorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitingPrices", x => x.priceID);
                    table.ForeignKey(
                        name: "FK_visitingPrices_Doctors_doctorID",
                        column: x => x.doctorID,
                        principalTable: "Doctors",
                        principalColumn: "doctorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountBalances",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalAmount = table.Column<double>(type: "float", nullable: false),
                    AccountStatus = table.Column<int>(type: "int", nullable: false),
                    PatienID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountBalances", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_AccountBalances_Patients_PatienID",
                        column: x => x.PatienID,
                        principalTable: "Patients",
                        principalColumn: "PatienID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    doctorID = table.Column<int>(type: "int", nullable: false),
                    PatienID = table.Column<int>(type: "int", nullable: false),
                    appointID = table.Column<int>(type: "int", nullable: false),
                    AppointmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppoinmentDate = table.Column<DateTime>(type: "date", nullable: false),
                    TimeSlot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About_Appointment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppointmentStatus = table.Column<int>(type: "int", nullable: false),
                    created = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => new { x.doctorID, x.PatienID });
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_doctorID",
                        column: x => x.doctorID,
                        principalTable: "Doctors",
                        principalColumn: "doctorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatienID",
                        column: x => x.PatienID,
                        principalTable: "Patients",
                        principalColumn: "PatienID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientInformation",
                columns: table => new
                {
                    PatientinfoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateofBirth = table.Column<DateTime>(type: "date", nullable: false),
                    weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bloodgroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailingAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatienID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientInformation", x => x.PatientinfoID);
                    table.ForeignKey(
                        name: "FK_PatientInformation_Patients_PatienID",
                        column: x => x.PatienID,
                        principalTable: "Patients",
                        principalColumn: "PatienID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountBalances_PatienID",
                table: "AccountBalances",
                column: "PatienID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatienID",
                table: "Appointments",
                column: "PatienID");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorImages_doctorID",
                table: "DoctorImages",
                column: "doctorID");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorInformation_doctorID",
                table: "DoctorInformation",
                column: "doctorID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PatientInformation_PatienID",
                table: "PatientInformation",
                column: "PatienID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_doctorID",
                table: "Schedules",
                column: "doctorID");

            migrationBuilder.CreateIndex(
                name: "IX_visitingPrices_doctorID",
                table: "visitingPrices",
                column: "doctorID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountBalances");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "DoctorImages");

            migrationBuilder.DropTable(
                name: "DoctorInformation");

            migrationBuilder.DropTable(
                name: "PatientInformation");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "visitingPrices");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
