using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaxiDispecer.Migrations
{
    public partial class migracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrator",
                columns: table => new
                {
                    AdministratorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<int>(nullable: false),
                    Password = table.Column<int>(nullable: false),
                    PermissionLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.AdministratorID);
                });

            migrationBuilder.CreateTable(
                name: "Osoba",
                columns: table => new
                {
                    OsobaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    JMBG = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    Sifra = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    BrojTransakcijskogRacuna = table.Column<string>(nullable: true),
                    BrojUgovora = table.Column<string>(nullable: true),
                    BrojLicence = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoba", x => x.OsobaID);
                });

            migrationBuilder.CreateTable(
                name: "Logiranja",
                columns: table => new
                {
                    LogiranjaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OsobaID = table.Column<int>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logiranja", x => x.LogiranjaID);
                    table.ForeignKey(
                        name: "FK_Logiranja_Osoba_OsobaID",
                        column: x => x.OsobaID,
                        principalTable: "Osoba",
                        principalColumn: "OsobaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Narudzba",
                columns: table => new
                {
                    NarudzbaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KlijentID = table.Column<int>(nullable: false),
                    PocetnaLokacija = table.Column<string>(nullable: true),
                    OdredisnaLokacija = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzba", x => x.NarudzbaID);
                    table.ForeignKey(
                        name: "FK_Narudzba_Osoba_KlijentID",
                        column: x => x.KlijentID,
                        principalTable: "Osoba",
                        principalColumn: "OsobaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Obavijest",
                columns: table => new
                {
                    ObavijestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OsobaID = table.Column<int>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    TekstObavijesti = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavijest", x => x.ObavijestID);
                    table.ForeignKey(
                        name: "FK_Obavijest_Osoba_OsobaID",
                        column: x => x.OsobaID,
                        principalTable: "Osoba",
                        principalColumn: "OsobaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voznja",
                columns: table => new
                {
                    VoznjaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VozacID = table.Column<int>(nullable: true),
                    NarudzbaID = table.Column<int>(nullable: false),
                    Aktivna = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voznja", x => x.VoznjaID);
                    table.ForeignKey(
                        name: "FK_Voznja_Narudzba_NarudzbaID",
                        column: x => x.NarudzbaID,
                        principalTable: "Narudzba",
                        principalColumn: "NarudzbaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Voznja_Osoba_VozacID",
                        column: x => x.VozacID,
                        principalTable: "Osoba",
                        principalColumn: "OsobaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OcjenaVozaca",
                columns: table => new
                {
                    OcjenaVozacaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VozacID = table.Column<int>(nullable: true),
                    KlijentID = table.Column<int>(nullable: true),
                    VoznjaID = table.Column<int>(nullable: true),
                    Ocjena = table.Column<int>(nullable: false),
                    Komentar = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OcjenaVozaca", x => x.OcjenaVozacaID);
                    table.ForeignKey(
                        name: "FK_OcjenaVozaca_Osoba_KlijentID",
                        column: x => x.KlijentID,
                        principalTable: "Osoba",
                        principalColumn: "OsobaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OcjenaVozaca_Osoba_VozacID",
                        column: x => x.VozacID,
                        principalTable: "Osoba",
                        principalColumn: "OsobaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OcjenaVozaca_Voznja_VoznjaID",
                        column: x => x.VoznjaID,
                        principalTable: "Voznja",
                        principalColumn: "VoznjaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Logiranja_OsobaID",
                table: "Logiranja",
                column: "OsobaID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_KlijentID",
                table: "Narudzba",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_Obavijest_OsobaID",
                table: "Obavijest",
                column: "OsobaID");

            migrationBuilder.CreateIndex(
                name: "IX_OcjenaVozaca_KlijentID",
                table: "OcjenaVozaca",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_OcjenaVozaca_VozacID",
                table: "OcjenaVozaca",
                column: "VozacID");

            migrationBuilder.CreateIndex(
                name: "IX_OcjenaVozaca_VoznjaID",
                table: "OcjenaVozaca",
                column: "VoznjaID");

            migrationBuilder.CreateIndex(
                name: "IX_Voznja_NarudzbaID",
                table: "Voznja",
                column: "NarudzbaID");

            migrationBuilder.CreateIndex(
                name: "IX_Voznja_VozacID",
                table: "Voznja",
                column: "VozacID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrator");

            migrationBuilder.DropTable(
                name: "Logiranja");

            migrationBuilder.DropTable(
                name: "Obavijest");

            migrationBuilder.DropTable(
                name: "OcjenaVozaca");

            migrationBuilder.DropTable(
                name: "Voznja");

            migrationBuilder.DropTable(
                name: "Narudzba");

            migrationBuilder.DropTable(
                name: "Osoba");
        }
    }
}
