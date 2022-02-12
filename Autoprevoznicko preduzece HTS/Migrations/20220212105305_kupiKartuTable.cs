using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Autoprevoznicko_preduzece_HTS.Migrations
{
    public partial class kupiKartuTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kupiKartu",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    tipKarteID = table.Column<int>(nullable: false),
                    vrstaKarteID = table.Column<int>(nullable: false),
                    DatumVadjenjaKarte = table.Column<DateTime>(nullable: false),
                    DatumVazenjaKarte = table.Column<DateTime>(nullable: false),
                    gradskaLinijaID = table.Column<int>(nullable: false),
                    BrojPutnika = table.Column<int>(nullable: false),
                    Pravac = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kupiKartu", x => x.ID);
                    table.ForeignKey(
                        name: "FK_kupiKartu_gradskeLinije_gradskaLinijaID",
                        column: x => x.gradskaLinijaID,
                        principalTable: "gradskeLinije",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_kupiKartu_tipKarte_tipKarteID",
                        column: x => x.tipKarteID,
                        principalTable: "tipKarte",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_kupiKartu_vrstaKarte_vrstaKarteID",
                        column: x => x.vrstaKarteID,
                        principalTable: "vrstaKarte",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_kupiKartu_gradskaLinijaID",
                table: "kupiKartu",
                column: "gradskaLinijaID");

            migrationBuilder.CreateIndex(
                name: "IX_kupiKartu_tipKarteID",
                table: "kupiKartu",
                column: "tipKarteID");

            migrationBuilder.CreateIndex(
                name: "IX_kupiKartu_vrstaKarteID",
                table: "kupiKartu",
                column: "vrstaKarteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kupiKartu");
        }
    }
}
