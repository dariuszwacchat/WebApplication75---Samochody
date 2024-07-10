using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ulica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumerUlicy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Miejscowosc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pesel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kraj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KodPocztowy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataUrodzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Plec = table.Column<int>(type: "int", nullable: false),
                    DataDodania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DaneOsobowe",
                columns: table => new
                {
                    DaneOsoboweId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ulica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumerUlicy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Miejscowosc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pesel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kraj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KodPocztowy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataUrodzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Plec = table.Column<int>(type: "int", nullable: false),
                    RodzajOsoby = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataDodania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RodzajTransakcji = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaneOsobowe", x => x.DaneOsoboweId);
                });

            migrationBuilder.CreateTable(
                name: "Marki",
                columns: table => new
                {
                    MarkaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marki", x => x.MarkaId);
                });

            migrationBuilder.CreateTable(
                name: "RodzajeTowarow",
                columns: table => new
                {
                    RodzajTowaruId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RodzajeTowarow", x => x.RodzajTowaruId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoggingErrors",
                columns: table => new
                {
                    LoggingErrorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Controller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataUtworzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoggingErrors", x => x.LoggingErrorId);
                    table.ForeignKey(
                        name: "FK_LoggingErrors_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PhotosUser",
                columns: table => new
                {
                    PhotoUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhotoData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotosUser", x => x.PhotoUserId);
                    table.ForeignKey(
                        name: "FK_PhotosUser_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Firmy",
                columns: table => new
                {
                    FirmaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NazwaFirmy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Regon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kraj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Powiat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ulica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumerUlicy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WlascicielId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmy", x => x.FirmaId);
                    table.ForeignKey(
                        name: "FK_Firmy_DaneOsobowe_WlascicielId",
                        column: x => x.WlascicielId,
                        principalTable: "DaneOsobowe",
                        principalColumn: "DaneOsoboweId");
                });

            migrationBuilder.CreateTable(
                name: "PhotosRodzajTowaru",
                columns: table => new
                {
                    PhotoRodzajTowaruId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhotoData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    RodzajTowaruId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotosRodzajTowaru", x => x.PhotoRodzajTowaruId);
                    table.ForeignKey(
                        name: "FK_PhotosRodzajTowaru_RodzajeTowarow_RodzajTowaruId",
                        column: x => x.RodzajTowaruId,
                        principalTable: "RodzajeTowarow",
                        principalColumn: "RodzajTowaruId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Towary",
                columns: table => new
                {
                    TowarId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cena = table.Column<double>(type: "float", nullable: false),
                    Sztuk = table.Column<int>(type: "int", nullable: false),
                    Rabat = table.Column<double>(type: "float", nullable: false),
                    Kolor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wysokosc = table.Column<double>(type: "float", nullable: false),
                    Szerokosc = table.Column<double>(type: "float", nullable: false),
                    Waga = table.Column<double>(type: "float", nullable: false),
                    RokProdukcji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Przebieg = table.Column<double>(type: "float", nullable: false),
                    RodzajHandlu = table.Column<int>(type: "int", nullable: false),
                    DataDodania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RodzajTowaruId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MarkaId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towary", x => x.TowarId);
                    table.ForeignKey(
                        name: "FK_Towary_Marki_MarkaId",
                        column: x => x.MarkaId,
                        principalTable: "Marki",
                        principalColumn: "MarkaId");
                    table.ForeignKey(
                        name: "FK_Towary_RodzajeTowarow_RodzajTowaruId",
                        column: x => x.RodzajTowaruId,
                        principalTable: "RodzajeTowarow",
                        principalColumn: "RodzajTowaruId");
                });

            migrationBuilder.CreateTable(
                name: "PhotosFirma",
                columns: table => new
                {
                    PhotoFirmaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhotoData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FirmaId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotosFirma", x => x.PhotoFirmaId);
                    table.ForeignKey(
                        name: "FK_PhotosFirma_Firmy_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmy",
                        principalColumn: "FirmaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kupna",
                columns: table => new
                {
                    KupnoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DataZakupu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TowarId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RodzajTowaruId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FirmaKupujacyId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FirmaSprzedajacyId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DaneOsoboweSprzedajacyId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupna", x => x.KupnoId);
                    table.ForeignKey(
                        name: "FK_Kupna_DaneOsobowe_DaneOsoboweSprzedajacyId",
                        column: x => x.DaneOsoboweSprzedajacyId,
                        principalTable: "DaneOsobowe",
                        principalColumn: "DaneOsoboweId");
                    table.ForeignKey(
                        name: "FK_Kupna_Firmy_FirmaKupujacyId",
                        column: x => x.FirmaKupujacyId,
                        principalTable: "Firmy",
                        principalColumn: "FirmaId");
                    table.ForeignKey(
                        name: "FK_Kupna_Firmy_FirmaSprzedajacyId",
                        column: x => x.FirmaSprzedajacyId,
                        principalTable: "Firmy",
                        principalColumn: "FirmaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kupna_RodzajeTowarow_RodzajTowaruId",
                        column: x => x.RodzajTowaruId,
                        principalTable: "RodzajeTowarow",
                        principalColumn: "RodzajTowaruId");
                    table.ForeignKey(
                        name: "FK_Kupna_Towary_TowarId",
                        column: x => x.TowarId,
                        principalTable: "Towary",
                        principalColumn: "TowarId");
                });

            migrationBuilder.CreateTable(
                name: "PhotosTowar",
                columns: table => new
                {
                    PhotoTowarId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhotoData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    TowarId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotosTowar", x => x.PhotoTowarId);
                    table.ForeignKey(
                        name: "FK_PhotosTowar_Towary_TowarId",
                        column: x => x.TowarId,
                        principalTable: "Towary",
                        principalColumn: "TowarId");
                });

            migrationBuilder.CreateTable(
                name: "Sprzedaze",
                columns: table => new
                {
                    SprzedazId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CenaSprzedazyNetto22 = table.Column<double>(type: "float", nullable: false),
                    CenaSprzedazyBrutto22 = table.Column<double>(type: "float", nullable: false),
                    ZyskBrutto = table.Column<double>(type: "float", nullable: false),
                    ZyskNetto = table.Column<double>(type: "float", nullable: false),
                    DataSprzedazy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirmaId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    KupujacyId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TowarId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RodzajTowaruId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprzedaze", x => x.SprzedazId);
                    table.ForeignKey(
                        name: "FK_Sprzedaze_DaneOsobowe_KupujacyId",
                        column: x => x.KupujacyId,
                        principalTable: "DaneOsobowe",
                        principalColumn: "DaneOsoboweId");
                    table.ForeignKey(
                        name: "FK_Sprzedaze_Firmy_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmy",
                        principalColumn: "FirmaId");
                    table.ForeignKey(
                        name: "FK_Sprzedaze_RodzajeTowarow_RodzajTowaruId",
                        column: x => x.RodzajTowaruId,
                        principalTable: "RodzajeTowarow",
                        principalColumn: "RodzajTowaruId");
                    table.ForeignKey(
                        name: "FK_Sprzedaze_Towary_TowarId",
                        column: x => x.TowarId,
                        principalTable: "Towary",
                        principalColumn: "TowarId");
                });

            migrationBuilder.CreateTable(
                name: "PhotosKupno",
                columns: table => new
                {
                    PhotoKupnoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhotoData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    KupnoId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotosKupno", x => x.PhotoKupnoId);
                    table.ForeignKey(
                        name: "FK_PhotosKupno_Kupna_KupnoId",
                        column: x => x.KupnoId,
                        principalTable: "Kupna",
                        principalColumn: "KupnoId");
                });

            migrationBuilder.CreateTable(
                name: "PhotosSprzedaz",
                columns: table => new
                {
                    PhotoSprzedazId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhotoData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SprzedazId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotosSprzedaz", x => x.PhotoSprzedazId);
                    table.ForeignKey(
                        name: "FK_PhotosSprzedaz_Sprzedaze_SprzedazId",
                        column: x => x.SprzedazId,
                        principalTable: "Sprzedaze",
                        principalColumn: "SprzedazId");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bfc52cd1-8119-46a4-913c-75319c0cb7cc", "18c24fbe-52f0-4c37-a777-0664cec9697d", "Personel", "Personel" },
                    { "19abf218-cf64-4de7-8911-6a78e5cb58be", "b87be928-7b3c-41c0-947e-b497e69552e0", "Administrator", "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataDodania", "DataUrodzenia", "Email", "EmailConfirmed", "Imie", "KodPocztowy", "Kraj", "LockoutEnabled", "LockoutEnd", "Miejscowosc", "Nazwisko", "NormalizedEmail", "NormalizedUserName", "NumerUlicy", "PasswordHash", "Pesel", "PhoneNumber", "PhoneNumberConfirmed", "Plec", "SecurityStamp", "Telefon", "TwoFactorEnabled", "Ulica", "UserName" },
                values: new object[,]
                {
                    { "d6c0fb0d-8652-430e-bc7e-d7efaf9c67b1", 0, "2f35b58f-eb6f-457c-a16e-7adc6b4ed3cd", new DateTime(2024, 2, 22, 19, 50, 57, 806, DateTimeKind.Local).AddTicks(3577), new DateTime(1988, 2, 22, 19, 50, 57, 795, DateTimeKind.Local).AddTicks(8598), "admin@admin.pl", true, "sxmłesia", "12-222", "Polska", false, null, "bniliłr", "iajjłdp", "ADMIN@ADMIN.PL", "ADMIN@ADMIN.PL", "87", "AQAAAAEAACcQAAAAEEctbuA9dRBtgeve6f4aIzMZnQpsJd59DffUbaotRd6jCQBRFCexKfC1P+Rk2JktBQ==", null, null, false, 0, "20a947d6-7919-4ac4-b919-8e5044c6323a", "235235235", false, "eexoocpł. ", "admin@admin.pl" },
                    { "f516e2a2-9c8a-4e7d-8c0e-9403187d22c3", 0, "99bc5816-2e9e-420e-a1dc-8ec60705dfb1", new DateTime(2024, 2, 22, 19, 50, 57, 918, DateTimeKind.Local).AddTicks(4538), new DateTime(1978, 2, 22, 19, 50, 57, 918, DateTimeKind.Local).AddTicks(4389), "pracownik1@pracownik1.pl", true, "ryjedxk", "12-222", "Polska", false, null, "aaafuyzk", "dpbdnółcxp", "PRACOWNIK1@PRACOWNIK1.PL", "PRACOWNIK1@PRACOWNIK1.PL", "5", "AQAAAAEAACcQAAAAEBAvOUgLAmQZTSNH7ssW9vAH5ZJ+ISt+CgukHA/9haKyxK2OUi7yrJrgS6H3HCzgeg==", null, null, false, 0, "ecf7bd5e-11c0-47cd-ab0c-513c33cf281d", "235235235", false, "hlóp eyłznbxubz. ", "pracownik1@pracownik1.pl" },
                    { "fd5b40dd-ba49-42f5-8dcf-27fdd62625f7", 0, "359c7842-512c-409c-94cb-bdcb63466808", new DateTime(2024, 2, 22, 19, 50, 57, 927, DateTimeKind.Local).AddTicks(5211), new DateTime(1994, 2, 22, 19, 50, 57, 927, DateTimeKind.Local).AddTicks(5120), "pracownik2@pracownik2.pl", true, "nebfnptnt", "12-222", "Polska", false, null, "zjcggsyłrb", "crhyyxtn", "PRACOWNIK2@PRACOWNIK2.PL", "PRACOWNIK2@PRACOWNIK2.PL", "43", "AQAAAAEAACcQAAAAEHGnQgWes86ckcK9NN/j5etO2ZK44zZvrTkSsbDsDK+0bOl5wlWBJGTkPNJBT44VMg==", null, null, false, 0, "f69cf28c-fdaf-4b65-95da-fa2e8ac6f114", "235235235", false, "imxlx osxlłófdos. ", "pracownik2@pracownik2.pl" }
                });

            migrationBuilder.InsertData(
                table: "Marki",
                columns: new[] { "MarkaId", "Nazwa" },
                values: new object[,]
                {
                    { "6c5d2cba-19e7-4d48-a69d-532e132d4277", "BMW" },
                    { "f8ce72b4-feae-4333-a1fa-f8ac37708d5a", "Audi" },
                    { "478056c0-d781-47a7-a493-f45b4c1df1dd", "Toyota" },
                    { "5d8ce27a-1cb8-4951-a83b-655a4b30d155", "Lamburgini" },
                    { "5b536413-9fe1-494c-9ee8-dc9a5c1a2a1d", "Bentley" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { "19abf218-cf64-4de7-8911-6a78e5cb58be", "d6c0fb0d-8652-430e-bc7e-d7efaf9c67b1", "ApplicationUserRole" },
                    { "bfc52cd1-8119-46a4-913c-75319c0cb7cc", "f516e2a2-9c8a-4e7d-8c0e-9403187d22c3", "ApplicationUserRole" },
                    { "bfc52cd1-8119-46a4-913c-75319c0cb7cc", "fd5b40dd-ba49-42f5-8dcf-27fdd62625f7", "ApplicationUserRole" }
                });

            migrationBuilder.InsertData(
                table: "PhotosUser",
                columns: new[] { "PhotoUserId", "PhotoData", "UserId" },
                values: new object[,]
                {
                    { "8bcbd77c-5714-4c23-8b42-217755bef420", new byte[] { 255, 216, 255, 224, 0, 16, 74, 70, 73, 70, 0, 1, 1, 1, 0, 96, 0, 96, 0, 0, 255, 219, 0, 67, 0, 4, 2, 3, 3, 3, 2, 4, 3, 3, 3, 4, 4, 4, 4, 5, 9, 6, 5, 5, 5, 5, 11, 8, 8, 6, 9, 13, 11, 13, 13, 13, 11, 12, 12, 14, 16, 20, 17, 14, 15, 19, 15, 12, 12, 18, 24, 18, 19, 21, 22, 23, 23, 23, 14, 17, 25, 27, 25, 22, 26, 20, 22, 23, 22, 255, 219, 0, 67, 1, 4, 4, 4, 5, 5, 5, 10, 6, 6, 10, 22, 15, 12, 15, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 255, 192, 0, 17, 8, 0, 192, 0, 192, 3, 1, 34, 0, 2, 17, 1, 3, 17, 1, 255, 196, 0, 31, 0, 0, 1, 5, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 255, 196, 0, 181, 16, 0, 2, 1, 3, 3, 2, 4, 3, 5, 5, 4, 4, 0, 0, 1, 125, 1, 2, 3, 0, 4, 17, 5, 18, 33, 49, 65, 6, 19, 81, 97, 7, 34, 113, 20, 50, 129, 145, 161, 8, 35, 66, 177, 193, 21, 82, 209, 240, 36, 51, 98, 114, 130, 9, 10, 22, 23, 24, 25, 26, 37, 38, 39, 40, 41, 42, 52, 53, 54, 55, 56, 57, 58, 67, 68, 69, 70, 71, 72, 73, 74, 83, 84, 85, 86, 87, 88, 89, 90, 99, 100, 101, 102, 103, 104, 105, 106, 115, 116, 117, 118, 119, 120, 121, 122, 131, 132, 133, 134, 135, 136, 137, 138, 146, 147, 148, 149, 150, 151, 152, 153, 154, 162, 163, 164, 165, 166, 167, 168, 169, 170, 178, 179, 180, 181, 182, 183, 184, 185, 186, 194, 195, 196, 197, 198, 199, 200, 201, 202, 210, 211, 212, 213, 214, 215, 216, 217, 218, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 255, 196, 0, 31, 1, 0, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 255, 196, 0, 181, 17, 0, 2, 1, 2, 4, 4, 3, 4, 7, 5, 4, 4, 0, 1, 2, 119, 0, 1, 2, 3, 17, 4, 5, 33, 49, 6, 18, 65, 81, 7, 97, 113, 19, 34, 50, 129, 8, 20, 66, 145, 161, 177, 193, 9, 35, 51, 82, 240, 21, 98, 114, 209, 10, 22, 36, 52, 225, 37, 241, 23, 24, 25, 26, 38, 39, 40, 41, 42, 53, 54, 55, 56, 57, 58, 67, 68, 69, 70, 71, 72, 73, 74, 83, 84, 85, 86, 87, 88, 89, 90, 99, 100, 101, 102, 103, 104, 105, 106, 115, 116, 117, 118, 119, 120, 121, 122, 130, 131, 132, 133, 134, 135, 136, 137, 138, 146, 147, 148, 149, 150, 151, 152, 153, 154, 162, 163, 164, 165, 166, 167, 168, 169, 170, 178, 179, 180, 181, 182, 183, 184, 185, 186, 194, 195, 196, 197, 198, 199, 200, 201, 202, 210, 211, 212, 213, 214, 215, 216, 217, 218, 226, 227, 228, 229, 230, 231, 232, 233, 234, 242, 243, 244, 245, 246, 247, 248, 249, 250, 255, 218, 0, 12, 3, 1, 0, 2, 17, 3, 17, 0, 63, 0, 251, 235, 159, 74, 57, 244, 163, 138, 56, 160, 3, 159, 74, 57, 244, 163, 138, 56, 160, 3, 159, 74, 57, 244, 163, 138, 229, 126, 44, 252, 70, 240, 111, 195, 95, 14, 255, 0, 109, 120, 203, 90, 135, 78, 129, 178, 45, 227, 32, 188, 215, 76, 49, 242, 69, 18, 252, 206, 121, 25, 192, 192, 206, 73, 3, 154, 0, 234, 115, 138, 230, 62, 38, 124, 71, 240, 55, 195, 219, 5, 187, 241, 159, 138, 52, 253, 29, 92, 110, 142, 41, 228, 204, 210, 140, 227, 49, 194, 185, 145, 255, 0, 224, 42, 107, 226, 207, 143, 31, 182, 103, 140, 188, 75, 36, 250, 95, 195, 203, 102, 240, 190, 150, 217, 95, 182, 202, 22, 77, 70, 101, 228, 103, 60, 164, 57, 4, 112, 187, 152, 17, 195, 138, 249, 171, 86, 191, 190, 213, 53, 73, 245, 45, 78, 246, 226, 246, 246, 229, 183, 207, 117, 117, 51, 75, 44, 173, 234, 206, 196, 179, 31, 169, 160, 15, 183, 62, 36, 126, 220, 222, 26, 179, 105, 45, 188, 11, 224, 251, 253, 94, 64, 8, 23, 122, 156, 194, 206, 28, 246, 43, 26, 135, 118, 30, 199, 97, 175, 20, 241, 151, 237, 131, 241, 183, 91, 145, 197, 142, 175, 166, 120, 126, 22, 24, 242, 244, 189, 53, 9, 199, 251, 243, 249, 141, 159, 113, 138, 240, 106, 40, 3, 176, 241, 47, 197, 127, 137, 222, 32, 137, 225, 214, 190, 32, 248, 150, 242, 25, 62, 252, 47, 170, 74, 34, 63, 240, 5, 33, 127, 74, 228, 36, 62, 99, 23, 147, 230, 102, 234, 91, 146, 127, 26, 74, 40, 1, 99, 59, 24, 50, 124, 164, 116, 43, 193, 174, 179, 195, 63, 20, 190, 36, 248, 118, 21, 135, 67, 241, 247, 137, 44, 33, 143, 238, 193, 14, 169, 47, 148, 63, 224, 4, 149, 253, 43, 146, 162, 128, 61, 219, 193, 255, 0, 181, 231, 198, 237, 18, 68, 251, 102, 187, 167, 235, 176, 160, 199, 149, 170, 105, 177, 156, 255, 0, 192, 225, 242, 219, 62, 228, 154, 246, 143, 134, 255, 0, 183, 70, 135, 114, 209, 219, 248, 239, 193, 151, 154, 107, 17, 135, 188, 210, 102, 23, 81, 103, 212, 196, 251, 93, 71, 208, 185, 175, 136, 104, 160, 15, 214, 175, 133, 255, 0, 19, 188, 3, 241, 18, 208, 207, 224, 207, 20, 233, 250, 169, 81, 153, 45, 227, 147, 101, 196, 67, 213, 225, 124, 72, 163, 158, 165, 113, 93, 110, 115, 210, 191, 27, 108, 110, 174, 108, 175, 225, 190, 178, 185, 154, 214, 234, 221, 131, 195, 113, 4, 173, 28, 177, 48, 238, 174, 164, 21, 62, 224, 215, 209, 223, 2, 191, 108, 111, 29, 248, 77, 160, 211, 124, 115, 25, 241, 110, 146, 184, 83, 112, 204, 177, 234, 48, 175, 168, 147, 238, 205, 244, 124, 19, 253, 250, 0, 253, 5, 231, 210, 142, 125, 43, 143, 248, 57, 241, 67, 193, 31, 20, 60, 62, 117, 111, 7, 107, 81, 94, 172, 120, 23, 86, 204, 60, 187, 155, 70, 63, 195, 44, 71, 230, 83, 215, 7, 238, 156, 28, 18, 57, 174, 195, 138, 0, 57, 244, 163, 159, 74, 56, 163, 138, 0, 57, 244, 163, 159, 74, 56, 163, 138, 0, 79, 206, 143, 206, 150, 138, 0, 79, 206, 143, 206, 150, 190, 79, 253, 185, 191, 105, 150, 240, 195, 221, 252, 58, 248, 117, 168, 127, 196, 243, 152, 181, 125, 94, 18, 15, 246, 96, 199, 48, 66, 123, 206, 127, 137, 191, 229, 158, 112, 62, 126, 99, 0, 234, 63, 107, 111, 218, 139, 67, 248, 105, 246, 143, 11, 248, 77, 109, 245, 175, 22, 47, 201, 42, 177, 221, 105, 166, 31, 89, 136, 32, 188, 157, 49, 18, 159, 118, 43, 192, 111, 130, 60, 121, 226, 191, 17, 120, 215, 196, 215, 30, 33, 241, 86, 177, 117, 170, 234, 119, 39, 231, 184, 184, 97, 192, 206, 66, 34, 140, 42, 32, 201, 194, 168, 10, 59, 10, 200, 145, 217, 228, 103, 118, 102, 102, 37, 153, 137, 201, 36, 156, 146, 73, 234, 73, 239, 77, 160, 2, 138, 40, 160, 2, 138, 42, 77, 62, 218, 235, 80, 213, 109, 244, 189, 54, 206, 234, 255, 0, 80, 187, 109, 182, 214, 86, 112, 52, 243, 204, 125, 18, 52, 5, 155, 240, 20, 1, 29, 21, 239, 63, 14, 127, 99, 239, 141, 94, 41, 183, 75, 173, 74, 203, 73, 240, 157, 179, 128, 195, 251, 94, 228, 203, 114, 65, 255, 0, 166, 16, 238, 193, 246, 103, 83, 237, 94, 161, 165, 254, 192, 228, 194, 167, 84, 248, 177, 55, 152, 71, 204, 182, 90, 10, 34, 131, 236, 94, 86, 38, 128, 62, 54, 162, 190, 204, 212, 63, 96, 132, 16, 177, 211, 190, 43, 220, 121, 152, 224, 94, 104, 72, 235, 159, 170, 74, 166, 188, 207, 226, 39, 236, 113, 241, 147, 195, 118, 239, 115, 164, 199, 164, 120, 170, 4, 4, 149, 211, 46, 12, 23, 56, 255, 0, 174, 51, 96, 31, 162, 185, 62, 212, 1, 243, 253, 21, 107, 90, 211, 117, 29, 31, 88, 159, 73, 214, 52, 235, 205, 59, 80, 181, 56, 158, 206, 246, 221, 161, 154, 47, 247, 145, 192, 35, 216, 227, 7, 181, 85, 160, 2, 138, 40, 160, 13, 79, 7, 248, 143, 93, 240, 159, 137, 45, 252, 65, 225, 173, 94, 239, 74, 213, 45, 14, 97, 187, 181, 147, 107, 168, 238, 167, 179, 41, 238, 172, 10, 158, 224, 215, 221, 255, 0, 178, 63, 237, 83, 164, 252, 65, 184, 180, 240, 135, 142, 22, 223, 71, 241, 84, 184, 142, 218, 225, 78, 203, 77, 85, 251, 4, 207, 250, 185, 143, 252, 243, 39, 12, 126, 233, 57, 218, 63, 63, 41, 125, 141, 0, 126, 203, 126, 116, 126, 117, 242, 7, 236, 49, 251, 78, 77, 169, 220, 89, 124, 55, 248, 149, 169, 52, 151, 210, 17, 14, 139, 173, 220, 63, 55, 71, 162, 219, 220, 49, 255, 0, 150, 157, 2, 72, 126, 255, 0, 221, 111, 159, 5, 254, 192, 160, 4, 252, 232, 252, 233, 104, 160, 2, 138, 56, 174, 87, 227, 79, 142, 244, 127, 134, 191, 13, 117, 79, 25, 107, 95, 52, 26, 116, 89, 142, 221, 88, 43, 221, 76, 199, 108, 112, 175, 94, 89, 136, 25, 199, 3, 36, 240, 13, 0, 121, 15, 237, 229, 241, 231, 254, 21, 167, 133, 7, 133, 60, 47, 119, 183, 197, 186, 212, 4, 172, 168, 121, 211, 45, 142, 65, 159, 254, 186, 49, 5, 80, 123, 51, 31, 186, 3, 126, 120, 200, 236, 238, 206, 236, 204, 204, 73, 102, 99, 146, 73, 234, 73, 61, 77, 107, 252, 65, 241, 70, 181, 227, 79, 26, 106, 94, 42, 241, 13, 209, 185, 212, 245, 91, 131, 53, 195, 243, 180, 116, 10, 138, 15, 68, 85, 10, 170, 59, 42, 129, 88, 212, 0, 81, 69, 20, 0, 81, 69, 118, 31, 1, 254, 28, 107, 95, 21, 254, 41, 105, 254, 9, 209, 29, 173, 254, 208, 12, 250, 149, 240, 77, 195, 79, 179, 82, 4, 147, 17, 221, 178, 66, 160, 61, 93, 134, 120, 6, 128, 53, 127, 102, 223, 130, 254, 44, 248, 211, 226, 169, 52, 253, 11, 254, 37, 250, 53, 132, 138, 186, 182, 187, 52, 91, 162, 180, 36, 3, 229, 70, 188, 121, 179, 144, 114, 19, 56, 80, 65, 98, 1, 1, 191, 69, 126, 4, 124, 27, 240, 23, 194, 61, 11, 236, 30, 16, 209, 214, 59, 169, 148, 11, 221, 86, 231, 18, 223, 95, 17, 222, 89, 113, 146, 56, 225, 23, 8, 59, 40, 173, 255, 0, 134, 94, 13, 240, 239, 128, 60, 15, 167, 248, 79, 194, 218, 114, 88, 233, 122, 108, 91, 33, 136, 114, 204, 122, 179, 187, 117, 103, 98, 75, 51, 30, 73, 36, 214, 255, 0, 20, 0, 126, 20, 81, 197, 28, 80, 1, 71, 225, 71, 20, 113, 64, 28, 95, 198, 143, 133, 62, 7, 248, 167, 160, 255, 0, 102, 120, 195, 69, 138, 233, 163, 82, 45, 111, 162, 2, 59, 187, 50, 127, 138, 41, 113, 149, 255, 0, 116, 229, 79, 112, 69, 126, 120, 126, 211, 223, 2, 60, 83, 240, 107, 94, 95, 182, 179, 106, 126, 30, 189, 148, 166, 157, 172, 199, 30, 213, 115, 201, 17, 76, 163, 253, 92, 184, 25, 199, 221, 112, 9, 94, 140, 171, 250, 135, 197, 100, 120, 235, 195, 58, 31, 140, 60, 39, 127, 225, 175, 17, 105, 241, 95, 233, 154, 148, 38, 27, 155, 121, 7, 12, 58, 130, 15, 85, 96, 64, 42, 195, 149, 32, 17, 200, 160, 15, 199, 234, 43, 191, 253, 165, 126, 22, 234, 159, 8, 190, 41, 93, 120, 90, 250, 71, 186, 179, 117, 251, 78, 149, 124, 87, 31, 107, 182, 98, 66, 147, 142, 3, 169, 5, 92, 122, 140, 142, 24, 87, 1, 64, 5, 20, 81, 64, 3, 0, 202, 84, 244, 53, 247, 255, 0, 252, 19, 247, 227, 244, 190, 63, 209, 127, 225, 0, 241, 133, 247, 153, 226, 141, 38, 223, 125, 165, 220, 205, 243, 234, 214, 171, 198, 226, 123, 205, 31, 1, 251, 176, 33, 250, 238, 199, 192, 21, 161, 225, 61, 119, 87, 240, 199, 137, 244, 255, 0, 17, 232, 23, 141, 103, 170, 105, 87, 43, 115, 103, 112, 6, 118, 72, 190, 163, 186, 145, 149, 101, 238, 172, 71, 122, 0, 253, 136, 162, 184, 159, 217, 239, 226, 62, 149, 241, 87, 225, 78, 153, 227, 29, 49, 68, 45, 116, 134, 59, 235, 76, 228, 217, 221, 39, 18, 194, 79, 179, 114, 15, 117, 42, 123, 215, 109, 197, 0, 39, 79, 90, 248, 19, 254, 10, 101, 241, 65, 252, 75, 241, 50, 15, 135, 154, 101, 201, 109, 47, 194, 231, 125, 232, 86, 249, 102, 191, 117, 231, 60, 224, 249, 81, 176, 81, 232, 207, 32, 237, 95, 106, 124, 106, 241, 157, 175, 195, 239, 133, 58, 247, 140, 238, 213, 100, 93, 30, 201, 166, 142, 54, 206, 38, 152, 225, 98, 143, 143, 239, 72, 200, 191, 141, 126, 75, 234, 215, 215, 186, 158, 169, 117, 169, 106, 87, 47, 115, 123, 123, 59, 220, 92, 206, 231, 45, 44, 174, 197, 157, 207, 185, 98, 79, 227, 64, 21, 232, 162, 138, 0, 40, 162, 138, 0, 62, 181, 250, 21, 255, 0, 4, 208, 248, 115, 31, 133, 62, 4, 199, 227, 43, 219, 109, 186, 199, 141, 138, 223, 51, 58, 252, 209, 217, 46, 69, 172, 126, 192, 169, 105, 126, 178, 159, 65, 95, 158, 240, 216, 75, 171, 93, 91, 233, 22, 228, 137, 181, 59, 152, 172, 163, 35, 168, 105, 164, 88, 193, 252, 222, 191, 98, 244, 29, 58, 215, 71, 209, 44, 244, 155, 24, 196, 118, 182, 22, 241, 219, 64, 131, 248, 81, 20, 42, 143, 200, 10, 0, 181, 249, 209, 249, 210, 254, 52, 126, 52, 0, 159, 157, 31, 157, 47, 227, 71, 227, 64, 9, 249, 209, 249, 210, 254, 52, 126, 52, 0, 159, 157, 31, 157, 47, 227, 71, 227, 64, 30, 19, 255, 0, 5, 10, 248, 115, 23, 142, 126, 0, 222, 106, 214, 208, 110, 213, 252, 36, 27, 83, 179, 112, 62, 102, 132, 1, 246, 136, 254, 141, 24, 221, 143, 239, 70, 181, 249, 187, 95, 178, 119, 144, 67, 119, 107, 37, 173, 204, 107, 44, 51, 161, 142, 88, 216, 100, 58, 176, 193, 7, 216, 130, 107, 242, 3, 199, 26, 51, 248, 115, 198, 154, 199, 135, 100, 206, 253, 31, 81, 184, 177, 108, 255, 0, 211, 41, 90, 63, 253, 150, 128, 50, 232, 162, 138, 0, 40, 162, 138, 0, 250, 43, 254, 9, 187, 241, 61, 188, 25, 241, 147, 254, 16, 237, 70, 227, 110, 141, 227, 34, 176, 38, 227, 242, 195, 126, 163, 247, 45, 237, 230, 12, 196, 125, 79, 149, 233, 95, 161, 191, 157, 126, 53, 67, 44, 240, 204, 147, 218, 206, 246, 247, 16, 186, 201, 4, 200, 112, 209, 72, 164, 50, 184, 61, 136, 96, 8, 250, 87, 234, 255, 0, 236, 229, 227, 200, 254, 37, 252, 21, 240, 255, 0, 140, 198, 197, 184, 212, 45, 0, 189, 141, 113, 136, 174, 144, 152, 230, 79, 160, 145, 91, 30, 216, 160, 15, 2, 255, 0, 130, 173, 120, 192, 217, 120, 31, 195, 126, 6, 182, 148, 7, 213, 239, 31, 80, 187, 10, 220, 249, 80, 0, 168, 164, 122, 52, 146, 6, 250, 197, 95, 13, 215, 188, 255, 0, 193, 72, 60, 66, 250, 223, 237, 73, 169, 88, 249, 129, 162, 208, 52, 251, 93, 62, 60, 116, 201, 79, 61, 255, 0, 29, 211, 227, 254, 3, 94, 13, 64, 5, 20, 81, 64, 5, 20, 81, 64, 29, 71, 192, 244, 73, 126, 56, 120, 30, 57, 64, 40, 222, 42, 211, 55, 3, 220, 125, 174, 42, 253, 112, 238, 126, 181, 248, 231, 225, 221, 80, 232, 126, 36, 210, 245, 213, 224, 233, 58, 141, 181, 246, 71, 164, 51, 36, 135, 244, 67, 95, 177, 22, 242, 199, 61, 186, 79, 19, 7, 142, 85, 14, 140, 58, 50, 158, 65, 252, 141, 0, 73, 69, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 223, 167, 122, 252, 162, 253, 168, 85, 83, 246, 145, 241, 226, 167, 79, 248, 73, 47, 79, 226, 101, 98, 127, 82, 107, 245, 119, 211, 235, 95, 144, 191, 21, 53, 164, 241, 39, 196, 255, 0, 18, 120, 138, 35, 152, 245, 109, 106, 242, 242, 63, 247, 36, 157, 217, 127, 66, 40, 3, 6, 138, 40, 160, 2, 138, 40, 160, 2, 190, 207, 255, 0, 130, 77, 248, 196, 181, 175, 139, 62, 31, 92, 75, 159, 179, 201, 22, 179, 98, 159, 236, 201, 251, 169, 128, 246, 12, 145, 55, 214, 67, 95, 24, 87, 177, 254, 192, 126, 34, 62, 30, 253, 172, 188, 49, 186, 82, 144, 235, 73, 115, 164, 205, 207, 12, 36, 136, 186, 15, 251, 249, 12, 127, 157, 0, 113, 159, 180, 30, 176, 158, 32, 248, 237, 227, 29, 106, 25, 60, 200, 111, 53, 235, 183, 129, 253, 99, 18, 178, 167, 254, 58, 171, 92, 125, 43, 59, 73, 251, 198, 109, 204, 220, 147, 234, 77, 37, 0, 20, 81, 69, 0, 20, 81, 69, 0, 35, 42, 186, 148, 117, 220, 172, 8, 32, 247, 21, 250, 97, 251, 3, 248, 253, 60, 119, 251, 56, 232, 233, 113, 113, 230, 106, 158, 28, 81, 163, 234, 42, 72, 221, 186, 21, 2, 41, 15, 251, 241, 24, 219, 62, 187, 135, 99, 95, 154, 21, 235, 31, 177, 215, 198, 9, 190, 15, 252, 86, 77, 70, 245, 165, 127, 14, 235, 8, 182, 186, 220, 40, 11, 21, 64, 73, 75, 133, 81, 213, 162, 44, 199, 3, 146, 172, 224, 115, 138, 0, 253, 64, 162, 171, 233, 119, 182, 154, 142, 155, 111, 168, 88, 93, 67, 117, 107, 117, 10, 205, 4, 240, 184, 104, 229, 141, 128, 101, 117, 97, 193, 82, 8, 32, 143, 90, 159, 252, 245, 160, 5, 162, 147, 252, 245, 163, 252, 245, 160, 5, 162, 147, 252, 245, 163, 252, 245, 160, 5, 162, 147, 252, 245, 168, 239, 46, 32, 180, 179, 150, 234, 234, 120, 160, 130, 8, 218, 73, 101, 149, 194, 164, 104, 6, 75, 51, 30, 0, 0, 18, 73, 160, 15, 48, 253, 179, 188, 125, 31, 195, 207, 217, 239, 93, 212, 227, 159, 203, 212, 181, 24, 78, 151, 165, 140, 252, 198, 226, 101, 43, 184, 99, 186, 38, 249, 63, 224, 21, 249, 118, 160, 42, 133, 29, 20, 96, 87, 180, 126, 219, 127, 25, 63, 225, 109, 124, 79, 198, 145, 51, 255, 0, 194, 51, 161, 111, 183, 210, 65, 82, 191, 105, 98, 127, 121, 114, 65, 228, 111, 218, 2, 131, 209, 21, 120, 5, 152, 87, 139, 208, 1, 69, 20, 80, 1, 69, 20, 80, 1, 91, 159, 11, 245, 129, 225, 239, 137, 254, 25, 241, 11, 18, 23, 72, 214, 236, 239, 28, 142, 187, 35, 153, 25, 191, 241, 208, 195, 241, 172, 58, 15, 42, 71, 173, 0, 5, 74, 124, 132, 96, 175, 4, 123, 138, 43, 173, 248, 247, 163, 71, 225, 223, 141, 254, 47, 208, 224, 140, 199, 13, 134, 187, 119, 20, 10, 123, 71, 230, 177, 79, 252, 116, 173, 114, 84, 0, 81, 69, 20, 0, 81, 64, 231, 138, 247, 15, 217, 39, 246, 108, 241, 7, 198, 69, 95, 17, 106, 183, 83, 232, 62, 11, 73, 10, 45, 244, 104, 62, 213, 170, 178, 156, 50, 218, 134, 4, 42, 2, 8, 51, 48, 35, 57, 10, 24, 130, 84, 3, 195, 36, 150, 40, 228, 72, 158, 69, 18, 72, 126, 72, 243, 243, 63, 251, 171, 212, 254, 21, 102, 242, 214, 242, 202, 224, 67, 123, 101, 119, 103, 49, 69, 144, 69, 117, 110, 240, 201, 177, 134, 85, 182, 184, 7, 4, 116, 56, 193, 237, 95, 171, 127, 8, 254, 16, 252, 56, 248, 103, 98, 176, 120, 55, 194, 122, 126, 159, 54, 49, 37, 233, 143, 205, 187, 152, 247, 50, 92, 62, 100, 111, 197, 177, 232, 5, 115, 223, 181, 87, 192, 159, 14, 252, 102, 240, 202, 9, 221, 116, 223, 17, 233, 241, 176, 210, 245, 116, 143, 115, 70, 15, 62, 84, 163, 254, 90, 66, 79, 37, 115, 149, 60, 169, 7, 57, 0, 249, 15, 246, 52, 253, 165, 111, 190, 21, 180, 126, 19, 241, 95, 218, 117, 15, 7, 75, 33, 48, 249, 96, 188, 250, 59, 49, 203, 52, 67, 248, 226, 36, 229, 163, 28, 130, 75, 39, 57, 86, 253, 2, 240, 143, 136, 116, 79, 20, 248, 118, 215, 94, 240, 238, 169, 107, 169, 233, 183, 137, 190, 11, 171, 89, 67, 198, 227, 234, 58, 17, 208, 131, 200, 32, 130, 1, 175, 201, 255, 0, 139, 63, 15, 252, 91, 240, 215, 197, 175, 225, 223, 24, 233, 50, 105, 247, 124, 155, 121, 65, 221, 111, 122, 131, 254, 90, 65, 39, 73, 23, 242, 97, 209, 130, 158, 42, 127, 132, 159, 19, 60, 113, 240, 211, 88, 109, 67, 193, 126, 32, 184, 211, 154, 98, 13, 205, 191, 18, 91, 92, 241, 143, 222, 66, 217, 86, 56, 206, 27, 1, 135, 98, 40, 3, 245, 175, 62, 212, 103, 218, 190, 52, 248, 111, 251, 117, 167, 147, 29, 191, 143, 188, 13, 38, 241, 254, 178, 247, 66, 156, 16, 127, 237, 132, 196, 99, 254, 254, 26, 244, 253, 31, 246, 197, 248, 29, 123, 24, 107, 141, 99, 88, 211, 137, 234, 151, 90, 60, 204, 71, 212, 198, 28, 126, 70, 128, 61, 243, 62, 212, 103, 218, 188, 23, 87, 253, 176, 254, 6, 217, 198, 90, 223, 91, 213, 181, 2, 7, 220, 182, 209, 167, 4, 254, 50, 4, 31, 173, 121, 159, 196, 79, 219, 174, 208, 66, 240, 120, 15, 192, 211, 201, 33, 251, 151, 122, 237, 194, 162, 169, 247, 130, 18, 197, 191, 239, 226, 208, 7, 215, 30, 36, 214, 116, 175, 15, 232, 119, 90, 214, 183, 168, 91, 105, 250, 125, 148, 102, 75, 139, 187, 169, 68, 113, 68, 190, 172, 199, 129, 201, 3, 220, 144, 43, 224, 111, 219, 63, 246, 155, 185, 248, 145, 231, 248, 55, 193, 50, 79, 103, 225, 37, 124, 92, 220, 186, 152, 230, 213, 200, 60, 101, 79, 41, 14, 121, 8, 126, 102, 224, 176, 31, 118, 188, 131, 227, 7, 197, 95, 30, 124, 79, 212, 214, 239, 198, 126, 32, 158, 249, 33, 125, 214, 246, 104, 4, 86, 182, 199, 254, 153, 196, 191, 40, 56, 227, 113, 203, 122, 177, 172, 159, 134, 190, 13, 241, 79, 196, 31, 23, 199, 225, 143, 5, 232, 179, 106, 218, 155, 225, 164, 72, 206, 216, 173, 16, 255, 0, 203, 89, 229, 63, 44, 73, 238, 121, 61, 20, 49, 226, 128, 49, 237, 97, 184, 187, 188, 91, 91, 75, 107, 139, 187, 153, 3, 50, 65, 109, 3, 205, 43, 5, 25, 98, 17, 1, 98, 0, 228, 156, 112, 58, 212, 91, 151, 206, 120, 115, 137, 99, 56, 146, 54, 225, 208, 250, 50, 158, 71, 227, 95, 166, 127, 178, 55, 236, 247, 160, 252, 23, 208, 164, 188, 154, 104, 245, 127, 22, 234, 81, 5, 212, 181, 131, 30, 208, 137, 144, 126, 207, 110, 167, 152, 225, 4, 103, 251, 206, 64, 102, 232, 161, 123, 111, 138, 95, 11, 126, 31, 252, 69, 211, 218, 215, 198, 94, 21, 211, 245, 51, 140, 37, 203, 197, 178, 230, 31, 120, 231, 92, 72, 135, 232, 212, 1, 249, 47, 69, 125, 1, 251, 91, 254, 204, 58, 207, 194, 155, 121, 124, 81, 225, 171, 155, 141, 107, 194, 33, 191, 125, 36, 160, 27, 173, 47, 39, 3, 206, 218, 0, 120, 249, 3, 205, 0, 99, 163, 1, 247, 143, 207, 244, 0, 81, 69, 20, 0, 80, 78, 20, 159, 74, 43, 103, 225, 206, 142, 124, 67, 241, 35, 195, 126, 30, 4, 143, 237, 125, 110, 206, 200, 224, 103, 229, 146, 116, 86, 56, 255, 0, 116, 177, 252, 40, 3, 215, 127, 224, 163, 94, 31, 125, 19, 246, 166, 213, 175, 60, 177, 28, 58, 237, 149, 174, 163, 22, 59, 254, 239, 201, 127, 199, 124, 12, 127, 26, 240, 154, 251, 123, 254, 10, 185, 224, 243, 115, 225, 63, 12, 248, 238, 222, 16, 91, 77, 186, 147, 77, 188, 96, 57, 242, 230, 27, 227, 39, 216, 60, 108, 62, 178, 87, 196, 52, 0, 81, 69, 12, 64, 82, 204, 193, 85, 70, 73, 61, 0, 160, 15, 72, 253, 148, 190, 19, 205, 241, 143, 227, 13, 175, 134, 39, 243, 99, 208, 236, 163, 23, 222, 32, 158, 50, 84, 173, 168, 108, 44, 42, 221, 158, 86, 27, 1, 234, 20, 72, 195, 149, 175, 212, 125, 30, 194, 203, 75, 210, 173, 116, 205, 58, 214, 27, 75, 59, 56, 82, 11, 107, 120, 16, 36, 112, 198, 160, 42, 162, 168, 224, 0, 0, 0, 123, 87, 132, 255, 0, 193, 56, 254, 29, 143, 5, 254, 206, 246, 122, 229, 229, 185, 143, 88, 241, 147, 13, 94, 236, 178, 225, 146, 22, 92, 91, 68, 125, 150, 45, 173, 143, 239, 72, 245, 239, 244, 0, 81, 69, 20, 1, 135, 241, 3, 193, 254, 24, 241, 199, 134, 230, 208, 60, 91, 161, 217, 234, 250, 108, 199, 45, 111, 117, 30, 224, 24, 116, 101, 61, 81, 135, 102, 82, 8, 236, 107, 228, 175, 140, 159, 176, 220, 235, 52, 151, 255, 0, 11, 124, 78, 158, 89, 228, 105, 26, 243, 49, 219, 237, 29, 210, 2, 216, 244, 14, 140, 125, 90, 190, 209, 162, 128, 63, 41, 188, 117, 240, 63, 226, 255, 0, 132, 37, 144, 107, 159, 14, 117, 239, 42, 62, 77, 205, 133, 183, 219, 161, 199, 174, 248, 55, 224, 127, 188, 5, 112, 23, 121, 180, 145, 163, 188, 73, 109, 100, 83, 130, 151, 17, 52, 76, 63, 6, 0, 215, 236, 190, 63, 206, 105, 178, 68, 146, 46, 217, 17, 92, 122, 48, 207, 243, 160, 15, 198, 155, 103, 23, 50, 4, 181, 18, 92, 187, 28, 4, 183, 137, 165, 99, 248, 40, 38, 187, 159, 3, 252, 24, 248, 187, 227, 9, 35, 95, 15, 252, 54, 241, 20, 177, 201, 247, 110, 111, 109, 62, 195, 7, 212, 201, 113, 176, 17, 244, 205, 126, 174, 199, 20, 113, 174, 35, 69, 65, 232, 163, 31, 202, 157, 143, 243, 154, 0, 248, 147, 224, 255, 0, 236, 49, 170, 92, 205, 21, 247, 197, 63, 21, 199, 109, 110, 48, 199, 72, 240, 251, 18, 239, 254, 204, 151, 110, 163, 30, 226, 52, 207, 163, 215, 215, 95, 12, 252, 11, 225, 31, 135, 190, 25, 143, 195, 254, 12, 208, 44, 244, 125, 62, 51, 187, 202, 183, 143, 230, 145, 187, 188, 142, 114, 210, 57, 238, 204, 73, 247, 174, 138, 138, 0, 40, 162, 138, 0, 138, 242, 222, 222, 238, 206, 91, 91, 168, 35, 158, 222, 120, 218, 57, 98, 149, 3, 164, 136, 195, 5, 89, 79, 4, 16, 72, 32, 215, 230, 71, 237, 151, 240, 132, 252, 35, 248, 181, 37, 142, 157, 19, 255, 0, 194, 57, 172, 43, 93, 232, 142, 65, 34, 52, 206, 30, 220, 177, 234, 98, 98, 7, 174, 198, 66, 121, 205, 126, 158, 87, 140, 126, 222, 63, 15, 87, 199, 223, 179, 214, 170, 214, 214, 226, 77, 87, 195, 202, 117, 109, 61, 128, 27, 137, 141, 79, 155, 24, 61, 126, 120, 183, 140, 119, 96, 190, 148, 1, 249, 157, 69, 25, 4, 2, 167, 32, 140, 131, 69, 0, 21, 235, 223, 176, 95, 135, 219, 196, 95, 181, 175, 132, 227, 104, 217, 160, 210, 13, 206, 175, 57, 3, 238, 136, 97, 42, 153, 255, 0, 182, 178, 197, 94, 67, 95, 100, 127, 193, 37, 252, 30, 205, 47, 140, 62, 33, 220, 68, 66, 179, 69, 161, 216, 190, 122, 132, 196, 247, 4, 127, 192, 158, 5, 250, 161, 160, 15, 168, 254, 58, 120, 42, 223, 226, 39, 194, 61, 127, 193, 183, 5, 84, 234, 182, 77, 29, 188, 141, 210, 41, 215, 15, 11, 159, 247, 100, 84, 63, 64, 107, 242, 102, 250, 218, 234, 202, 250, 123, 43, 235, 119, 183, 186, 182, 149, 161, 184, 133, 198, 26, 41, 21, 138, 178, 31, 112, 192, 143, 194, 191, 100, 171, 243, 243, 254, 10, 85, 240, 197, 188, 39, 241, 98, 63, 28, 233, 182, 251, 116, 159, 22, 146, 211, 149, 92, 44, 55, 232, 63, 120, 15, 253, 116, 80, 36, 30, 164, 73, 64, 31, 53, 214, 183, 195, 255, 0, 13, 201, 227, 63, 136, 26, 15, 131, 162, 36, 55, 136, 53, 91, 123, 6, 32, 125, 216, 228, 144, 9, 27, 240, 143, 121, 252, 43, 38, 189, 199, 254, 9, 207, 161, 127, 108, 254, 214, 122, 45, 203, 198, 175, 22, 135, 166, 222, 234, 77, 184, 112, 28, 32, 129, 15, 231, 112, 79, 225, 64, 31, 164, 86, 118, 240, 90, 89, 197, 107, 107, 18, 197, 4, 17, 172, 113, 70, 131, 10, 136, 163, 0, 1, 232, 0, 21, 45, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 77, 144, 43, 33, 87, 80, 202, 195, 12, 164, 100, 17, 220, 83, 169, 40, 3, 242, 79, 227, 151, 133, 127, 225, 8, 248, 197, 226, 111, 10, 42, 50, 67, 164, 234, 179, 67, 108, 24, 114, 96, 45, 190, 35, 248, 198, 200, 107, 148, 175, 161, 255, 0, 224, 167, 26, 34, 233, 127, 180, 201, 212, 147, 166, 185, 162, 218, 221, 185, 255, 0, 109, 11, 192, 127, 241, 216, 146, 190, 120, 160, 4, 144, 200, 23, 16, 194, 243, 204, 196, 36, 48, 160, 203, 74, 236, 66, 170, 40, 245, 102, 32, 15, 115, 95, 171, 127, 179, 23, 195, 245, 248, 97, 240, 47, 195, 190, 13, 109, 141, 121, 101, 104, 36, 212, 100, 64, 49, 45, 220, 132, 201, 59, 100, 117, 30, 99, 176, 30, 192, 87, 196, 127, 240, 78, 143, 134, 13, 227, 191, 142, 137, 226, 141, 66, 223, 126, 135, 224, 134, 75, 183, 36, 124, 179, 234, 13, 159, 179, 199, 239, 176, 110, 148, 250, 17, 23, 173, 126, 141, 80, 1, 92, 127, 199, 143, 135, 186, 79, 197, 15, 133, 186, 167, 131, 117, 99, 229, 173, 236, 97, 173, 174, 66, 130, 214, 151, 11, 204, 115, 46, 127, 186, 216, 200, 238, 165, 135, 67, 93, 134, 61, 232, 199, 189, 0, 126, 61, 248, 211, 195, 218, 199, 132, 252, 89, 168, 248, 107, 196, 22, 109, 105, 170, 105, 87, 13, 111, 119, 9, 228, 43, 14, 234, 123, 171, 2, 25, 79, 117, 96, 123, 213, 143, 134, 254, 45, 215, 60, 11, 227, 141, 59, 197, 190, 27, 186, 22, 250, 150, 151, 47, 153, 9, 108, 236, 149, 79, 15, 20, 128, 125, 228, 117, 202, 176, 244, 57, 24, 32, 17, 247, 63, 237, 255, 0, 240, 14, 95, 136, 62, 31, 30, 57, 240, 125, 135, 153, 226, 157, 30, 13, 183, 54, 209, 47, 207, 170, 218, 174, 78, 192, 59, 204, 153, 37, 59, 176, 44, 156, 252, 184, 252, 253, 199, 113, 64, 31, 171, 223, 179, 239, 197, 47, 14, 252, 90, 248, 121, 111, 226, 125, 5, 252, 169, 56, 139, 80, 176, 145, 195, 75, 97, 112, 0, 45, 19, 250, 245, 202, 183, 70, 82, 8, 174, 230, 191, 39, 62, 2, 252, 81, 241, 63, 194, 111, 29, 199, 226, 95, 13, 202, 174, 174, 4, 87, 246, 18, 177, 16, 106, 16, 231, 62, 91, 227, 161, 25, 37, 92, 114, 164, 247, 5, 149, 191, 74, 254, 3, 252, 84, 240, 159, 197, 159, 5, 175, 136, 60, 49, 120, 119, 70, 66, 95, 88, 204, 64, 184, 176, 148, 140, 236, 149, 71, 227, 134, 25, 86, 28, 130, 104, 3, 184, 162, 140, 123, 209, 143, 122, 0, 40, 163, 30, 244, 99, 222, 128, 10, 40, 199, 189, 24, 247, 160, 2, 138, 49, 239, 70, 61, 232, 0, 162, 140, 123, 209, 143, 122, 0, 40, 163, 30, 244, 126, 52, 0, 87, 35, 241, 187, 226, 47, 135, 190, 23, 124, 61, 188, 241, 95, 136, 166, 253, 212, 3, 203, 182, 182, 70, 2, 91, 217, 200, 59, 33, 140, 30, 172, 112, 78, 127, 132, 6, 99, 192, 52, 124, 104, 248, 147, 225, 63, 133, 222, 13, 147, 196, 126, 43, 212, 124, 136, 70, 86, 218, 218, 60, 53, 197, 236, 152, 226, 56, 83, 63, 51, 126, 64, 14, 88, 128, 9, 175, 205, 95, 218, 47, 226, 231, 137, 190, 48, 120, 224, 235, 186, 225, 251, 53, 157, 176, 104, 244, 173, 46, 41, 11, 67, 97, 17, 60, 128, 120, 223, 35, 96, 23, 144, 128, 88, 128, 48, 21, 85, 64, 6, 31, 197, 207, 28, 107, 223, 17, 190, 32, 106, 30, 46, 241, 28, 226, 75, 219, 249, 50, 177, 167, 250, 187, 104, 135, 9, 12, 99, 178, 40, 224, 119, 60, 177, 201, 36, 156, 93, 11, 75, 213, 53, 221, 122, 199, 65, 208, 172, 94, 251, 85, 213, 110, 82, 214, 198, 213, 58, 205, 43, 28, 0, 79, 101, 28, 150, 61, 2, 130, 79, 74, 167, 52, 145, 195, 11, 75, 43, 132, 72, 193, 102, 99, 208, 10, 251, 203, 254, 9, 221, 240, 6, 127, 7, 105, 107, 241, 67, 198, 154, 121, 131, 196, 154, 173, 177, 77, 42, 198, 117, 249, 244, 155, 71, 228, 150, 7, 238, 207, 40, 198, 238, 232, 184, 78, 9, 113, 64, 30, 215, 251, 53, 252, 50, 211, 62, 17, 252, 33, 211, 60, 27, 97, 34, 220, 79, 8, 51, 234, 87, 161, 112, 111, 111, 36, 193, 150, 92, 118, 4, 128, 20, 118, 85, 81, 218, 187, 218, 49, 239, 70, 61, 232, 1, 63, 207, 74, 63, 207, 74, 90, 40, 1, 43, 227, 255, 0, 219, 171, 246, 101, 155, 83, 185, 189, 248, 149, 240, 223, 78, 50, 95, 72, 76, 250, 222, 139, 110, 156, 221, 30, 173, 115, 110, 163, 172, 157, 222, 49, 247, 254, 242, 252, 249, 15, 246, 13, 20, 1, 248, 206, 164, 48, 202, 156, 138, 222, 248, 111, 227, 63, 19, 248, 11, 197, 144, 248, 147, 194, 58, 188, 218, 102, 163, 8, 218, 100, 143, 148, 154, 60, 228, 199, 42, 30, 36, 67, 142, 84, 253, 70, 8, 4, 125, 195, 251, 94, 126, 202, 154, 111, 143, 174, 46, 188, 99, 224, 19, 109, 164, 120, 162, 64, 101, 187, 180, 113, 178, 211, 86, 126, 229, 177, 254, 170, 99, 255, 0, 61, 0, 195, 31, 190, 51, 243, 15, 132, 60, 85, 161, 107, 94, 24, 241, 21, 206, 129, 226, 45, 42, 235, 74, 213, 44, 206, 46, 44, 238, 227, 217, 34, 103, 161, 244, 101, 61, 153, 73, 83, 216, 154, 0, 253, 1, 253, 154, 127, 107, 15, 7, 252, 65, 75, 125, 19, 197, 198, 219, 194, 254, 37, 114, 17, 99, 150, 76, 89, 94, 182, 58, 195, 43, 125, 198, 39, 254, 89, 185, 206, 72, 10, 94, 190, 134, 31, 79, 210, 191, 26, 24, 6, 82, 172, 3, 41, 224, 130, 56, 53, 236, 63, 2, 255, 0, 105, 111, 137, 223, 12, 227, 135, 79, 183, 212, 134, 189, 162, 68, 2, 174, 151, 171, 51, 72, 177, 47, 164, 50, 253, 248, 248, 232, 50, 84, 127, 118, 128, 63, 77, 191, 207, 74, 63, 207, 74, 249, 235, 225, 95, 237, 143, 240, 167, 196, 241, 199, 7, 136, 164, 188, 240, 141, 243, 0, 10, 106, 8, 101, 182, 44, 79, 69, 184, 140, 17, 143, 119, 84, 175, 118, 240, 222, 185, 162, 248, 131, 78, 23, 250, 14, 175, 97, 170, 90, 49, 192, 184, 177, 186, 73, 227, 63, 240, 36, 36, 80, 5, 255, 0, 243, 210, 143, 243, 210, 138, 51, 64, 7, 249, 233, 71, 249, 233, 75, 73, 64, 7, 249, 233, 71, 249, 233, 84, 181, 253, 99, 73, 208, 244, 230, 212, 53, 189, 82, 207, 77, 179, 79, 191, 113, 123, 112, 144, 198, 191, 86, 114, 0, 175, 13, 248, 169, 251, 96, 252, 37, 240, 180, 114, 219, 232, 119, 119, 94, 44, 212, 19, 33, 98, 210, 211, 109, 176, 97, 253, 235, 135, 194, 145, 238, 129, 254, 148, 1, 239, 255, 0, 231, 165, 120, 47, 237, 41, 251, 83, 120, 43, 225, 172, 119, 58, 54, 130, 240, 248, 155, 197, 17, 229, 13, 157, 188, 191, 232, 214, 79, 211, 253, 34, 81, 145, 144, 127, 229, 154, 101, 184, 193, 217, 156, 215, 201, 159, 28, 255, 0, 106, 31, 137, 223, 17, 227, 155, 78, 75, 229, 240, 222, 135, 40, 42, 218, 118, 146, 236, 143, 42, 156, 140, 77, 63, 223, 126, 14, 8, 27, 20, 247, 83, 94, 42, 160, 1, 181, 64, 3, 176, 2, 128, 58, 95, 138, 222, 61, 241, 95, 196, 111, 23, 75, 226, 63, 23, 234, 178, 95, 222, 200, 54, 70, 184, 219, 13, 180, 125, 163, 138, 49, 194, 32, 244, 28, 147, 201, 36, 146, 79, 49, 52, 145, 195, 11, 75, 51, 172, 113, 160, 203, 51, 28, 0, 42, 230, 135, 166, 234, 90, 214, 185, 107, 162, 104, 186, 109, 222, 167, 170, 95, 190, 203, 75, 27, 56, 140, 147, 78, 221, 246, 168, 236, 59, 177, 194, 129, 201, 32, 115, 95, 113, 126, 200, 95, 178, 69, 167, 132, 174, 172, 252, 107, 241, 74, 59, 93, 79, 196, 80, 21, 154, 195, 72, 70, 18, 217, 233, 79, 212, 59, 158, 147, 206, 63, 189, 247, 16, 253, 208, 72, 15, 64, 28, 167, 236, 39, 251, 49, 207, 113, 119, 99, 241, 55, 226, 110, 150, 208, 199, 11, 45, 198, 131, 161, 93, 199, 134, 220, 57, 91, 171, 148, 61, 8, 224, 199, 17, 228, 112, 205, 206, 208, 62, 214, 163, 20, 180, 0, 159, 231, 165, 31, 231, 165, 45, 20, 0, 102, 140, 209, 69, 0, 25, 163, 52, 81, 64, 7, 21, 196, 252, 106, 248, 79, 224, 95, 138, 186, 10, 233, 158, 49, 209, 146, 233, 161, 207, 217, 111, 162, 111, 46, 238, 204, 158, 241, 74, 57, 95, 117, 229, 79, 112, 107, 182, 162, 128, 63, 60, 126, 59, 126, 199, 255, 0, 16, 252, 25, 36, 218, 143, 131, 73, 241, 150, 140, 185, 109, 150, 232, 35, 212, 96, 95, 246, 161, 233, 47, 214, 35, 147, 253, 193, 95, 59, 204, 143, 13, 212, 214, 179, 71, 36, 55, 22, 237, 178, 104, 37, 66, 146, 68, 222, 140, 135, 5, 79, 177, 2, 191, 101, 107, 136, 248, 181, 240, 131, 225, 199, 196, 184, 118, 248, 203, 194, 150, 58, 132, 234, 187, 99, 189, 85, 48, 221, 196, 63, 217, 158, 50, 28, 15, 108, 227, 218, 128, 63, 39, 249, 21, 99, 72, 191, 190, 210, 175, 86, 243, 74, 189, 186, 176, 185, 83, 145, 53, 164, 237, 12, 128, 255, 0, 188, 132, 31, 214, 190, 199, 248, 149, 251, 9, 194, 205, 37, 199, 195, 239, 29, 203, 111, 159, 185, 99, 175, 91, 249, 203, 244, 19, 197, 181, 128, 250, 163, 31, 122, 241, 63, 25, 254, 202, 255, 0, 29, 188, 58, 210, 55, 252, 33, 105, 173, 64, 135, 137, 180, 93, 66, 41, 195, 15, 100, 114, 146, 127, 227, 180, 1, 143, 225, 191, 218, 19, 227, 94, 135, 183, 236, 63, 18, 181, 201, 21, 122, 45, 236, 137, 120, 63, 242, 58, 185, 174, 154, 215, 246, 186, 248, 241, 18, 226, 79, 21, 216, 220, 123, 203, 163, 91, 127, 236, 170, 181, 229, 126, 35, 240, 79, 141, 124, 60, 9, 241, 7, 131, 60, 69, 164, 170, 156, 23, 190, 210, 166, 133, 63, 239, 182, 93, 191, 145, 172, 32, 65, 232, 65, 250, 80, 7, 184, 220, 254, 215, 95, 30, 37, 24, 79, 21, 88, 219, 251, 197, 163, 91, 231, 255, 0, 30, 83, 92, 231, 137, 63, 104, 143, 141, 218, 217, 63, 108, 248, 149, 173, 198, 15, 107, 22, 142, 207, 255, 0, 68, 34, 17, 249, 215, 152, 146, 7, 83, 143, 173, 108, 120, 115, 194, 62, 47, 241, 11, 237, 240, 247, 131, 252, 67, 171, 227, 169, 211, 244, 153, 231, 81, 255, 0, 2, 85, 42, 63, 19, 64, 20, 117, 173, 75, 81, 214, 47, 141, 238, 177, 168, 94, 106, 55, 44, 114, 103, 189, 184, 121, 228, 63, 240, 39, 36, 213, 82, 73, 57, 175, 92, 240, 127, 236, 191, 241, 231, 196, 101, 26, 47, 1, 54, 145, 11, 28, 121, 250, 221, 252, 54, 193, 125, 202, 41, 121, 63, 241, 202, 246, 175, 134, 255, 0, 176, 133, 195, 180, 115, 252, 67, 248, 129, 242, 131, 243, 216, 248, 118, 215, 102, 71, 161, 184, 155, 36, 254, 17, 169, 247, 160, 15, 141, 217, 209, 101, 142, 34, 73, 146, 102, 9, 20, 106, 165, 158, 86, 61, 21, 84, 114, 199, 216, 2, 107, 222, 254, 4, 254, 201, 95, 19, 188, 124, 240, 223, 248, 138, 22, 240, 78, 132, 228, 19, 62, 161, 14, 237, 66, 117, 255, 0, 166, 86, 167, 238, 103, 251, 210, 149, 199, 247, 26, 190, 223, 248, 61, 240, 79, 225, 135, 195, 5, 18, 120, 59, 194, 86, 118, 183, 197, 118, 201, 169, 79, 155, 139, 217, 56, 193, 204, 242, 22, 124, 31, 64, 64, 246, 174, 254, 128, 56, 15, 129, 31, 6, 62, 31, 252, 34, 209, 222, 211, 194, 26, 70, 203, 187, 133, 11, 123, 170, 93, 63, 157, 123, 123, 143, 249, 233, 41, 25, 199, 162, 40, 84, 29, 148, 87, 160, 113, 69, 20, 0, 102, 140, 209, 69, 0, 25, 163, 52, 81, 64, 31, 255, 217 }, "d6c0fb0d-8652-430e-bc7e-d7efaf9c67b1" },
                    { "98f95442-7de9-4447-84b9-32d544ea7537", new byte[] { 255, 216, 255, 224, 0, 16, 74, 70, 73, 70, 0, 1, 1, 1, 0, 96, 0, 96, 0, 0, 255, 219, 0, 67, 0, 4, 2, 3, 3, 3, 2, 4, 3, 3, 3, 4, 4, 4, 4, 5, 9, 6, 5, 5, 5, 5, 11, 8, 8, 6, 9, 13, 11, 13, 13, 13, 11, 12, 12, 14, 16, 20, 17, 14, 15, 19, 15, 12, 12, 18, 24, 18, 19, 21, 22, 23, 23, 23, 14, 17, 25, 27, 25, 22, 26, 20, 22, 23, 22, 255, 219, 0, 67, 1, 4, 4, 4, 5, 5, 5, 10, 6, 6, 10, 22, 15, 12, 15, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 255, 192, 0, 17, 8, 0, 192, 0, 192, 3, 1, 34, 0, 2, 17, 1, 3, 17, 1, 255, 196, 0, 31, 0, 0, 1, 5, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 255, 196, 0, 181, 16, 0, 2, 1, 3, 3, 2, 4, 3, 5, 5, 4, 4, 0, 0, 1, 125, 1, 2, 3, 0, 4, 17, 5, 18, 33, 49, 65, 6, 19, 81, 97, 7, 34, 113, 20, 50, 129, 145, 161, 8, 35, 66, 177, 193, 21, 82, 209, 240, 36, 51, 98, 114, 130, 9, 10, 22, 23, 24, 25, 26, 37, 38, 39, 40, 41, 42, 52, 53, 54, 55, 56, 57, 58, 67, 68, 69, 70, 71, 72, 73, 74, 83, 84, 85, 86, 87, 88, 89, 90, 99, 100, 101, 102, 103, 104, 105, 106, 115, 116, 117, 118, 119, 120, 121, 122, 131, 132, 133, 134, 135, 136, 137, 138, 146, 147, 148, 149, 150, 151, 152, 153, 154, 162, 163, 164, 165, 166, 167, 168, 169, 170, 178, 179, 180, 181, 182, 183, 184, 185, 186, 194, 195, 196, 197, 198, 199, 200, 201, 202, 210, 211, 212, 213, 214, 215, 216, 217, 218, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 255, 196, 0, 31, 1, 0, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 255, 196, 0, 181, 17, 0, 2, 1, 2, 4, 4, 3, 4, 7, 5, 4, 4, 0, 1, 2, 119, 0, 1, 2, 3, 17, 4, 5, 33, 49, 6, 18, 65, 81, 7, 97, 113, 19, 34, 50, 129, 8, 20, 66, 145, 161, 177, 193, 9, 35, 51, 82, 240, 21, 98, 114, 209, 10, 22, 36, 52, 225, 37, 241, 23, 24, 25, 26, 38, 39, 40, 41, 42, 53, 54, 55, 56, 57, 58, 67, 68, 69, 70, 71, 72, 73, 74, 83, 84, 85, 86, 87, 88, 89, 90, 99, 100, 101, 102, 103, 104, 105, 106, 115, 116, 117, 118, 119, 120, 121, 122, 130, 131, 132, 133, 134, 135, 136, 137, 138, 146, 147, 148, 149, 150, 151, 152, 153, 154, 162, 163, 164, 165, 166, 167, 168, 169, 170, 178, 179, 180, 181, 182, 183, 184, 185, 186, 194, 195, 196, 197, 198, 199, 200, 201, 202, 210, 211, 212, 213, 214, 215, 216, 217, 218, 226, 227, 228, 229, 230, 231, 232, 233, 234, 242, 243, 244, 245, 246, 247, 248, 249, 250, 255, 218, 0, 12, 3, 1, 0, 2, 17, 3, 17, 0, 63, 0, 251, 235, 159, 74, 57, 244, 163, 138, 56, 160, 3, 159, 74, 57, 244, 163, 138, 56, 160, 3, 159, 74, 57, 244, 163, 138, 229, 126, 44, 252, 70, 240, 111, 195, 95, 14, 255, 0, 109, 120, 203, 90, 135, 78, 129, 178, 45, 227, 32, 188, 215, 76, 49, 242, 69, 18, 252, 206, 121, 25, 192, 192, 206, 73, 3, 154, 0, 234, 115, 138, 230, 62, 38, 124, 71, 240, 55, 195, 219, 5, 187, 241, 159, 138, 52, 253, 29, 92, 110, 142, 41, 228, 204, 210, 140, 227, 49, 194, 185, 145, 255, 0, 224, 42, 107, 226, 207, 143, 31, 182, 103, 140, 188, 75, 36, 250, 95, 195, 203, 102, 240, 190, 150, 217, 95, 182, 202, 22, 77, 70, 101, 228, 103, 60, 164, 57, 4, 112, 187, 152, 17, 195, 138, 249, 171, 86, 191, 190, 213, 53, 73, 245, 45, 78, 246, 226, 246, 246, 229, 183, 207, 117, 117, 51, 75, 44, 173, 234, 206, 196, 179, 31, 169, 160, 15, 183, 62, 36, 126, 220, 222, 26, 179, 105, 45, 188, 11, 224, 251, 253, 94, 64, 8, 23, 122, 156, 194, 206, 28, 246, 43, 26, 135, 118, 30, 199, 97, 175, 20, 241, 151, 237, 131, 241, 183, 91, 145, 197, 142, 175, 166, 120, 126, 22, 24, 242, 244, 189, 53, 9, 199, 251, 243, 249, 141, 159, 113, 138, 240, 106, 40, 3, 176, 241, 47, 197, 127, 137, 222, 32, 137, 225, 214, 190, 32, 248, 150, 242, 25, 62, 252, 47, 170, 74, 34, 63, 240, 5, 33, 127, 74, 228, 36, 62, 99, 23, 147, 230, 102, 234, 91, 146, 127, 26, 74, 40, 1, 99, 59, 24, 50, 124, 164, 116, 43, 193, 174, 179, 195, 63, 20, 190, 36, 248, 118, 21, 135, 67, 241, 247, 137, 44, 33, 143, 238, 193, 14, 169, 47, 148, 63, 224, 4, 149, 253, 43, 146, 162, 128, 61, 219, 193, 255, 0, 181, 231, 198, 237, 18, 68, 251, 102, 187, 167, 235, 176, 160, 199, 149, 170, 105, 177, 156, 255, 0, 192, 225, 242, 219, 62, 228, 154, 246, 143, 134, 255, 0, 183, 70, 135, 114, 209, 219, 248, 239, 193, 151, 154, 107, 17, 135, 188, 210, 102, 23, 81, 103, 212, 196, 251, 93, 71, 208, 185, 175, 136, 104, 160, 15, 214, 175, 133, 255, 0, 19, 188, 3, 241, 18, 208, 207, 224, 207, 20, 233, 250, 169, 81, 153, 45, 227, 147, 101, 196, 67, 213, 225, 124, 72, 163, 158, 165, 113, 93, 110, 115, 210, 191, 27, 108, 110, 174, 108, 175, 225, 190, 178, 185, 154, 214, 234, 221, 131, 195, 113, 4, 173, 28, 177, 48, 238, 174, 164, 21, 62, 224, 215, 209, 223, 2, 191, 108, 111, 29, 248, 77, 160, 211, 124, 115, 25, 241, 110, 146, 184, 83, 112, 204, 177, 234, 48, 175, 168, 147, 238, 205, 244, 124, 19, 253, 250, 0, 253, 5, 231, 210, 142, 125, 43, 143, 248, 57, 241, 67, 193, 31, 20, 60, 62, 117, 111, 7, 107, 81, 94, 172, 120, 23, 86, 204, 60, 187, 155, 70, 63, 195, 44, 71, 230, 83, 215, 7, 238, 156, 28, 18, 57, 174, 195, 138, 0, 57, 244, 163, 159, 74, 56, 163, 138, 0, 57, 244, 163, 159, 74, 56, 163, 138, 0, 79, 206, 143, 206, 150, 138, 0, 79, 206, 143, 206, 150, 190, 79, 253, 185, 191, 105, 150, 240, 195, 221, 252, 58, 248, 117, 168, 127, 196, 243, 152, 181, 125, 94, 18, 15, 246, 96, 199, 48, 66, 123, 206, 127, 137, 191, 229, 158, 112, 62, 126, 99, 0, 234, 63, 107, 111, 218, 139, 67, 248, 105, 246, 143, 11, 248, 77, 109, 245, 175, 22, 47, 201, 42, 177, 221, 105, 166, 31, 89, 136, 32, 188, 157, 49, 18, 159, 118, 43, 192, 111, 130, 60, 121, 226, 191, 17, 120, 215, 196, 215, 30, 33, 241, 86, 177, 117, 170, 234, 119, 39, 231, 184, 184, 97, 192, 206, 66, 34, 140, 42, 32, 201, 194, 168, 10, 59, 10, 200, 145, 217, 228, 103, 118, 102, 102, 37, 153, 137, 201, 36, 156, 146, 73, 234, 73, 239, 77, 160, 2, 138, 40, 160, 2, 138, 42, 77, 62, 218, 235, 80, 213, 109, 244, 189, 54, 206, 234, 255, 0, 80, 187, 109, 182, 214, 86, 112, 52, 243, 204, 125, 18, 52, 5, 155, 240, 20, 1, 29, 21, 239, 63, 14, 127, 99, 239, 141, 94, 41, 183, 75, 173, 74, 203, 73, 240, 157, 179, 128, 195, 251, 94, 228, 203, 114, 65, 255, 0, 166, 16, 238, 193, 246, 103, 83, 237, 94, 161, 165, 254, 192, 228, 194, 167, 84, 248, 177, 55, 152, 71, 204, 182, 90, 10, 34, 131, 236, 94, 86, 38, 128, 62, 54, 162, 190, 204, 212, 63, 96, 132, 16, 177, 211, 190, 43, 220, 121, 152, 224, 94, 104, 72, 235, 159, 170, 74, 166, 188, 207, 226, 39, 236, 113, 241, 147, 195, 118, 239, 115, 164, 199, 164, 120, 170, 4, 4, 149, 211, 46, 12, 23, 56, 255, 0, 174, 51, 96, 31, 162, 185, 62, 212, 1, 243, 253, 21, 107, 90, 211, 117, 29, 31, 88, 159, 73, 214, 52, 235, 205, 59, 80, 181, 56, 158, 206, 246, 221, 161, 154, 47, 247, 145, 192, 35, 216, 227, 7, 181, 85, 160, 2, 138, 40, 160, 13, 79, 7, 248, 143, 93, 240, 159, 137, 45, 252, 65, 225, 173, 94, 239, 74, 213, 45, 14, 97, 187, 181, 147, 107, 168, 238, 167, 179, 41, 238, 172, 10, 158, 224, 215, 221, 255, 0, 178, 63, 237, 83, 164, 252, 65, 184, 180, 240, 135, 142, 22, 223, 71, 241, 84, 184, 142, 218, 225, 78, 203, 77, 85, 251, 4, 207, 250, 185, 143, 252, 243, 39, 12, 126, 233, 57, 218, 63, 63, 41, 125, 141, 0, 126, 203, 126, 116, 126, 117, 242, 7, 236, 49, 251, 78, 77, 169, 220, 89, 124, 55, 248, 149, 169, 52, 151, 210, 17, 14, 139, 173, 220, 63, 55, 71, 162, 219, 220, 49, 255, 0, 150, 157, 2, 72, 126, 255, 0, 221, 111, 159, 5, 254, 192, 160, 4, 252, 232, 252, 233, 104, 160, 2, 138, 56, 174, 87, 227, 79, 142, 244, 127, 134, 191, 13, 117, 79, 25, 107, 95, 52, 26, 116, 89, 142, 221, 88, 43, 221, 76, 199, 108, 112, 175, 94, 89, 136, 25, 199, 3, 36, 240, 13, 0, 121, 15, 237, 229, 241, 231, 254, 21, 167, 133, 7, 133, 60, 47, 119, 183, 197, 186, 212, 4, 172, 168, 121, 211, 45, 142, 65, 159, 254, 186, 49, 5, 80, 123, 51, 31, 186, 3, 126, 120, 200, 236, 238, 206, 236, 204, 204, 73, 102, 99, 146, 73, 234, 73, 61, 77, 107, 252, 65, 241, 70, 181, 227, 79, 26, 106, 94, 42, 241, 13, 209, 185, 212, 245, 91, 131, 53, 195, 243, 180, 116, 10, 138, 15, 68, 85, 10, 170, 59, 42, 129, 88, 212, 0, 81, 69, 20, 0, 81, 69, 118, 31, 1, 254, 28, 107, 95, 21, 254, 41, 105, 254, 9, 209, 29, 173, 254, 208, 12, 250, 149, 240, 77, 195, 79, 179, 82, 4, 147, 17, 221, 178, 66, 160, 61, 93, 134, 120, 6, 128, 53, 127, 102, 223, 130, 254, 44, 248, 211, 226, 169, 52, 253, 11, 254, 37, 250, 53, 132, 138, 186, 182, 187, 52, 91, 162, 180, 36, 3, 229, 70, 188, 121, 179, 144, 114, 19, 56, 80, 65, 98, 1, 1, 191, 69, 126, 4, 124, 27, 240, 23, 194, 61, 11, 236, 30, 16, 209, 214, 59, 169, 148, 11, 221, 86, 231, 18, 223, 95, 17, 222, 89, 113, 146, 56, 225, 23, 8, 59, 40, 173, 255, 0, 134, 94, 13, 240, 239, 128, 60, 15, 167, 248, 79, 194, 218, 114, 88, 233, 122, 108, 91, 33, 136, 114, 204, 122, 179, 187, 117, 103, 98, 75, 51, 30, 73, 36, 214, 255, 0, 20, 0, 126, 20, 81, 197, 28, 80, 1, 71, 225, 71, 20, 113, 64, 28, 95, 198, 143, 133, 62, 7, 248, 167, 160, 255, 0, 102, 120, 195, 69, 138, 233, 163, 82, 45, 111, 162, 2, 59, 187, 50, 127, 138, 41, 113, 149, 255, 0, 116, 229, 79, 112, 69, 126, 120, 126, 211, 223, 2, 60, 83, 240, 107, 94, 95, 182, 179, 106, 126, 30, 189, 148, 166, 157, 172, 199, 30, 213, 115, 201, 17, 76, 163, 253, 92, 184, 25, 199, 221, 112, 9, 94, 140, 171, 250, 135, 197, 100, 120, 235, 195, 58, 31, 140, 60, 39, 127, 225, 175, 17, 105, 241, 95, 233, 154, 148, 38, 27, 155, 121, 7, 12, 58, 130, 15, 85, 96, 64, 42, 195, 149, 32, 17, 200, 160, 15, 199, 234, 43, 191, 253, 165, 126, 22, 234, 159, 8, 190, 41, 93, 120, 90, 250, 71, 186, 179, 117, 251, 78, 149, 124, 87, 31, 107, 182, 98, 66, 147, 142, 3, 169, 5, 92, 122, 140, 142, 24, 87, 1, 64, 5, 20, 81, 64, 3, 0, 202, 84, 244, 53, 247, 255, 0, 252, 19, 247, 227, 244, 190, 63, 209, 127, 225, 0, 241, 133, 247, 153, 226, 141, 38, 223, 125, 165, 220, 205, 243, 234, 214, 171, 198, 226, 123, 205, 31, 1, 251, 176, 33, 250, 238, 199, 192, 21, 161, 225, 61, 119, 87, 240, 199, 137, 244, 255, 0, 17, 232, 23, 141, 103, 170, 105, 87, 43, 115, 103, 112, 6, 118, 72, 190, 163, 186, 145, 149, 101, 238, 172, 71, 122, 0, 253, 136, 162, 184, 159, 217, 239, 226, 62, 149, 241, 87, 225, 78, 153, 227, 29, 49, 68, 45, 116, 134, 59, 235, 76, 228, 217, 221, 39, 18, 194, 79, 179, 114, 15, 117, 42, 123, 215, 109, 197, 0, 39, 79, 90, 248, 19, 254, 10, 101, 241, 65, 252, 75, 241, 50, 15, 135, 154, 101, 201, 109, 47, 194, 231, 125, 232, 86, 249, 102, 191, 117, 231, 60, 224, 249, 81, 176, 81, 232, 207, 32, 237, 95, 106, 124, 106, 241, 157, 175, 195, 239, 133, 58, 247, 140, 238, 213, 100, 93, 30, 201, 166, 142, 54, 206, 38, 152, 225, 98, 143, 143, 239, 72, 200, 191, 141, 126, 75, 234, 215, 215, 186, 158, 169, 117, 169, 106, 87, 47, 115, 123, 123, 59, 220, 92, 206, 231, 45, 44, 174, 197, 157, 207, 185, 98, 79, 227, 64, 21, 232, 162, 138, 0, 40, 162, 138, 0, 62, 181, 250, 21, 255, 0, 4, 208, 248, 115, 31, 133, 62, 4, 199, 227, 43, 219, 109, 186, 199, 141, 138, 223, 51, 58, 252, 209, 217, 46, 69, 172, 126, 192, 169, 105, 126, 178, 159, 65, 95, 158, 240, 216, 75, 171, 93, 91, 233, 22, 228, 137, 181, 59, 152, 172, 163, 35, 168, 105, 164, 88, 193, 252, 222, 191, 98, 244, 29, 58, 215, 71, 209, 44, 244, 155, 24, 196, 118, 182, 22, 241, 219, 64, 131, 248, 81, 20, 42, 143, 200, 10, 0, 181, 249, 209, 249, 210, 254, 52, 126, 52, 0, 159, 157, 31, 157, 47, 227, 71, 227, 64, 9, 249, 209, 249, 210, 254, 52, 126, 52, 0, 159, 157, 31, 157, 47, 227, 71, 227, 64, 30, 19, 255, 0, 5, 10, 248, 115, 23, 142, 126, 0, 222, 106, 214, 208, 110, 213, 252, 36, 27, 83, 179, 112, 62, 102, 132, 1, 246, 136, 254, 141, 24, 221, 143, 239, 70, 181, 249, 187, 95, 178, 119, 144, 67, 119, 107, 37, 173, 204, 107, 44, 51, 161, 142, 88, 216, 100, 58, 176, 193, 7, 216, 130, 107, 242, 3, 199, 26, 51, 248, 115, 198, 154, 199, 135, 100, 206, 253, 31, 81, 184, 177, 108, 255, 0, 211, 41, 90, 63, 253, 150, 128, 50, 232, 162, 138, 0, 40, 162, 138, 0, 250, 43, 254, 9, 187, 241, 61, 188, 25, 241, 147, 254, 16, 237, 70, 227, 110, 141, 227, 34, 176, 38, 227, 242, 195, 126, 163, 247, 45, 237, 230, 12, 196, 125, 79, 149, 233, 95, 161, 191, 157, 126, 53, 67, 44, 240, 204, 147, 218, 206, 246, 247, 16, 186, 201, 4, 200, 112, 209, 72, 164, 50, 184, 61, 136, 96, 8, 250, 87, 234, 255, 0, 236, 229, 227, 200, 254, 37, 252, 21, 240, 255, 0, 140, 198, 197, 184, 212, 45, 0, 189, 141, 113, 136, 174, 144, 152, 230, 79, 160, 145, 91, 30, 216, 160, 15, 2, 255, 0, 130, 173, 120, 192, 217, 120, 31, 195, 126, 6, 182, 148, 7, 213, 239, 31, 80, 187, 10, 220, 249, 80, 0, 168, 164, 122, 52, 146, 6, 250, 197, 95, 13, 215, 188, 255, 0, 193, 72, 60, 66, 250, 223, 237, 73, 169, 88, 249, 129, 162, 208, 52, 251, 93, 62, 60, 116, 201, 79, 61, 255, 0, 29, 211, 227, 254, 3, 94, 13, 64, 5, 20, 81, 64, 5, 20, 81, 64, 29, 71, 192, 244, 73, 126, 56, 120, 30, 57, 64, 40, 222, 42, 211, 55, 3, 220, 125, 174, 42, 253, 112, 238, 126, 181, 248, 231, 225, 221, 80, 232, 126, 36, 210, 245, 213, 224, 233, 58, 141, 181, 246, 71, 164, 51, 36, 135, 244, 67, 95, 177, 22, 242, 199, 61, 186, 79, 19, 7, 142, 85, 14, 140, 58, 50, 158, 65, 252, 141, 0, 73, 69, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 223, 167, 122, 252, 162, 253, 168, 85, 83, 246, 145, 241, 226, 167, 79, 248, 73, 47, 79, 226, 101, 98, 127, 82, 107, 245, 119, 211, 235, 95, 144, 191, 21, 53, 164, 241, 39, 196, 255, 0, 18, 120, 138, 35, 152, 245, 109, 106, 242, 242, 63, 247, 36, 157, 217, 127, 66, 40, 3, 6, 138, 40, 160, 2, 138, 40, 160, 2, 190, 207, 255, 0, 130, 77, 248, 196, 181, 175, 139, 62, 31, 92, 75, 159, 179, 201, 22, 179, 98, 159, 236, 201, 251, 169, 128, 246, 12, 145, 55, 214, 67, 95, 24, 87, 177, 254, 192, 126, 34, 62, 30, 253, 172, 188, 49, 186, 82, 144, 235, 73, 115, 164, 205, 207, 12, 36, 136, 186, 15, 251, 249, 12, 127, 157, 0, 113, 159, 180, 30, 176, 158, 32, 248, 237, 227, 29, 106, 25, 60, 200, 111, 53, 235, 183, 129, 253, 99, 18, 178, 167, 254, 58, 171, 92, 125, 43, 59, 73, 251, 198, 109, 204, 220, 147, 234, 77, 37, 0, 20, 81, 69, 0, 20, 81, 69, 0, 35, 42, 186, 148, 117, 220, 172, 8, 32, 247, 21, 250, 97, 251, 3, 248, 253, 60, 119, 251, 56, 232, 233, 113, 113, 230, 106, 158, 28, 81, 163, 234, 42, 72, 221, 186, 21, 2, 41, 15, 251, 241, 24, 219, 62, 187, 135, 99, 95, 154, 21, 235, 31, 177, 215, 198, 9, 190, 15, 252, 86, 77, 70, 245, 165, 127, 14, 235, 8, 182, 186, 220, 40, 11, 21, 64, 73, 75, 133, 81, 213, 162, 44, 199, 3, 146, 172, 224, 115, 138, 0, 253, 64, 162, 171, 233, 119, 182, 154, 142, 155, 111, 168, 88, 93, 67, 117, 107, 117, 10, 205, 4, 240, 184, 104, 229, 141, 128, 101, 117, 97, 193, 82, 8, 32, 143, 90, 159, 252, 245, 160, 5, 162, 147, 252, 245, 163, 252, 245, 160, 5, 162, 147, 252, 245, 163, 252, 245, 160, 5, 162, 147, 252, 245, 168, 239, 46, 32, 180, 179, 150, 234, 234, 120, 160, 130, 8, 218, 73, 101, 149, 194, 164, 104, 6, 75, 51, 30, 0, 0, 18, 73, 160, 15, 48, 253, 179, 188, 125, 31, 195, 207, 217, 239, 93, 212, 227, 159, 203, 212, 181, 24, 78, 151, 165, 140, 252, 198, 226, 101, 43, 184, 99, 186, 38, 249, 63, 224, 21, 249, 118, 160, 42, 133, 29, 20, 96, 87, 180, 126, 219, 127, 25, 63, 225, 109, 124, 79, 198, 145, 51, 255, 0, 194, 51, 161, 111, 183, 210, 65, 82, 191, 105, 98, 127, 121, 114, 65, 228, 111, 218, 2, 131, 209, 21, 120, 5, 152, 87, 139, 208, 1, 69, 20, 80, 1, 69, 20, 80, 1, 91, 159, 11, 245, 129, 225, 239, 137, 254, 25, 241, 11, 18, 23, 72, 214, 236, 239, 28, 142, 187, 35, 153, 25, 191, 241, 208, 195, 241, 172, 58, 15, 42, 71, 173, 0, 5, 74, 124, 132, 96, 175, 4, 123, 138, 43, 173, 248, 247, 163, 71, 225, 223, 141, 254, 47, 208, 224, 140, 199, 13, 134, 187, 119, 20, 10, 123, 71, 230, 177, 79, 252, 116, 173, 114, 84, 0, 81, 69, 20, 0, 81, 64, 231, 138, 247, 15, 217, 39, 246, 108, 241, 7, 198, 69, 95, 17, 106, 183, 83, 232, 62, 11, 73, 10, 45, 244, 104, 62, 213, 170, 178, 156, 50, 218, 134, 4, 42, 2, 8, 51, 48, 35, 57, 10, 24, 130, 84, 3, 195, 36, 150, 40, 228, 72, 158, 69, 18, 72, 126, 72, 243, 243, 63, 251, 171, 212, 254, 21, 102, 242, 214, 242, 202, 224, 67, 123, 101, 119, 103, 49, 69, 144, 69, 117, 110, 240, 201, 177, 134, 85, 182, 184, 7, 4, 116, 56, 193, 237, 95, 171, 127, 8, 254, 16, 252, 56, 248, 103, 98, 176, 120, 55, 194, 122, 126, 159, 54, 49, 37, 233, 143, 205, 187, 152, 247, 50, 92, 62, 100, 111, 197, 177, 232, 5, 115, 223, 181, 87, 192, 159, 14, 252, 102, 240, 202, 9, 221, 116, 223, 17, 233, 241, 176, 210, 245, 116, 143, 115, 70, 15, 62, 84, 163, 254, 90, 66, 79, 37, 115, 149, 60, 169, 7, 57, 0, 249, 15, 246, 52, 253, 165, 111, 190, 21, 180, 126, 19, 241, 95, 218, 117, 15, 7, 75, 33, 48, 249, 96, 188, 250, 59, 49, 203, 52, 67, 248, 226, 36, 229, 163, 28, 130, 75, 39, 57, 86, 253, 2, 240, 143, 136, 116, 79, 20, 248, 118, 215, 94, 240, 238, 169, 107, 169, 233, 183, 137, 190, 11, 171, 89, 67, 198, 227, 234, 58, 17, 208, 131, 200, 32, 130, 1, 175, 201, 255, 0, 139, 63, 15, 252, 91, 240, 215, 197, 175, 225, 223, 24, 233, 50, 105, 247, 124, 155, 121, 65, 221, 111, 122, 131, 254, 90, 65, 39, 73, 23, 242, 97, 209, 130, 158, 42, 127, 132, 159, 19, 60, 113, 240, 211, 88, 109, 67, 193, 126, 32, 184, 211, 154, 98, 13, 205, 191, 18, 91, 92, 241, 143, 222, 66, 217, 86, 56, 206, 27, 1, 135, 98, 40, 3, 245, 175, 62, 212, 103, 218, 190, 52, 248, 111, 251, 117, 167, 147, 29, 191, 143, 188, 13, 38, 241, 254, 178, 247, 66, 156, 16, 127, 237, 132, 196, 99, 254, 254, 26, 244, 253, 31, 246, 197, 248, 29, 123, 24, 107, 141, 99, 88, 211, 137, 234, 151, 90, 60, 204, 71, 212, 198, 28, 126, 70, 128, 61, 243, 62, 212, 103, 218, 188, 23, 87, 253, 176, 254, 6, 217, 198, 90, 223, 91, 213, 181, 2, 7, 220, 182, 209, 167, 4, 254, 50, 4, 31, 173, 121, 159, 196, 79, 219, 174, 208, 66, 240, 120, 15, 192, 211, 201, 33, 251, 151, 122, 237, 194, 162, 169, 247, 130, 18, 197, 191, 239, 226, 208, 7, 215, 30, 36, 214, 116, 175, 15, 232, 119, 90, 214, 183, 168, 91, 105, 250, 125, 148, 102, 75, 139, 187, 169, 68, 113, 68, 190, 172, 199, 129, 201, 3, 220, 144, 43, 224, 111, 219, 63, 246, 155, 185, 248, 145, 231, 248, 55, 193, 50, 79, 103, 225, 37, 124, 92, 220, 186, 152, 230, 213, 200, 60, 101, 79, 41, 14, 121, 8, 126, 102, 224, 176, 31, 118, 188, 131, 227, 7, 197, 95, 30, 124, 79, 212, 214, 239, 198, 126, 32, 158, 249, 33, 125, 214, 246, 104, 4, 86, 182, 199, 254, 153, 196, 191, 40, 56, 227, 113, 203, 122, 177, 172, 159, 134, 190, 13, 241, 79, 196, 31, 23, 199, 225, 143, 5, 232, 179, 106, 218, 155, 225, 164, 72, 206, 216, 173, 16, 255, 0, 203, 89, 229, 63, 44, 73, 238, 121, 61, 20, 49, 226, 128, 49, 237, 97, 184, 187, 188, 91, 91, 75, 107, 139, 187, 153, 3, 50, 65, 109, 3, 205, 43, 5, 25, 98, 17, 1, 98, 0, 228, 156, 112, 58, 212, 91, 151, 206, 120, 115, 137, 99, 56, 146, 54, 225, 208, 250, 50, 158, 71, 227, 95, 166, 127, 178, 55, 236, 247, 160, 252, 23, 208, 164, 188, 154, 104, 245, 127, 22, 234, 81, 5, 212, 181, 131, 30, 208, 137, 144, 126, 207, 110, 167, 152, 225, 4, 103, 251, 206, 64, 102, 232, 161, 123, 111, 138, 95, 11, 126, 31, 252, 69, 211, 218, 215, 198, 94, 21, 211, 245, 51, 140, 37, 203, 197, 178, 230, 31, 120, 231, 92, 72, 135, 232, 212, 1, 249, 47, 69, 125, 1, 251, 91, 254, 204, 58, 207, 194, 155, 121, 124, 81, 225, 171, 155, 141, 107, 194, 33, 191, 125, 36, 160, 27, 173, 47, 39, 3, 206, 218, 0, 120, 249, 3, 205, 0, 99, 163, 1, 247, 143, 207, 244, 0, 81, 69, 20, 0, 80, 78, 20, 159, 74, 43, 103, 225, 206, 142, 124, 67, 241, 35, 195, 126, 30, 4, 143, 237, 125, 110, 206, 200, 224, 103, 229, 146, 116, 86, 56, 255, 0, 116, 177, 252, 40, 3, 215, 127, 224, 163, 94, 31, 125, 19, 246, 166, 213, 175, 60, 177, 28, 58, 237, 149, 174, 163, 22, 59, 254, 239, 201, 127, 199, 124, 12, 127, 26, 240, 154, 251, 123, 254, 10, 185, 224, 243, 115, 225, 63, 12, 248, 238, 222, 16, 91, 77, 186, 147, 77, 188, 96, 57, 242, 230, 27, 227, 39, 216, 60, 108, 62, 178, 87, 196, 52, 0, 81, 69, 12, 64, 82, 204, 193, 85, 70, 73, 61, 0, 160, 15, 72, 253, 148, 190, 19, 205, 241, 143, 227, 13, 175, 134, 39, 243, 99, 208, 236, 163, 23, 222, 32, 158, 50, 84, 173, 168, 108, 44, 42, 221, 158, 86, 27, 1, 234, 20, 72, 195, 149, 175, 212, 125, 30, 194, 203, 75, 210, 173, 116, 205, 58, 214, 27, 75, 59, 56, 82, 11, 107, 120, 16, 36, 112, 198, 160, 42, 162, 168, 224, 0, 0, 0, 123, 87, 132, 255, 0, 193, 56, 254, 29, 143, 5, 254, 206, 246, 122, 229, 229, 185, 143, 88, 241, 147, 13, 94, 236, 178, 225, 146, 22, 92, 91, 68, 125, 150, 45, 173, 143, 239, 72, 245, 239, 244, 0, 81, 69, 20, 1, 135, 241, 3, 193, 254, 24, 241, 199, 134, 230, 208, 60, 91, 161, 217, 234, 250, 108, 199, 45, 111, 117, 30, 224, 24, 116, 101, 61, 81, 135, 102, 82, 8, 236, 107, 228, 175, 140, 159, 176, 220, 235, 52, 151, 255, 0, 11, 124, 78, 158, 89, 228, 105, 26, 243, 49, 219, 237, 29, 210, 2, 216, 244, 14, 140, 125, 90, 190, 209, 162, 128, 63, 41, 188, 117, 240, 63, 226, 255, 0, 132, 37, 144, 107, 159, 14, 117, 239, 42, 62, 77, 205, 133, 183, 219, 161, 199, 174, 248, 55, 224, 127, 188, 5, 112, 23, 121, 180, 145, 163, 188, 73, 109, 100, 83, 130, 151, 17, 52, 76, 63, 6, 0, 215, 236, 190, 63, 206, 105, 178, 68, 146, 46, 217, 17, 92, 122, 48, 207, 243, 160, 15, 198, 155, 103, 23, 50, 4, 181, 18, 92, 187, 28, 4, 183, 137, 165, 99, 248, 40, 38, 187, 159, 3, 252, 24, 248, 187, 227, 9, 35, 95, 15, 252, 54, 241, 20, 177, 201, 247, 110, 111, 109, 62, 195, 7, 212, 201, 113, 176, 17, 244, 205, 126, 174, 199, 20, 113, 174, 35, 69, 65, 232, 163, 31, 202, 157, 143, 243, 154, 0, 248, 147, 224, 255, 0, 236, 49, 170, 92, 205, 21, 247, 197, 63, 21, 199, 109, 110, 48, 199, 72, 240, 251, 18, 239, 254, 204, 151, 110, 163, 30, 226, 52, 207, 163, 215, 215, 95, 12, 252, 11, 225, 31, 135, 190, 25, 143, 195, 254, 12, 208, 44, 244, 125, 62, 51, 187, 202, 183, 143, 230, 145, 187, 188, 142, 114, 210, 57, 238, 204, 73, 247, 174, 138, 138, 0, 40, 162, 138, 0, 138, 242, 222, 222, 238, 206, 91, 91, 168, 35, 158, 222, 120, 218, 57, 98, 149, 3, 164, 136, 195, 5, 89, 79, 4, 16, 72, 32, 215, 230, 71, 237, 151, 240, 132, 252, 35, 248, 181, 37, 142, 157, 19, 255, 0, 194, 57, 172, 43, 93, 232, 142, 65, 34, 52, 206, 30, 220, 177, 234, 98, 98, 7, 174, 198, 66, 121, 205, 126, 158, 87, 140, 126, 222, 63, 15, 87, 199, 223, 179, 214, 170, 214, 214, 226, 77, 87, 195, 202, 117, 109, 61, 128, 27, 137, 141, 79, 155, 24, 61, 126, 120, 183, 140, 119, 96, 190, 148, 1, 249, 157, 69, 25, 4, 2, 167, 32, 140, 131, 69, 0, 21, 235, 223, 176, 95, 135, 219, 196, 95, 181, 175, 132, 227, 104, 217, 160, 210, 13, 206, 175, 57, 3, 238, 136, 97, 42, 153, 255, 0, 182, 178, 197, 94, 67, 95, 100, 127, 193, 37, 252, 30, 205, 47, 140, 62, 33, 220, 68, 66, 179, 69, 161, 216, 190, 122, 132, 196, 247, 4, 127, 192, 158, 5, 250, 161, 160, 15, 168, 254, 58, 120, 42, 223, 226, 39, 194, 61, 127, 193, 183, 5, 84, 234, 182, 77, 29, 188, 141, 210, 41, 215, 15, 11, 159, 247, 100, 84, 63, 64, 107, 242, 102, 250, 218, 234, 202, 250, 123, 43, 235, 119, 183, 186, 182, 149, 161, 184, 133, 198, 26, 41, 21, 138, 178, 31, 112, 192, 143, 194, 191, 100, 171, 243, 243, 254, 10, 85, 240, 197, 188, 39, 241, 98, 63, 28, 233, 182, 251, 116, 159, 22, 146, 211, 149, 92, 44, 55, 232, 63, 120, 15, 253, 116, 80, 36, 30, 164, 73, 64, 31, 53, 214, 183, 195, 255, 0, 13, 201, 227, 63, 136, 26, 15, 131, 162, 36, 55, 136, 53, 91, 123, 6, 32, 125, 216, 228, 144, 9, 27, 240, 143, 121, 252, 43, 38, 189, 199, 254, 9, 207, 161, 127, 108, 254, 214, 122, 45, 203, 198, 175, 22, 135, 166, 222, 234, 77, 184, 112, 28, 32, 129, 15, 231, 112, 79, 225, 64, 31, 164, 86, 118, 240, 90, 89, 197, 107, 107, 18, 197, 4, 17, 172, 113, 70, 131, 10, 136, 163, 0, 1, 232, 0, 21, 45, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 77, 144, 43, 33, 87, 80, 202, 195, 12, 164, 100, 17, 220, 83, 169, 40, 3, 242, 79, 227, 151, 133, 127, 225, 8, 248, 197, 226, 111, 10, 42, 50, 67, 164, 234, 179, 67, 108, 24, 114, 96, 45, 190, 35, 248, 198, 200, 107, 148, 175, 161, 255, 0, 224, 167, 26, 34, 233, 127, 180, 201, 212, 147, 166, 185, 162, 218, 221, 185, 255, 0, 109, 11, 192, 127, 241, 216, 146, 190, 120, 160, 4, 144, 200, 23, 16, 194, 243, 204, 196, 36, 48, 160, 203, 74, 236, 66, 170, 40, 245, 102, 32, 15, 115, 95, 171, 127, 179, 23, 195, 245, 248, 97, 240, 47, 195, 190, 13, 109, 141, 121, 101, 104, 36, 212, 100, 64, 49, 45, 220, 132, 201, 59, 100, 117, 30, 99, 176, 30, 192, 87, 196, 127, 240, 78, 143, 134, 13, 227, 191, 142, 137, 226, 141, 66, 223, 126, 135, 224, 134, 75, 183, 36, 124, 179, 234, 13, 159, 179, 199, 239, 176, 110, 148, 250, 17, 23, 173, 126, 141, 80, 1, 92, 127, 199, 143, 135, 186, 79, 197, 15, 133, 186, 167, 131, 117, 99, 229, 173, 236, 97, 173, 174, 66, 130, 214, 151, 11, 204, 115, 46, 127, 186, 216, 200, 238, 165, 135, 67, 93, 134, 61, 232, 199, 189, 0, 126, 61, 248, 211, 195, 218, 199, 132, 252, 89, 168, 248, 107, 196, 22, 109, 105, 170, 105, 87, 13, 111, 119, 9, 228, 43, 14, 234, 123, 171, 2, 25, 79, 117, 96, 123, 213, 143, 134, 254, 45, 215, 60, 11, 227, 141, 59, 197, 190, 27, 186, 22, 250, 150, 151, 47, 153, 9, 108, 236, 149, 79, 15, 20, 128, 125, 228, 117, 202, 176, 244, 57, 24, 32, 17, 247, 63, 237, 255, 0, 240, 14, 95, 136, 62, 31, 30, 57, 240, 125, 135, 153, 226, 157, 30, 13, 183, 54, 209, 47, 207, 170, 218, 174, 78, 192, 59, 204, 153, 37, 59, 176, 44, 156, 252, 184, 252, 253, 199, 113, 64, 31, 171, 223, 179, 239, 197, 47, 14, 252, 90, 248, 121, 111, 226, 125, 5, 252, 169, 56, 139, 80, 176, 145, 195, 75, 97, 112, 0, 45, 19, 250, 245, 202, 183, 70, 82, 8, 174, 230, 191, 39, 62, 2, 252, 81, 241, 63, 194, 111, 29, 199, 226, 95, 13, 202, 174, 174, 4, 87, 246, 18, 177, 16, 106, 16, 231, 62, 91, 227, 161, 25, 37, 92, 114, 164, 247, 5, 149, 191, 74, 254, 3, 252, 84, 240, 159, 197, 159, 5, 175, 136, 60, 49, 120, 119, 70, 66, 95, 88, 204, 64, 184, 176, 148, 140, 236, 149, 71, 227, 134, 25, 86, 28, 130, 104, 3, 184, 162, 140, 123, 209, 143, 122, 0, 40, 163, 30, 244, 99, 222, 128, 10, 40, 199, 189, 24, 247, 160, 2, 138, 49, 239, 70, 61, 232, 0, 162, 140, 123, 209, 143, 122, 0, 40, 163, 30, 244, 126, 52, 0, 87, 35, 241, 187, 226, 47, 135, 190, 23, 124, 61, 188, 241, 95, 136, 166, 253, 212, 3, 203, 182, 182, 70, 2, 91, 217, 200, 59, 33, 140, 30, 172, 112, 78, 127, 132, 6, 99, 192, 52, 124, 104, 248, 147, 225, 63, 133, 222, 13, 147, 196, 126, 43, 212, 124, 136, 70, 86, 218, 218, 60, 53, 197, 236, 152, 226, 56, 83, 63, 51, 126, 64, 14, 88, 128, 9, 175, 205, 95, 218, 47, 226, 231, 137, 190, 48, 120, 224, 235, 186, 225, 251, 53, 157, 176, 104, 244, 173, 46, 41, 11, 67, 97, 17, 60, 128, 120, 223, 35, 96, 23, 144, 128, 88, 128, 48, 21, 85, 64, 6, 31, 197, 207, 28, 107, 223, 17, 190, 32, 106, 30, 46, 241, 28, 226, 75, 219, 249, 50, 177, 167, 250, 187, 104, 135, 9, 12, 99, 178, 40, 224, 119, 60, 177, 201, 36, 156, 93, 11, 75, 213, 53, 221, 122, 199, 65, 208, 172, 94, 251, 85, 213, 110, 82, 214, 198, 213, 58, 205, 43, 28, 0, 79, 101, 28, 150, 61, 2, 130, 79, 74, 167, 52, 145, 195, 11, 75, 43, 132, 72, 193, 102, 99, 208, 10, 251, 203, 254, 9, 221, 240, 6, 127, 7, 105, 107, 241, 67, 198, 154, 121, 131, 196, 154, 173, 177, 77, 42, 198, 117, 249, 244, 155, 71, 228, 150, 7, 238, 207, 40, 198, 238, 232, 184, 78, 9, 113, 64, 30, 215, 251, 53, 252, 50, 211, 62, 17, 252, 33, 211, 60, 27, 97, 34, 220, 79, 8, 51, 234, 87, 161, 112, 111, 111, 36, 193, 150, 92, 118, 4, 128, 20, 118, 85, 81, 218, 187, 218, 49, 239, 70, 61, 232, 1, 63, 207, 74, 63, 207, 74, 90, 40, 1, 43, 227, 255, 0, 219, 171, 246, 101, 155, 83, 185, 189, 248, 149, 240, 223, 78, 50, 95, 72, 76, 250, 222, 139, 110, 156, 221, 30, 173, 115, 110, 163, 172, 157, 222, 49, 247, 254, 242, 252, 249, 15, 246, 13, 20, 1, 248, 206, 164, 48, 202, 156, 138, 222, 248, 111, 227, 63, 19, 248, 11, 197, 144, 248, 147, 194, 58, 188, 218, 102, 163, 8, 218, 100, 143, 148, 154, 60, 228, 199, 42, 30, 36, 67, 142, 84, 253, 70, 8, 4, 125, 195, 251, 94, 126, 202, 154, 111, 143, 174, 46, 188, 99, 224, 19, 109, 164, 120, 162, 64, 101, 187, 180, 113, 178, 211, 86, 126, 229, 177, 254, 170, 99, 255, 0, 61, 0, 195, 31, 190, 51, 243, 15, 132, 60, 85, 161, 107, 94, 24, 241, 21, 206, 129, 226, 45, 42, 235, 74, 213, 44, 206, 46, 44, 238, 227, 217, 34, 103, 161, 244, 101, 61, 153, 73, 83, 216, 154, 0, 253, 1, 253, 154, 127, 107, 15, 7, 252, 65, 75, 125, 19, 197, 198, 219, 194, 254, 37, 114, 17, 99, 150, 76, 89, 94, 182, 58, 195, 43, 125, 198, 39, 254, 89, 185, 206, 72, 10, 94, 190, 134, 31, 79, 210, 191, 26, 24, 6, 82, 172, 3, 41, 224, 130, 56, 53, 236, 63, 2, 255, 0, 105, 111, 137, 223, 12, 227, 135, 79, 183, 212, 134, 189, 162, 68, 2, 174, 151, 171, 51, 72, 177, 47, 164, 50, 253, 248, 248, 232, 50, 84, 127, 118, 128, 63, 77, 191, 207, 74, 63, 207, 74, 249, 235, 225, 95, 237, 143, 240, 167, 196, 241, 199, 7, 136, 164, 188, 240, 141, 243, 0, 10, 106, 8, 101, 182, 44, 79, 69, 184, 140, 17, 143, 119, 84, 175, 118, 240, 222, 185, 162, 248, 131, 78, 23, 250, 14, 175, 97, 170, 90, 49, 192, 184, 177, 186, 73, 227, 63, 240, 36, 36, 80, 5, 255, 0, 243, 210, 143, 243, 210, 138, 51, 64, 7, 249, 233, 71, 249, 233, 75, 73, 64, 7, 249, 233, 71, 249, 233, 84, 181, 253, 99, 73, 208, 244, 230, 212, 53, 189, 82, 207, 77, 179, 79, 191, 113, 123, 112, 144, 198, 191, 86, 114, 0, 175, 13, 248, 169, 251, 96, 252, 37, 240, 180, 114, 219, 232, 119, 119, 94, 44, 212, 19, 33, 98, 210, 211, 109, 176, 97, 253, 235, 135, 194, 145, 238, 129, 254, 148, 1, 239, 255, 0, 231, 165, 120, 47, 237, 41, 251, 83, 120, 43, 225, 172, 119, 58, 54, 130, 240, 248, 155, 197, 17, 229, 13, 157, 188, 191, 232, 214, 79, 211, 253, 34, 81, 145, 144, 127, 229, 154, 101, 184, 193, 217, 156, 215, 201, 159, 28, 255, 0, 106, 31, 137, 223, 17, 227, 155, 78, 75, 229, 240, 222, 135, 40, 42, 218, 118, 146, 236, 143, 42, 156, 140, 77, 63, 223, 126, 14, 8, 27, 20, 247, 83, 94, 42, 160, 1, 181, 64, 3, 176, 2, 128, 58, 95, 138, 222, 61, 241, 95, 196, 111, 23, 75, 226, 63, 23, 234, 178, 95, 222, 200, 54, 70, 184, 219, 13, 180, 125, 163, 138, 49, 194, 32, 244, 28, 147, 201, 36, 146, 79, 49, 52, 145, 195, 11, 75, 51, 172, 113, 160, 203, 51, 28, 0, 42, 230, 135, 166, 234, 90, 214, 185, 107, 162, 104, 186, 109, 222, 167, 170, 95, 190, 203, 75, 27, 56, 140, 147, 78, 221, 246, 168, 236, 59, 177, 194, 129, 201, 32, 115, 95, 113, 126, 200, 95, 178, 69, 167, 132, 174, 172, 252, 107, 241, 74, 59, 93, 79, 196, 80, 21, 154, 195, 72, 70, 18, 217, 233, 79, 212, 59, 158, 147, 206, 63, 189, 247, 16, 253, 208, 72, 15, 64, 28, 167, 236, 39, 251, 49, 207, 113, 119, 99, 241, 55, 226, 110, 150, 208, 199, 11, 45, 198, 131, 161, 93, 199, 134, 220, 57, 91, 171, 148, 61, 8, 224, 199, 17, 228, 112, 205, 206, 208, 62, 214, 163, 20, 180, 0, 159, 231, 165, 31, 231, 165, 45, 20, 0, 102, 140, 209, 69, 0, 25, 163, 52, 81, 64, 7, 21, 196, 252, 106, 248, 79, 224, 95, 138, 186, 10, 233, 158, 49, 209, 146, 233, 161, 207, 217, 111, 162, 111, 46, 238, 204, 158, 241, 74, 57, 95, 117, 229, 79, 112, 107, 182, 162, 128, 63, 60, 126, 59, 126, 199, 255, 0, 16, 252, 25, 36, 218, 143, 131, 73, 241, 150, 140, 185, 109, 150, 232, 35, 212, 96, 95, 246, 161, 233, 47, 214, 35, 147, 253, 193, 95, 59, 204, 143, 13, 212, 214, 179, 71, 36, 55, 22, 237, 178, 104, 37, 66, 146, 68, 222, 140, 135, 5, 79, 177, 2, 191, 101, 107, 136, 248, 181, 240, 131, 225, 199, 196, 184, 118, 248, 203, 194, 150, 58, 132, 234, 187, 99, 189, 85, 48, 221, 196, 63, 217, 158, 50, 28, 15, 108, 227, 218, 128, 63, 39, 249, 21, 99, 72, 191, 190, 210, 175, 86, 243, 74, 189, 186, 176, 185, 83, 145, 53, 164, 237, 12, 128, 255, 0, 188, 132, 31, 214, 190, 199, 248, 149, 251, 9, 194, 205, 37, 199, 195, 239, 29, 203, 111, 159, 185, 99, 175, 91, 249, 203, 244, 19, 197, 181, 128, 250, 163, 31, 122, 241, 63, 25, 254, 202, 255, 0, 29, 188, 58, 210, 55, 252, 33, 105, 173, 64, 135, 137, 180, 93, 66, 41, 195, 15, 100, 114, 146, 127, 227, 180, 1, 143, 225, 191, 218, 19, 227, 94, 135, 183, 236, 63, 18, 181, 201, 21, 122, 45, 236, 137, 120, 63, 242, 58, 185, 174, 154, 215, 246, 186, 248, 241, 18, 226, 79, 21, 216, 220, 123, 203, 163, 91, 127, 236, 170, 181, 229, 126, 35, 240, 79, 141, 124, 60, 9, 241, 7, 131, 60, 69, 164, 170, 156, 23, 190, 210, 166, 133, 63, 239, 182, 93, 191, 145, 172, 32, 65, 232, 65, 250, 80, 7, 184, 220, 254, 215, 95, 30, 37, 24, 79, 21, 88, 219, 251, 197, 163, 91, 231, 255, 0, 30, 83, 92, 231, 137, 63, 104, 143, 141, 218, 217, 63, 108, 248, 149, 173, 198, 15, 107, 22, 142, 207, 255, 0, 68, 34, 17, 249, 215, 152, 146, 7, 83, 143, 173, 108, 120, 115, 194, 62, 47, 241, 11, 237, 240, 247, 131, 252, 67, 171, 227, 169, 211, 244, 153, 231, 81, 255, 0, 2, 85, 42, 63, 19, 64, 20, 117, 173, 75, 81, 214, 47, 141, 238, 177, 168, 94, 106, 55, 44, 114, 103, 189, 184, 121, 228, 63, 240, 39, 36, 213, 82, 73, 57, 175, 92, 240, 127, 236, 191, 241, 231, 196, 101, 26, 47, 1, 54, 145, 11, 28, 121, 250, 221, 252, 54, 193, 125, 202, 41, 121, 63, 241, 202, 246, 175, 134, 255, 0, 176, 133, 195, 180, 115, 252, 67, 248, 129, 242, 131, 243, 216, 248, 118, 215, 102, 71, 161, 184, 155, 36, 254, 17, 169, 247, 160, 15, 141, 217, 209, 101, 142, 34, 73, 146, 102, 9, 20, 106, 165, 158, 86, 61, 21, 84, 114, 199, 216, 2, 107, 222, 254, 4, 254, 201, 95, 19, 188, 124, 240, 223, 248, 138, 22, 240, 78, 132, 228, 19, 62, 161, 14, 237, 66, 117, 255, 0, 166, 86, 167, 238, 103, 251, 210, 149, 199, 247, 26, 190, 223, 248, 61, 240, 79, 225, 135, 195, 5, 18, 120, 59, 194, 86, 118, 183, 197, 118, 201, 169, 79, 155, 139, 217, 56, 193, 204, 242, 22, 124, 31, 64, 64, 246, 174, 254, 128, 56, 15, 129, 31, 6, 62, 31, 252, 34, 209, 222, 211, 194, 26, 70, 203, 187, 133, 11, 123, 170, 93, 63, 157, 123, 123, 143, 249, 233, 41, 25, 199, 162, 40, 84, 29, 148, 87, 160, 113, 69, 20, 0, 102, 140, 209, 69, 0, 25, 163, 52, 81, 64, 31, 255, 217 }, "f516e2a2-9c8a-4e7d-8c0e-9403187d22c3" },
                    { "25a56d7c-7d36-474e-9638-a0e121f4cdd9", new byte[] { 255, 216, 255, 224, 0, 16, 74, 70, 73, 70, 0, 1, 1, 1, 0, 96, 0, 96, 0, 0, 255, 219, 0, 67, 0, 4, 2, 3, 3, 3, 2, 4, 3, 3, 3, 4, 4, 4, 4, 5, 9, 6, 5, 5, 5, 5, 11, 8, 8, 6, 9, 13, 11, 13, 13, 13, 11, 12, 12, 14, 16, 20, 17, 14, 15, 19, 15, 12, 12, 18, 24, 18, 19, 21, 22, 23, 23, 23, 14, 17, 25, 27, 25, 22, 26, 20, 22, 23, 22, 255, 219, 0, 67, 1, 4, 4, 4, 5, 5, 5, 10, 6, 6, 10, 22, 15, 12, 15, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 255, 192, 0, 17, 8, 0, 192, 0, 192, 3, 1, 34, 0, 2, 17, 1, 3, 17, 1, 255, 196, 0, 31, 0, 0, 1, 5, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 255, 196, 0, 181, 16, 0, 2, 1, 3, 3, 2, 4, 3, 5, 5, 4, 4, 0, 0, 1, 125, 1, 2, 3, 0, 4, 17, 5, 18, 33, 49, 65, 6, 19, 81, 97, 7, 34, 113, 20, 50, 129, 145, 161, 8, 35, 66, 177, 193, 21, 82, 209, 240, 36, 51, 98, 114, 130, 9, 10, 22, 23, 24, 25, 26, 37, 38, 39, 40, 41, 42, 52, 53, 54, 55, 56, 57, 58, 67, 68, 69, 70, 71, 72, 73, 74, 83, 84, 85, 86, 87, 88, 89, 90, 99, 100, 101, 102, 103, 104, 105, 106, 115, 116, 117, 118, 119, 120, 121, 122, 131, 132, 133, 134, 135, 136, 137, 138, 146, 147, 148, 149, 150, 151, 152, 153, 154, 162, 163, 164, 165, 166, 167, 168, 169, 170, 178, 179, 180, 181, 182, 183, 184, 185, 186, 194, 195, 196, 197, 198, 199, 200, 201, 202, 210, 211, 212, 213, 214, 215, 216, 217, 218, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 255, 196, 0, 31, 1, 0, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 255, 196, 0, 181, 17, 0, 2, 1, 2, 4, 4, 3, 4, 7, 5, 4, 4, 0, 1, 2, 119, 0, 1, 2, 3, 17, 4, 5, 33, 49, 6, 18, 65, 81, 7, 97, 113, 19, 34, 50, 129, 8, 20, 66, 145, 161, 177, 193, 9, 35, 51, 82, 240, 21, 98, 114, 209, 10, 22, 36, 52, 225, 37, 241, 23, 24, 25, 26, 38, 39, 40, 41, 42, 53, 54, 55, 56, 57, 58, 67, 68, 69, 70, 71, 72, 73, 74, 83, 84, 85, 86, 87, 88, 89, 90, 99, 100, 101, 102, 103, 104, 105, 106, 115, 116, 117, 118, 119, 120, 121, 122, 130, 131, 132, 133, 134, 135, 136, 137, 138, 146, 147, 148, 149, 150, 151, 152, 153, 154, 162, 163, 164, 165, 166, 167, 168, 169, 170, 178, 179, 180, 181, 182, 183, 184, 185, 186, 194, 195, 196, 197, 198, 199, 200, 201, 202, 210, 211, 212, 213, 214, 215, 216, 217, 218, 226, 227, 228, 229, 230, 231, 232, 233, 234, 242, 243, 244, 245, 246, 247, 248, 249, 250, 255, 218, 0, 12, 3, 1, 0, 2, 17, 3, 17, 0, 63, 0, 251, 235, 159, 74, 57, 244, 163, 138, 56, 160, 3, 159, 74, 57, 244, 163, 138, 56, 160, 3, 159, 74, 57, 244, 163, 138, 229, 126, 44, 252, 70, 240, 111, 195, 95, 14, 255, 0, 109, 120, 203, 90, 135, 78, 129, 178, 45, 227, 32, 188, 215, 76, 49, 242, 69, 18, 252, 206, 121, 25, 192, 192, 206, 73, 3, 154, 0, 234, 115, 138, 230, 62, 38, 124, 71, 240, 55, 195, 219, 5, 187, 241, 159, 138, 52, 253, 29, 92, 110, 142, 41, 228, 204, 210, 140, 227, 49, 194, 185, 145, 255, 0, 224, 42, 107, 226, 207, 143, 31, 182, 103, 140, 188, 75, 36, 250, 95, 195, 203, 102, 240, 190, 150, 217, 95, 182, 202, 22, 77, 70, 101, 228, 103, 60, 164, 57, 4, 112, 187, 152, 17, 195, 138, 249, 171, 86, 191, 190, 213, 53, 73, 245, 45, 78, 246, 226, 246, 246, 229, 183, 207, 117, 117, 51, 75, 44, 173, 234, 206, 196, 179, 31, 169, 160, 15, 183, 62, 36, 126, 220, 222, 26, 179, 105, 45, 188, 11, 224, 251, 253, 94, 64, 8, 23, 122, 156, 194, 206, 28, 246, 43, 26, 135, 118, 30, 199, 97, 175, 20, 241, 151, 237, 131, 241, 183, 91, 145, 197, 142, 175, 166, 120, 126, 22, 24, 242, 244, 189, 53, 9, 199, 251, 243, 249, 141, 159, 113, 138, 240, 106, 40, 3, 176, 241, 47, 197, 127, 137, 222, 32, 137, 225, 214, 190, 32, 248, 150, 242, 25, 62, 252, 47, 170, 74, 34, 63, 240, 5, 33, 127, 74, 228, 36, 62, 99, 23, 147, 230, 102, 234, 91, 146, 127, 26, 74, 40, 1, 99, 59, 24, 50, 124, 164, 116, 43, 193, 174, 179, 195, 63, 20, 190, 36, 248, 118, 21, 135, 67, 241, 247, 137, 44, 33, 143, 238, 193, 14, 169, 47, 148, 63, 224, 4, 149, 253, 43, 146, 162, 128, 61, 219, 193, 255, 0, 181, 231, 198, 237, 18, 68, 251, 102, 187, 167, 235, 176, 160, 199, 149, 170, 105, 177, 156, 255, 0, 192, 225, 242, 219, 62, 228, 154, 246, 143, 134, 255, 0, 183, 70, 135, 114, 209, 219, 248, 239, 193, 151, 154, 107, 17, 135, 188, 210, 102, 23, 81, 103, 212, 196, 251, 93, 71, 208, 185, 175, 136, 104, 160, 15, 214, 175, 133, 255, 0, 19, 188, 3, 241, 18, 208, 207, 224, 207, 20, 233, 250, 169, 81, 153, 45, 227, 147, 101, 196, 67, 213, 225, 124, 72, 163, 158, 165, 113, 93, 110, 115, 210, 191, 27, 108, 110, 174, 108, 175, 225, 190, 178, 185, 154, 214, 234, 221, 131, 195, 113, 4, 173, 28, 177, 48, 238, 174, 164, 21, 62, 224, 215, 209, 223, 2, 191, 108, 111, 29, 248, 77, 160, 211, 124, 115, 25, 241, 110, 146, 184, 83, 112, 204, 177, 234, 48, 175, 168, 147, 238, 205, 244, 124, 19, 253, 250, 0, 253, 5, 231, 210, 142, 125, 43, 143, 248, 57, 241, 67, 193, 31, 20, 60, 62, 117, 111, 7, 107, 81, 94, 172, 120, 23, 86, 204, 60, 187, 155, 70, 63, 195, 44, 71, 230, 83, 215, 7, 238, 156, 28, 18, 57, 174, 195, 138, 0, 57, 244, 163, 159, 74, 56, 163, 138, 0, 57, 244, 163, 159, 74, 56, 163, 138, 0, 79, 206, 143, 206, 150, 138, 0, 79, 206, 143, 206, 150, 190, 79, 253, 185, 191, 105, 150, 240, 195, 221, 252, 58, 248, 117, 168, 127, 196, 243, 152, 181, 125, 94, 18, 15, 246, 96, 199, 48, 66, 123, 206, 127, 137, 191, 229, 158, 112, 62, 126, 99, 0, 234, 63, 107, 111, 218, 139, 67, 248, 105, 246, 143, 11, 248, 77, 109, 245, 175, 22, 47, 201, 42, 177, 221, 105, 166, 31, 89, 136, 32, 188, 157, 49, 18, 159, 118, 43, 192, 111, 130, 60, 121, 226, 191, 17, 120, 215, 196, 215, 30, 33, 241, 86, 177, 117, 170, 234, 119, 39, 231, 184, 184, 97, 192, 206, 66, 34, 140, 42, 32, 201, 194, 168, 10, 59, 10, 200, 145, 217, 228, 103, 118, 102, 102, 37, 153, 137, 201, 36, 156, 146, 73, 234, 73, 239, 77, 160, 2, 138, 40, 160, 2, 138, 42, 77, 62, 218, 235, 80, 213, 109, 244, 189, 54, 206, 234, 255, 0, 80, 187, 109, 182, 214, 86, 112, 52, 243, 204, 125, 18, 52, 5, 155, 240, 20, 1, 29, 21, 239, 63, 14, 127, 99, 239, 141, 94, 41, 183, 75, 173, 74, 203, 73, 240, 157, 179, 128, 195, 251, 94, 228, 203, 114, 65, 255, 0, 166, 16, 238, 193, 246, 103, 83, 237, 94, 161, 165, 254, 192, 228, 194, 167, 84, 248, 177, 55, 152, 71, 204, 182, 90, 10, 34, 131, 236, 94, 86, 38, 128, 62, 54, 162, 190, 204, 212, 63, 96, 132, 16, 177, 211, 190, 43, 220, 121, 152, 224, 94, 104, 72, 235, 159, 170, 74, 166, 188, 207, 226, 39, 236, 113, 241, 147, 195, 118, 239, 115, 164, 199, 164, 120, 170, 4, 4, 149, 211, 46, 12, 23, 56, 255, 0, 174, 51, 96, 31, 162, 185, 62, 212, 1, 243, 253, 21, 107, 90, 211, 117, 29, 31, 88, 159, 73, 214, 52, 235, 205, 59, 80, 181, 56, 158, 206, 246, 221, 161, 154, 47, 247, 145, 192, 35, 216, 227, 7, 181, 85, 160, 2, 138, 40, 160, 13, 79, 7, 248, 143, 93, 240, 159, 137, 45, 252, 65, 225, 173, 94, 239, 74, 213, 45, 14, 97, 187, 181, 147, 107, 168, 238, 167, 179, 41, 238, 172, 10, 158, 224, 215, 221, 255, 0, 178, 63, 237, 83, 164, 252, 65, 184, 180, 240, 135, 142, 22, 223, 71, 241, 84, 184, 142, 218, 225, 78, 203, 77, 85, 251, 4, 207, 250, 185, 143, 252, 243, 39, 12, 126, 233, 57, 218, 63, 63, 41, 125, 141, 0, 126, 203, 126, 116, 126, 117, 242, 7, 236, 49, 251, 78, 77, 169, 220, 89, 124, 55, 248, 149, 169, 52, 151, 210, 17, 14, 139, 173, 220, 63, 55, 71, 162, 219, 220, 49, 255, 0, 150, 157, 2, 72, 126, 255, 0, 221, 111, 159, 5, 254, 192, 160, 4, 252, 232, 252, 233, 104, 160, 2, 138, 56, 174, 87, 227, 79, 142, 244, 127, 134, 191, 13, 117, 79, 25, 107, 95, 52, 26, 116, 89, 142, 221, 88, 43, 221, 76, 199, 108, 112, 175, 94, 89, 136, 25, 199, 3, 36, 240, 13, 0, 121, 15, 237, 229, 241, 231, 254, 21, 167, 133, 7, 133, 60, 47, 119, 183, 197, 186, 212, 4, 172, 168, 121, 211, 45, 142, 65, 159, 254, 186, 49, 5, 80, 123, 51, 31, 186, 3, 126, 120, 200, 236, 238, 206, 236, 204, 204, 73, 102, 99, 146, 73, 234, 73, 61, 77, 107, 252, 65, 241, 70, 181, 227, 79, 26, 106, 94, 42, 241, 13, 209, 185, 212, 245, 91, 131, 53, 195, 243, 180, 116, 10, 138, 15, 68, 85, 10, 170, 59, 42, 129, 88, 212, 0, 81, 69, 20, 0, 81, 69, 118, 31, 1, 254, 28, 107, 95, 21, 254, 41, 105, 254, 9, 209, 29, 173, 254, 208, 12, 250, 149, 240, 77, 195, 79, 179, 82, 4, 147, 17, 221, 178, 66, 160, 61, 93, 134, 120, 6, 128, 53, 127, 102, 223, 130, 254, 44, 248, 211, 226, 169, 52, 253, 11, 254, 37, 250, 53, 132, 138, 186, 182, 187, 52, 91, 162, 180, 36, 3, 229, 70, 188, 121, 179, 144, 114, 19, 56, 80, 65, 98, 1, 1, 191, 69, 126, 4, 124, 27, 240, 23, 194, 61, 11, 236, 30, 16, 209, 214, 59, 169, 148, 11, 221, 86, 231, 18, 223, 95, 17, 222, 89, 113, 146, 56, 225, 23, 8, 59, 40, 173, 255, 0, 134, 94, 13, 240, 239, 128, 60, 15, 167, 248, 79, 194, 218, 114, 88, 233, 122, 108, 91, 33, 136, 114, 204, 122, 179, 187, 117, 103, 98, 75, 51, 30, 73, 36, 214, 255, 0, 20, 0, 126, 20, 81, 197, 28, 80, 1, 71, 225, 71, 20, 113, 64, 28, 95, 198, 143, 133, 62, 7, 248, 167, 160, 255, 0, 102, 120, 195, 69, 138, 233, 163, 82, 45, 111, 162, 2, 59, 187, 50, 127, 138, 41, 113, 149, 255, 0, 116, 229, 79, 112, 69, 126, 120, 126, 211, 223, 2, 60, 83, 240, 107, 94, 95, 182, 179, 106, 126, 30, 189, 148, 166, 157, 172, 199, 30, 213, 115, 201, 17, 76, 163, 253, 92, 184, 25, 199, 221, 112, 9, 94, 140, 171, 250, 135, 197, 100, 120, 235, 195, 58, 31, 140, 60, 39, 127, 225, 175, 17, 105, 241, 95, 233, 154, 148, 38, 27, 155, 121, 7, 12, 58, 130, 15, 85, 96, 64, 42, 195, 149, 32, 17, 200, 160, 15, 199, 234, 43, 191, 253, 165, 126, 22, 234, 159, 8, 190, 41, 93, 120, 90, 250, 71, 186, 179, 117, 251, 78, 149, 124, 87, 31, 107, 182, 98, 66, 147, 142, 3, 169, 5, 92, 122, 140, 142, 24, 87, 1, 64, 5, 20, 81, 64, 3, 0, 202, 84, 244, 53, 247, 255, 0, 252, 19, 247, 227, 244, 190, 63, 209, 127, 225, 0, 241, 133, 247, 153, 226, 141, 38, 223, 125, 165, 220, 205, 243, 234, 214, 171, 198, 226, 123, 205, 31, 1, 251, 176, 33, 250, 238, 199, 192, 21, 161, 225, 61, 119, 87, 240, 199, 137, 244, 255, 0, 17, 232, 23, 141, 103, 170, 105, 87, 43, 115, 103, 112, 6, 118, 72, 190, 163, 186, 145, 149, 101, 238, 172, 71, 122, 0, 253, 136, 162, 184, 159, 217, 239, 226, 62, 149, 241, 87, 225, 78, 153, 227, 29, 49, 68, 45, 116, 134, 59, 235, 76, 228, 217, 221, 39, 18, 194, 79, 179, 114, 15, 117, 42, 123, 215, 109, 197, 0, 39, 79, 90, 248, 19, 254, 10, 101, 241, 65, 252, 75, 241, 50, 15, 135, 154, 101, 201, 109, 47, 194, 231, 125, 232, 86, 249, 102, 191, 117, 231, 60, 224, 249, 81, 176, 81, 232, 207, 32, 237, 95, 106, 124, 106, 241, 157, 175, 195, 239, 133, 58, 247, 140, 238, 213, 100, 93, 30, 201, 166, 142, 54, 206, 38, 152, 225, 98, 143, 143, 239, 72, 200, 191, 141, 126, 75, 234, 215, 215, 186, 158, 169, 117, 169, 106, 87, 47, 115, 123, 123, 59, 220, 92, 206, 231, 45, 44, 174, 197, 157, 207, 185, 98, 79, 227, 64, 21, 232, 162, 138, 0, 40, 162, 138, 0, 62, 181, 250, 21, 255, 0, 4, 208, 248, 115, 31, 133, 62, 4, 199, 227, 43, 219, 109, 186, 199, 141, 138, 223, 51, 58, 252, 209, 217, 46, 69, 172, 126, 192, 169, 105, 126, 178, 159, 65, 95, 158, 240, 216, 75, 171, 93, 91, 233, 22, 228, 137, 181, 59, 152, 172, 163, 35, 168, 105, 164, 88, 193, 252, 222, 191, 98, 244, 29, 58, 215, 71, 209, 44, 244, 155, 24, 196, 118, 182, 22, 241, 219, 64, 131, 248, 81, 20, 42, 143, 200, 10, 0, 181, 249, 209, 249, 210, 254, 52, 126, 52, 0, 159, 157, 31, 157, 47, 227, 71, 227, 64, 9, 249, 209, 249, 210, 254, 52, 126, 52, 0, 159, 157, 31, 157, 47, 227, 71, 227, 64, 30, 19, 255, 0, 5, 10, 248, 115, 23, 142, 126, 0, 222, 106, 214, 208, 110, 213, 252, 36, 27, 83, 179, 112, 62, 102, 132, 1, 246, 136, 254, 141, 24, 221, 143, 239, 70, 181, 249, 187, 95, 178, 119, 144, 67, 119, 107, 37, 173, 204, 107, 44, 51, 161, 142, 88, 216, 100, 58, 176, 193, 7, 216, 130, 107, 242, 3, 199, 26, 51, 248, 115, 198, 154, 199, 135, 100, 206, 253, 31, 81, 184, 177, 108, 255, 0, 211, 41, 90, 63, 253, 150, 128, 50, 232, 162, 138, 0, 40, 162, 138, 0, 250, 43, 254, 9, 187, 241, 61, 188, 25, 241, 147, 254, 16, 237, 70, 227, 110, 141, 227, 34, 176, 38, 227, 242, 195, 126, 163, 247, 45, 237, 230, 12, 196, 125, 79, 149, 233, 95, 161, 191, 157, 126, 53, 67, 44, 240, 204, 147, 218, 206, 246, 247, 16, 186, 201, 4, 200, 112, 209, 72, 164, 50, 184, 61, 136, 96, 8, 250, 87, 234, 255, 0, 236, 229, 227, 200, 254, 37, 252, 21, 240, 255, 0, 140, 198, 197, 184, 212, 45, 0, 189, 141, 113, 136, 174, 144, 152, 230, 79, 160, 145, 91, 30, 216, 160, 15, 2, 255, 0, 130, 173, 120, 192, 217, 120, 31, 195, 126, 6, 182, 148, 7, 213, 239, 31, 80, 187, 10, 220, 249, 80, 0, 168, 164, 122, 52, 146, 6, 250, 197, 95, 13, 215, 188, 255, 0, 193, 72, 60, 66, 250, 223, 237, 73, 169, 88, 249, 129, 162, 208, 52, 251, 93, 62, 60, 116, 201, 79, 61, 255, 0, 29, 211, 227, 254, 3, 94, 13, 64, 5, 20, 81, 64, 5, 20, 81, 64, 29, 71, 192, 244, 73, 126, 56, 120, 30, 57, 64, 40, 222, 42, 211, 55, 3, 220, 125, 174, 42, 253, 112, 238, 126, 181, 248, 231, 225, 221, 80, 232, 126, 36, 210, 245, 213, 224, 233, 58, 141, 181, 246, 71, 164, 51, 36, 135, 244, 67, 95, 177, 22, 242, 199, 61, 186, 79, 19, 7, 142, 85, 14, 140, 58, 50, 158, 65, 252, 141, 0, 73, 69, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 223, 167, 122, 252, 162, 253, 168, 85, 83, 246, 145, 241, 226, 167, 79, 248, 73, 47, 79, 226, 101, 98, 127, 82, 107, 245, 119, 211, 235, 95, 144, 191, 21, 53, 164, 241, 39, 196, 255, 0, 18, 120, 138, 35, 152, 245, 109, 106, 242, 242, 63, 247, 36, 157, 217, 127, 66, 40, 3, 6, 138, 40, 160, 2, 138, 40, 160, 2, 190, 207, 255, 0, 130, 77, 248, 196, 181, 175, 139, 62, 31, 92, 75, 159, 179, 201, 22, 179, 98, 159, 236, 201, 251, 169, 128, 246, 12, 145, 55, 214, 67, 95, 24, 87, 177, 254, 192, 126, 34, 62, 30, 253, 172, 188, 49, 186, 82, 144, 235, 73, 115, 164, 205, 207, 12, 36, 136, 186, 15, 251, 249, 12, 127, 157, 0, 113, 159, 180, 30, 176, 158, 32, 248, 237, 227, 29, 106, 25, 60, 200, 111, 53, 235, 183, 129, 253, 99, 18, 178, 167, 254, 58, 171, 92, 125, 43, 59, 73, 251, 198, 109, 204, 220, 147, 234, 77, 37, 0, 20, 81, 69, 0, 20, 81, 69, 0, 35, 42, 186, 148, 117, 220, 172, 8, 32, 247, 21, 250, 97, 251, 3, 248, 253, 60, 119, 251, 56, 232, 233, 113, 113, 230, 106, 158, 28, 81, 163, 234, 42, 72, 221, 186, 21, 2, 41, 15, 251, 241, 24, 219, 62, 187, 135, 99, 95, 154, 21, 235, 31, 177, 215, 198, 9, 190, 15, 252, 86, 77, 70, 245, 165, 127, 14, 235, 8, 182, 186, 220, 40, 11, 21, 64, 73, 75, 133, 81, 213, 162, 44, 199, 3, 146, 172, 224, 115, 138, 0, 253, 64, 162, 171, 233, 119, 182, 154, 142, 155, 111, 168, 88, 93, 67, 117, 107, 117, 10, 205, 4, 240, 184, 104, 229, 141, 128, 101, 117, 97, 193, 82, 8, 32, 143, 90, 159, 252, 245, 160, 5, 162, 147, 252, 245, 163, 252, 245, 160, 5, 162, 147, 252, 245, 163, 252, 245, 160, 5, 162, 147, 252, 245, 168, 239, 46, 32, 180, 179, 150, 234, 234, 120, 160, 130, 8, 218, 73, 101, 149, 194, 164, 104, 6, 75, 51, 30, 0, 0, 18, 73, 160, 15, 48, 253, 179, 188, 125, 31, 195, 207, 217, 239, 93, 212, 227, 159, 203, 212, 181, 24, 78, 151, 165, 140, 252, 198, 226, 101, 43, 184, 99, 186, 38, 249, 63, 224, 21, 249, 118, 160, 42, 133, 29, 20, 96, 87, 180, 126, 219, 127, 25, 63, 225, 109, 124, 79, 198, 145, 51, 255, 0, 194, 51, 161, 111, 183, 210, 65, 82, 191, 105, 98, 127, 121, 114, 65, 228, 111, 218, 2, 131, 209, 21, 120, 5, 152, 87, 139, 208, 1, 69, 20, 80, 1, 69, 20, 80, 1, 91, 159, 11, 245, 129, 225, 239, 137, 254, 25, 241, 11, 18, 23, 72, 214, 236, 239, 28, 142, 187, 35, 153, 25, 191, 241, 208, 195, 241, 172, 58, 15, 42, 71, 173, 0, 5, 74, 124, 132, 96, 175, 4, 123, 138, 43, 173, 248, 247, 163, 71, 225, 223, 141, 254, 47, 208, 224, 140, 199, 13, 134, 187, 119, 20, 10, 123, 71, 230, 177, 79, 252, 116, 173, 114, 84, 0, 81, 69, 20, 0, 81, 64, 231, 138, 247, 15, 217, 39, 246, 108, 241, 7, 198, 69, 95, 17, 106, 183, 83, 232, 62, 11, 73, 10, 45, 244, 104, 62, 213, 170, 178, 156, 50, 218, 134, 4, 42, 2, 8, 51, 48, 35, 57, 10, 24, 130, 84, 3, 195, 36, 150, 40, 228, 72, 158, 69, 18, 72, 126, 72, 243, 243, 63, 251, 171, 212, 254, 21, 102, 242, 214, 242, 202, 224, 67, 123, 101, 119, 103, 49, 69, 144, 69, 117, 110, 240, 201, 177, 134, 85, 182, 184, 7, 4, 116, 56, 193, 237, 95, 171, 127, 8, 254, 16, 252, 56, 248, 103, 98, 176, 120, 55, 194, 122, 126, 159, 54, 49, 37, 233, 143, 205, 187, 152, 247, 50, 92, 62, 100, 111, 197, 177, 232, 5, 115, 223, 181, 87, 192, 159, 14, 252, 102, 240, 202, 9, 221, 116, 223, 17, 233, 241, 176, 210, 245, 116, 143, 115, 70, 15, 62, 84, 163, 254, 90, 66, 79, 37, 115, 149, 60, 169, 7, 57, 0, 249, 15, 246, 52, 253, 165, 111, 190, 21, 180, 126, 19, 241, 95, 218, 117, 15, 7, 75, 33, 48, 249, 96, 188, 250, 59, 49, 203, 52, 67, 248, 226, 36, 229, 163, 28, 130, 75, 39, 57, 86, 253, 2, 240, 143, 136, 116, 79, 20, 248, 118, 215, 94, 240, 238, 169, 107, 169, 233, 183, 137, 190, 11, 171, 89, 67, 198, 227, 234, 58, 17, 208, 131, 200, 32, 130, 1, 175, 201, 255, 0, 139, 63, 15, 252, 91, 240, 215, 197, 175, 225, 223, 24, 233, 50, 105, 247, 124, 155, 121, 65, 221, 111, 122, 131, 254, 90, 65, 39, 73, 23, 242, 97, 209, 130, 158, 42, 127, 132, 159, 19, 60, 113, 240, 211, 88, 109, 67, 193, 126, 32, 184, 211, 154, 98, 13, 205, 191, 18, 91, 92, 241, 143, 222, 66, 217, 86, 56, 206, 27, 1, 135, 98, 40, 3, 245, 175, 62, 212, 103, 218, 190, 52, 248, 111, 251, 117, 167, 147, 29, 191, 143, 188, 13, 38, 241, 254, 178, 247, 66, 156, 16, 127, 237, 132, 196, 99, 254, 254, 26, 244, 253, 31, 246, 197, 248, 29, 123, 24, 107, 141, 99, 88, 211, 137, 234, 151, 90, 60, 204, 71, 212, 198, 28, 126, 70, 128, 61, 243, 62, 212, 103, 218, 188, 23, 87, 253, 176, 254, 6, 217, 198, 90, 223, 91, 213, 181, 2, 7, 220, 182, 209, 167, 4, 254, 50, 4, 31, 173, 121, 159, 196, 79, 219, 174, 208, 66, 240, 120, 15, 192, 211, 201, 33, 251, 151, 122, 237, 194, 162, 169, 247, 130, 18, 197, 191, 239, 226, 208, 7, 215, 30, 36, 214, 116, 175, 15, 232, 119, 90, 214, 183, 168, 91, 105, 250, 125, 148, 102, 75, 139, 187, 169, 68, 113, 68, 190, 172, 199, 129, 201, 3, 220, 144, 43, 224, 111, 219, 63, 246, 155, 185, 248, 145, 231, 248, 55, 193, 50, 79, 103, 225, 37, 124, 92, 220, 186, 152, 230, 213, 200, 60, 101, 79, 41, 14, 121, 8, 126, 102, 224, 176, 31, 118, 188, 131, 227, 7, 197, 95, 30, 124, 79, 212, 214, 239, 198, 126, 32, 158, 249, 33, 125, 214, 246, 104, 4, 86, 182, 199, 254, 153, 196, 191, 40, 56, 227, 113, 203, 122, 177, 172, 159, 134, 190, 13, 241, 79, 196, 31, 23, 199, 225, 143, 5, 232, 179, 106, 218, 155, 225, 164, 72, 206, 216, 173, 16, 255, 0, 203, 89, 229, 63, 44, 73, 238, 121, 61, 20, 49, 226, 128, 49, 237, 97, 184, 187, 188, 91, 91, 75, 107, 139, 187, 153, 3, 50, 65, 109, 3, 205, 43, 5, 25, 98, 17, 1, 98, 0, 228, 156, 112, 58, 212, 91, 151, 206, 120, 115, 137, 99, 56, 146, 54, 225, 208, 250, 50, 158, 71, 227, 95, 166, 127, 178, 55, 236, 247, 160, 252, 23, 208, 164, 188, 154, 104, 245, 127, 22, 234, 81, 5, 212, 181, 131, 30, 208, 137, 144, 126, 207, 110, 167, 152, 225, 4, 103, 251, 206, 64, 102, 232, 161, 123, 111, 138, 95, 11, 126, 31, 252, 69, 211, 218, 215, 198, 94, 21, 211, 245, 51, 140, 37, 203, 197, 178, 230, 31, 120, 231, 92, 72, 135, 232, 212, 1, 249, 47, 69, 125, 1, 251, 91, 254, 204, 58, 207, 194, 155, 121, 124, 81, 225, 171, 155, 141, 107, 194, 33, 191, 125, 36, 160, 27, 173, 47, 39, 3, 206, 218, 0, 120, 249, 3, 205, 0, 99, 163, 1, 247, 143, 207, 244, 0, 81, 69, 20, 0, 80, 78, 20, 159, 74, 43, 103, 225, 206, 142, 124, 67, 241, 35, 195, 126, 30, 4, 143, 237, 125, 110, 206, 200, 224, 103, 229, 146, 116, 86, 56, 255, 0, 116, 177, 252, 40, 3, 215, 127, 224, 163, 94, 31, 125, 19, 246, 166, 213, 175, 60, 177, 28, 58, 237, 149, 174, 163, 22, 59, 254, 239, 201, 127, 199, 124, 12, 127, 26, 240, 154, 251, 123, 254, 10, 185, 224, 243, 115, 225, 63, 12, 248, 238, 222, 16, 91, 77, 186, 147, 77, 188, 96, 57, 242, 230, 27, 227, 39, 216, 60, 108, 62, 178, 87, 196, 52, 0, 81, 69, 12, 64, 82, 204, 193, 85, 70, 73, 61, 0, 160, 15, 72, 253, 148, 190, 19, 205, 241, 143, 227, 13, 175, 134, 39, 243, 99, 208, 236, 163, 23, 222, 32, 158, 50, 84, 173, 168, 108, 44, 42, 221, 158, 86, 27, 1, 234, 20, 72, 195, 149, 175, 212, 125, 30, 194, 203, 75, 210, 173, 116, 205, 58, 214, 27, 75, 59, 56, 82, 11, 107, 120, 16, 36, 112, 198, 160, 42, 162, 168, 224, 0, 0, 0, 123, 87, 132, 255, 0, 193, 56, 254, 29, 143, 5, 254, 206, 246, 122, 229, 229, 185, 143, 88, 241, 147, 13, 94, 236, 178, 225, 146, 22, 92, 91, 68, 125, 150, 45, 173, 143, 239, 72, 245, 239, 244, 0, 81, 69, 20, 1, 135, 241, 3, 193, 254, 24, 241, 199, 134, 230, 208, 60, 91, 161, 217, 234, 250, 108, 199, 45, 111, 117, 30, 224, 24, 116, 101, 61, 81, 135, 102, 82, 8, 236, 107, 228, 175, 140, 159, 176, 220, 235, 52, 151, 255, 0, 11, 124, 78, 158, 89, 228, 105, 26, 243, 49, 219, 237, 29, 210, 2, 216, 244, 14, 140, 125, 90, 190, 209, 162, 128, 63, 41, 188, 117, 240, 63, 226, 255, 0, 132, 37, 144, 107, 159, 14, 117, 239, 42, 62, 77, 205, 133, 183, 219, 161, 199, 174, 248, 55, 224, 127, 188, 5, 112, 23, 121, 180, 145, 163, 188, 73, 109, 100, 83, 130, 151, 17, 52, 76, 63, 6, 0, 215, 236, 190, 63, 206, 105, 178, 68, 146, 46, 217, 17, 92, 122, 48, 207, 243, 160, 15, 198, 155, 103, 23, 50, 4, 181, 18, 92, 187, 28, 4, 183, 137, 165, 99, 248, 40, 38, 187, 159, 3, 252, 24, 248, 187, 227, 9, 35, 95, 15, 252, 54, 241, 20, 177, 201, 247, 110, 111, 109, 62, 195, 7, 212, 201, 113, 176, 17, 244, 205, 126, 174, 199, 20, 113, 174, 35, 69, 65, 232, 163, 31, 202, 157, 143, 243, 154, 0, 248, 147, 224, 255, 0, 236, 49, 170, 92, 205, 21, 247, 197, 63, 21, 199, 109, 110, 48, 199, 72, 240, 251, 18, 239, 254, 204, 151, 110, 163, 30, 226, 52, 207, 163, 215, 215, 95, 12, 252, 11, 225, 31, 135, 190, 25, 143, 195, 254, 12, 208, 44, 244, 125, 62, 51, 187, 202, 183, 143, 230, 145, 187, 188, 142, 114, 210, 57, 238, 204, 73, 247, 174, 138, 138, 0, 40, 162, 138, 0, 138, 242, 222, 222, 238, 206, 91, 91, 168, 35, 158, 222, 120, 218, 57, 98, 149, 3, 164, 136, 195, 5, 89, 79, 4, 16, 72, 32, 215, 230, 71, 237, 151, 240, 132, 252, 35, 248, 181, 37, 142, 157, 19, 255, 0, 194, 57, 172, 43, 93, 232, 142, 65, 34, 52, 206, 30, 220, 177, 234, 98, 98, 7, 174, 198, 66, 121, 205, 126, 158, 87, 140, 126, 222, 63, 15, 87, 199, 223, 179, 214, 170, 214, 214, 226, 77, 87, 195, 202, 117, 109, 61, 128, 27, 137, 141, 79, 155, 24, 61, 126, 120, 183, 140, 119, 96, 190, 148, 1, 249, 157, 69, 25, 4, 2, 167, 32, 140, 131, 69, 0, 21, 235, 223, 176, 95, 135, 219, 196, 95, 181, 175, 132, 227, 104, 217, 160, 210, 13, 206, 175, 57, 3, 238, 136, 97, 42, 153, 255, 0, 182, 178, 197, 94, 67, 95, 100, 127, 193, 37, 252, 30, 205, 47, 140, 62, 33, 220, 68, 66, 179, 69, 161, 216, 190, 122, 132, 196, 247, 4, 127, 192, 158, 5, 250, 161, 160, 15, 168, 254, 58, 120, 42, 223, 226, 39, 194, 61, 127, 193, 183, 5, 84, 234, 182, 77, 29, 188, 141, 210, 41, 215, 15, 11, 159, 247, 100, 84, 63, 64, 107, 242, 102, 250, 218, 234, 202, 250, 123, 43, 235, 119, 183, 186, 182, 149, 161, 184, 133, 198, 26, 41, 21, 138, 178, 31, 112, 192, 143, 194, 191, 100, 171, 243, 243, 254, 10, 85, 240, 197, 188, 39, 241, 98, 63, 28, 233, 182, 251, 116, 159, 22, 146, 211, 149, 92, 44, 55, 232, 63, 120, 15, 253, 116, 80, 36, 30, 164, 73, 64, 31, 53, 214, 183, 195, 255, 0, 13, 201, 227, 63, 136, 26, 15, 131, 162, 36, 55, 136, 53, 91, 123, 6, 32, 125, 216, 228, 144, 9, 27, 240, 143, 121, 252, 43, 38, 189, 199, 254, 9, 207, 161, 127, 108, 254, 214, 122, 45, 203, 198, 175, 22, 135, 166, 222, 234, 77, 184, 112, 28, 32, 129, 15, 231, 112, 79, 225, 64, 31, 164, 86, 118, 240, 90, 89, 197, 107, 107, 18, 197, 4, 17, 172, 113, 70, 131, 10, 136, 163, 0, 1, 232, 0, 21, 45, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 69, 20, 80, 1, 77, 144, 43, 33, 87, 80, 202, 195, 12, 164, 100, 17, 220, 83, 169, 40, 3, 242, 79, 227, 151, 133, 127, 225, 8, 248, 197, 226, 111, 10, 42, 50, 67, 164, 234, 179, 67, 108, 24, 114, 96, 45, 190, 35, 248, 198, 200, 107, 148, 175, 161, 255, 0, 224, 167, 26, 34, 233, 127, 180, 201, 212, 147, 166, 185, 162, 218, 221, 185, 255, 0, 109, 11, 192, 127, 241, 216, 146, 190, 120, 160, 4, 144, 200, 23, 16, 194, 243, 204, 196, 36, 48, 160, 203, 74, 236, 66, 170, 40, 245, 102, 32, 15, 115, 95, 171, 127, 179, 23, 195, 245, 248, 97, 240, 47, 195, 190, 13, 109, 141, 121, 101, 104, 36, 212, 100, 64, 49, 45, 220, 132, 201, 59, 100, 117, 30, 99, 176, 30, 192, 87, 196, 127, 240, 78, 143, 134, 13, 227, 191, 142, 137, 226, 141, 66, 223, 126, 135, 224, 134, 75, 183, 36, 124, 179, 234, 13, 159, 179, 199, 239, 176, 110, 148, 250, 17, 23, 173, 126, 141, 80, 1, 92, 127, 199, 143, 135, 186, 79, 197, 15, 133, 186, 167, 131, 117, 99, 229, 173, 236, 97, 173, 174, 66, 130, 214, 151, 11, 204, 115, 46, 127, 186, 216, 200, 238, 165, 135, 67, 93, 134, 61, 232, 199, 189, 0, 126, 61, 248, 211, 195, 218, 199, 132, 252, 89, 168, 248, 107, 196, 22, 109, 105, 170, 105, 87, 13, 111, 119, 9, 228, 43, 14, 234, 123, 171, 2, 25, 79, 117, 96, 123, 213, 143, 134, 254, 45, 215, 60, 11, 227, 141, 59, 197, 190, 27, 186, 22, 250, 150, 151, 47, 153, 9, 108, 236, 149, 79, 15, 20, 128, 125, 228, 117, 202, 176, 244, 57, 24, 32, 17, 247, 63, 237, 255, 0, 240, 14, 95, 136, 62, 31, 30, 57, 240, 125, 135, 153, 226, 157, 30, 13, 183, 54, 209, 47, 207, 170, 218, 174, 78, 192, 59, 204, 153, 37, 59, 176, 44, 156, 252, 184, 252, 253, 199, 113, 64, 31, 171, 223, 179, 239, 197, 47, 14, 252, 90, 248, 121, 111, 226, 125, 5, 252, 169, 56, 139, 80, 176, 145, 195, 75, 97, 112, 0, 45, 19, 250, 245, 202, 183, 70, 82, 8, 174, 230, 191, 39, 62, 2, 252, 81, 241, 63, 194, 111, 29, 199, 226, 95, 13, 202, 174, 174, 4, 87, 246, 18, 177, 16, 106, 16, 231, 62, 91, 227, 161, 25, 37, 92, 114, 164, 247, 5, 149, 191, 74, 254, 3, 252, 84, 240, 159, 197, 159, 5, 175, 136, 60, 49, 120, 119, 70, 66, 95, 88, 204, 64, 184, 176, 148, 140, 236, 149, 71, 227, 134, 25, 86, 28, 130, 104, 3, 184, 162, 140, 123, 209, 143, 122, 0, 40, 163, 30, 244, 99, 222, 128, 10, 40, 199, 189, 24, 247, 160, 2, 138, 49, 239, 70, 61, 232, 0, 162, 140, 123, 209, 143, 122, 0, 40, 163, 30, 244, 126, 52, 0, 87, 35, 241, 187, 226, 47, 135, 190, 23, 124, 61, 188, 241, 95, 136, 166, 253, 212, 3, 203, 182, 182, 70, 2, 91, 217, 200, 59, 33, 140, 30, 172, 112, 78, 127, 132, 6, 99, 192, 52, 124, 104, 248, 147, 225, 63, 133, 222, 13, 147, 196, 126, 43, 212, 124, 136, 70, 86, 218, 218, 60, 53, 197, 236, 152, 226, 56, 83, 63, 51, 126, 64, 14, 88, 128, 9, 175, 205, 95, 218, 47, 226, 231, 137, 190, 48, 120, 224, 235, 186, 225, 251, 53, 157, 176, 104, 244, 173, 46, 41, 11, 67, 97, 17, 60, 128, 120, 223, 35, 96, 23, 144, 128, 88, 128, 48, 21, 85, 64, 6, 31, 197, 207, 28, 107, 223, 17, 190, 32, 106, 30, 46, 241, 28, 226, 75, 219, 249, 50, 177, 167, 250, 187, 104, 135, 9, 12, 99, 178, 40, 224, 119, 60, 177, 201, 36, 156, 93, 11, 75, 213, 53, 221, 122, 199, 65, 208, 172, 94, 251, 85, 213, 110, 82, 214, 198, 213, 58, 205, 43, 28, 0, 79, 101, 28, 150, 61, 2, 130, 79, 74, 167, 52, 145, 195, 11, 75, 43, 132, 72, 193, 102, 99, 208, 10, 251, 203, 254, 9, 221, 240, 6, 127, 7, 105, 107, 241, 67, 198, 154, 121, 131, 196, 154, 173, 177, 77, 42, 198, 117, 249, 244, 155, 71, 228, 150, 7, 238, 207, 40, 198, 238, 232, 184, 78, 9, 113, 64, 30, 215, 251, 53, 252, 50, 211, 62, 17, 252, 33, 211, 60, 27, 97, 34, 220, 79, 8, 51, 234, 87, 161, 112, 111, 111, 36, 193, 150, 92, 118, 4, 128, 20, 118, 85, 81, 218, 187, 218, 49, 239, 70, 61, 232, 1, 63, 207, 74, 63, 207, 74, 90, 40, 1, 43, 227, 255, 0, 219, 171, 246, 101, 155, 83, 185, 189, 248, 149, 240, 223, 78, 50, 95, 72, 76, 250, 222, 139, 110, 156, 221, 30, 173, 115, 110, 163, 172, 157, 222, 49, 247, 254, 242, 252, 249, 15, 246, 13, 20, 1, 248, 206, 164, 48, 202, 156, 138, 222, 248, 111, 227, 63, 19, 248, 11, 197, 144, 248, 147, 194, 58, 188, 218, 102, 163, 8, 218, 100, 143, 148, 154, 60, 228, 199, 42, 30, 36, 67, 142, 84, 253, 70, 8, 4, 125, 195, 251, 94, 126, 202, 154, 111, 143, 174, 46, 188, 99, 224, 19, 109, 164, 120, 162, 64, 101, 187, 180, 113, 178, 211, 86, 126, 229, 177, 254, 170, 99, 255, 0, 61, 0, 195, 31, 190, 51, 243, 15, 132, 60, 85, 161, 107, 94, 24, 241, 21, 206, 129, 226, 45, 42, 235, 74, 213, 44, 206, 46, 44, 238, 227, 217, 34, 103, 161, 244, 101, 61, 153, 73, 83, 216, 154, 0, 253, 1, 253, 154, 127, 107, 15, 7, 252, 65, 75, 125, 19, 197, 198, 219, 194, 254, 37, 114, 17, 99, 150, 76, 89, 94, 182, 58, 195, 43, 125, 198, 39, 254, 89, 185, 206, 72, 10, 94, 190, 134, 31, 79, 210, 191, 26, 24, 6, 82, 172, 3, 41, 224, 130, 56, 53, 236, 63, 2, 255, 0, 105, 111, 137, 223, 12, 227, 135, 79, 183, 212, 134, 189, 162, 68, 2, 174, 151, 171, 51, 72, 177, 47, 164, 50, 253, 248, 248, 232, 50, 84, 127, 118, 128, 63, 77, 191, 207, 74, 63, 207, 74, 249, 235, 225, 95, 237, 143, 240, 167, 196, 241, 199, 7, 136, 164, 188, 240, 141, 243, 0, 10, 106, 8, 101, 182, 44, 79, 69, 184, 140, 17, 143, 119, 84, 175, 118, 240, 222, 185, 162, 248, 131, 78, 23, 250, 14, 175, 97, 170, 90, 49, 192, 184, 177, 186, 73, 227, 63, 240, 36, 36, 80, 5, 255, 0, 243, 210, 143, 243, 210, 138, 51, 64, 7, 249, 233, 71, 249, 233, 75, 73, 64, 7, 249, 233, 71, 249, 233, 84, 181, 253, 99, 73, 208, 244, 230, 212, 53, 189, 82, 207, 77, 179, 79, 191, 113, 123, 112, 144, 198, 191, 86, 114, 0, 175, 13, 248, 169, 251, 96, 252, 37, 240, 180, 114, 219, 232, 119, 119, 94, 44, 212, 19, 33, 98, 210, 211, 109, 176, 97, 253, 235, 135, 194, 145, 238, 129, 254, 148, 1, 239, 255, 0, 231, 165, 120, 47, 237, 41, 251, 83, 120, 43, 225, 172, 119, 58, 54, 130, 240, 248, 155, 197, 17, 229, 13, 157, 188, 191, 232, 214, 79, 211, 253, 34, 81, 145, 144, 127, 229, 154, 101, 184, 193, 217, 156, 215, 201, 159, 28, 255, 0, 106, 31, 137, 223, 17, 227, 155, 78, 75, 229, 240, 222, 135, 40, 42, 218, 118, 146, 236, 143, 42, 156, 140, 77, 63, 223, 126, 14, 8, 27, 20, 247, 83, 94, 42, 160, 1, 181, 64, 3, 176, 2, 128, 58, 95, 138, 222, 61, 241, 95, 196, 111, 23, 75, 226, 63, 23, 234, 178, 95, 222, 200, 54, 70, 184, 219, 13, 180, 125, 163, 138, 49, 194, 32, 244, 28, 147, 201, 36, 146, 79, 49, 52, 145, 195, 11, 75, 51, 172, 113, 160, 203, 51, 28, 0, 42, 230, 135, 166, 234, 90, 214, 185, 107, 162, 104, 186, 109, 222, 167, 170, 95, 190, 203, 75, 27, 56, 140, 147, 78, 221, 246, 168, 236, 59, 177, 194, 129, 201, 32, 115, 95, 113, 126, 200, 95, 178, 69, 167, 132, 174, 172, 252, 107, 241, 74, 59, 93, 79, 196, 80, 21, 154, 195, 72, 70, 18, 217, 233, 79, 212, 59, 158, 147, 206, 63, 189, 247, 16, 253, 208, 72, 15, 64, 28, 167, 236, 39, 251, 49, 207, 113, 119, 99, 241, 55, 226, 110, 150, 208, 199, 11, 45, 198, 131, 161, 93, 199, 134, 220, 57, 91, 171, 148, 61, 8, 224, 199, 17, 228, 112, 205, 206, 208, 62, 214, 163, 20, 180, 0, 159, 231, 165, 31, 231, 165, 45, 20, 0, 102, 140, 209, 69, 0, 25, 163, 52, 81, 64, 7, 21, 196, 252, 106, 248, 79, 224, 95, 138, 186, 10, 233, 158, 49, 209, 146, 233, 161, 207, 217, 111, 162, 111, 46, 238, 204, 158, 241, 74, 57, 95, 117, 229, 79, 112, 107, 182, 162, 128, 63, 60, 126, 59, 126, 199, 255, 0, 16, 252, 25, 36, 218, 143, 131, 73, 241, 150, 140, 185, 109, 150, 232, 35, 212, 96, 95, 246, 161, 233, 47, 214, 35, 147, 253, 193, 95, 59, 204, 143, 13, 212, 214, 179, 71, 36, 55, 22, 237, 178, 104, 37, 66, 146, 68, 222, 140, 135, 5, 79, 177, 2, 191, 101, 107, 136, 248, 181, 240, 131, 225, 199, 196, 184, 118, 248, 203, 194, 150, 58, 132, 234, 187, 99, 189, 85, 48, 221, 196, 63, 217, 158, 50, 28, 15, 108, 227, 218, 128, 63, 39, 249, 21, 99, 72, 191, 190, 210, 175, 86, 243, 74, 189, 186, 176, 185, 83, 145, 53, 164, 237, 12, 128, 255, 0, 188, 132, 31, 214, 190, 199, 248, 149, 251, 9, 194, 205, 37, 199, 195, 239, 29, 203, 111, 159, 185, 99, 175, 91, 249, 203, 244, 19, 197, 181, 128, 250, 163, 31, 122, 241, 63, 25, 254, 202, 255, 0, 29, 188, 58, 210, 55, 252, 33, 105, 173, 64, 135, 137, 180, 93, 66, 41, 195, 15, 100, 114, 146, 127, 227, 180, 1, 143, 225, 191, 218, 19, 227, 94, 135, 183, 236, 63, 18, 181, 201, 21, 122, 45, 236, 137, 120, 63, 242, 58, 185, 174, 154, 215, 246, 186, 248, 241, 18, 226, 79, 21, 216, 220, 123, 203, 163, 91, 127, 236, 170, 181, 229, 126, 35, 240, 79, 141, 124, 60, 9, 241, 7, 131, 60, 69, 164, 170, 156, 23, 190, 210, 166, 133, 63, 239, 182, 93, 191, 145, 172, 32, 65, 232, 65, 250, 80, 7, 184, 220, 254, 215, 95, 30, 37, 24, 79, 21, 88, 219, 251, 197, 163, 91, 231, 255, 0, 30, 83, 92, 231, 137, 63, 104, 143, 141, 218, 217, 63, 108, 248, 149, 173, 198, 15, 107, 22, 142, 207, 255, 0, 68, 34, 17, 249, 215, 152, 146, 7, 83, 143, 173, 108, 120, 115, 194, 62, 47, 241, 11, 237, 240, 247, 131, 252, 67, 171, 227, 169, 211, 244, 153, 231, 81, 255, 0, 2, 85, 42, 63, 19, 64, 20, 117, 173, 75, 81, 214, 47, 141, 238, 177, 168, 94, 106, 55, 44, 114, 103, 189, 184, 121, 228, 63, 240, 39, 36, 213, 82, 73, 57, 175, 92, 240, 127, 236, 191, 241, 231, 196, 101, 26, 47, 1, 54, 145, 11, 28, 121, 250, 221, 252, 54, 193, 125, 202, 41, 121, 63, 241, 202, 246, 175, 134, 255, 0, 176, 133, 195, 180, 115, 252, 67, 248, 129, 242, 131, 243, 216, 248, 118, 215, 102, 71, 161, 184, 155, 36, 254, 17, 169, 247, 160, 15, 141, 217, 209, 101, 142, 34, 73, 146, 102, 9, 20, 106, 165, 158, 86, 61, 21, 84, 114, 199, 216, 2, 107, 222, 254, 4, 254, 201, 95, 19, 188, 124, 240, 223, 248, 138, 22, 240, 78, 132, 228, 19, 62, 161, 14, 237, 66, 117, 255, 0, 166, 86, 167, 238, 103, 251, 210, 149, 199, 247, 26, 190, 223, 248, 61, 240, 79, 225, 135, 195, 5, 18, 120, 59, 194, 86, 118, 183, 197, 118, 201, 169, 79, 155, 139, 217, 56, 193, 204, 242, 22, 124, 31, 64, 64, 246, 174, 254, 128, 56, 15, 129, 31, 6, 62, 31, 252, 34, 209, 222, 211, 194, 26, 70, 203, 187, 133, 11, 123, 170, 93, 63, 157, 123, 123, 143, 249, 233, 41, 25, 199, 162, 40, 84, 29, 148, 87, 160, 113, 69, 20, 0, 102, 140, 209, 69, 0, 25, 163, 52, 81, 64, 31, 255, 217 }, "fd5b40dd-ba49-42f5-8dcf-27fdd62625f7" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Firmy_WlascicielId",
                table: "Firmy",
                column: "WlascicielId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupna_DaneOsoboweSprzedajacyId",
                table: "Kupna",
                column: "DaneOsoboweSprzedajacyId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupna_FirmaKupujacyId",
                table: "Kupna",
                column: "FirmaKupujacyId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupna_FirmaSprzedajacyId",
                table: "Kupna",
                column: "FirmaSprzedajacyId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupna_RodzajTowaruId",
                table: "Kupna",
                column: "RodzajTowaruId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupna_TowarId",
                table: "Kupna",
                column: "TowarId");

            migrationBuilder.CreateIndex(
                name: "IX_LoggingErrors_UserId",
                table: "LoggingErrors",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotosFirma_FirmaId",
                table: "PhotosFirma",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotosKupno_KupnoId",
                table: "PhotosKupno",
                column: "KupnoId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotosRodzajTowaru_RodzajTowaruId",
                table: "PhotosRodzajTowaru",
                column: "RodzajTowaruId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotosSprzedaz_SprzedazId",
                table: "PhotosSprzedaz",
                column: "SprzedazId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotosTowar_TowarId",
                table: "PhotosTowar",
                column: "TowarId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotosUser_UserId",
                table: "PhotosUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sprzedaze_FirmaId",
                table: "Sprzedaze",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Sprzedaze_KupujacyId",
                table: "Sprzedaze",
                column: "KupujacyId");

            migrationBuilder.CreateIndex(
                name: "IX_Sprzedaze_RodzajTowaruId",
                table: "Sprzedaze",
                column: "RodzajTowaruId");

            migrationBuilder.CreateIndex(
                name: "IX_Sprzedaze_TowarId",
                table: "Sprzedaze",
                column: "TowarId");

            migrationBuilder.CreateIndex(
                name: "IX_Towary_MarkaId",
                table: "Towary",
                column: "MarkaId");

            migrationBuilder.CreateIndex(
                name: "IX_Towary_RodzajTowaruId",
                table: "Towary",
                column: "RodzajTowaruId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "LoggingErrors");

            migrationBuilder.DropTable(
                name: "PhotosFirma");

            migrationBuilder.DropTable(
                name: "PhotosKupno");

            migrationBuilder.DropTable(
                name: "PhotosRodzajTowaru");

            migrationBuilder.DropTable(
                name: "PhotosSprzedaz");

            migrationBuilder.DropTable(
                name: "PhotosTowar");

            migrationBuilder.DropTable(
                name: "PhotosUser");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Kupna");

            migrationBuilder.DropTable(
                name: "Sprzedaze");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Firmy");

            migrationBuilder.DropTable(
                name: "Towary");

            migrationBuilder.DropTable(
                name: "DaneOsobowe");

            migrationBuilder.DropTable(
                name: "Marki");

            migrationBuilder.DropTable(
                name: "RodzajeTowarow");
        }
    }
}
