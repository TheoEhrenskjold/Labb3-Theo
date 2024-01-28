using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb3_Theo.Migrations
{
    /// <inheritdoc />
    public partial class addedPKtopersonal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klass",
                columns: table => new
                {
                    KlassID = table.Column<int>(type: "int", nullable: false),
                    Klassnamn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Klass__CF47A60D130FFF57", x => x.KlassID);
                });

            migrationBuilder.CreateTable(
                name: "Kurs",
                columns: table => new
                {
                    KursID = table.Column<int>(type: "int", nullable: false),
                    Kursnamn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Kurs__BCCFFF3BC51CDED4", x => x.KursID);
                });

            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    PersonalID = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                    Namn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Befattning = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Personal__28343713A8A7E4E1", x => x.PersonalID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    Namn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Personnummer = table.Column<int>(type: "int", nullable: true),
                    KlassID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Student__32C52A7951FD00C9", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK__Student__KlassID__3D5E1FD2",
                        column: x => x.KlassID,
                        principalTable: "Klass",
                        principalColumn: "KlassID");
                });

            migrationBuilder.CreateTable(
                name: "Lärare",
                columns: table => new
                {
                    LärarID = table.Column<int>(type: "int", nullable: false),
                    Namn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ämne = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Lärare__AD685B6C680731F4", x => x.LärarID);
                    table.ForeignKey(
                        name: "FK_Lärare_Personal",
                        column: x => x.LärarID,
                        principalTable: "Personal",
                        principalColumn: "PersonalID");
                });

            migrationBuilder.CreateTable(
                name: "Betyg",
                columns: table => new
                {
                    BetygsID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: true),
                    KursID = table.Column<int>(type: "int", nullable: true),
                    LärarID = table.Column<int>(type: "int", nullable: true),
                    Betyg = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Datum = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Betyg__2DD1328FE537F38F", x => x.BetygsID);
                    table.ForeignKey(
                        name: "FK__Betyg__KursID__4316F928",
                        column: x => x.KursID,
                        principalTable: "Kurs",
                        principalColumn: "KursID");
                    table.ForeignKey(
                        name: "FK__Betyg__LärarID__440B1D61",
                        column: x => x.LärarID,
                        principalTable: "Lärare",
                        principalColumn: "LärarID");
                    table.ForeignKey(
                        name: "FK__Betyg__StudentID__4222D4EF",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "StudentID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Betyg_KursID",
                table: "Betyg",
                column: "KursID");

            migrationBuilder.CreateIndex(
                name: "IX_Betyg_LärarID",
                table: "Betyg",
                column: "LärarID");

            migrationBuilder.CreateIndex(
                name: "IX_Betyg_StudentID",
                table: "Betyg",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_KlassID",
                table: "Student",
                column: "KlassID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Betyg");

            migrationBuilder.DropTable(
                name: "Kurs");

            migrationBuilder.DropTable(
                name: "Lärare");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Personal");

            migrationBuilder.DropTable(
                name: "Klass");
        }
    }
}
