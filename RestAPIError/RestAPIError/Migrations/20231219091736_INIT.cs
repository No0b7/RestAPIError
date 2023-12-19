using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAPIError.Migrations
{
    /// <inheritdoc />
    public partial class INIT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NIST_Option",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NIST_Option", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "NIST_CySeMainFeatures",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    networkConnectedId = table.Column<int>(type: "int", nullable: false),
                    networkLevelId = table.Column<int>(type: "int", nullable: false),
                    computerId = table.Column<int>(type: "int", nullable: false),
                    localUserInterfaceId = table.Column<int>(type: "int", nullable: false),
                    remoteUserInterfaceId = table.Column<int>(type: "int", nullable: false),
                    userAccountsId = table.Column<int>(type: "int", nullable: false),
                    wirelessCommunicationId = table.Column<int>(type: "int", nullable: false),
                    multipleIPConnectionsId = table.Column<int>(type: "int", nullable: false),
                    communicatesAcrossNetworksId = table.Column<int>(type: "int", nullable: false),
                    logFilesSupportedId = table.Column<int>(type: "int", nullable: false),
                    userAccountLockingAccordingToRequirementsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NIST_CySeMainFeatures", x => x.id);
                    table.ForeignKey(
                        name: "FK_NIST_CySeMainFeatures_NIST_Option_communicatesAcrossNetworksId",
                        column: x => x.communicatesAcrossNetworksId,
                        principalTable: "NIST_Option",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NIST_CySeMainFeatures_NIST_Option_computerId",
                        column: x => x.computerId,
                        principalTable: "NIST_Option",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NIST_CySeMainFeatures_NIST_Option_localUserInterfaceId",
                        column: x => x.localUserInterfaceId,
                        principalTable: "NIST_Option",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NIST_CySeMainFeatures_NIST_Option_logFilesSupportedId",
                        column: x => x.logFilesSupportedId,
                        principalTable: "NIST_Option",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NIST_CySeMainFeatures_NIST_Option_multipleIPConnectionsId",
                        column: x => x.multipleIPConnectionsId,
                        principalTable: "NIST_Option",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NIST_CySeMainFeatures_NIST_Option_networkConnectedId",
                        column: x => x.networkConnectedId,
                        principalTable: "NIST_Option",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NIST_CySeMainFeatures_NIST_Option_networkLevelId",
                        column: x => x.networkLevelId,
                        principalTable: "NIST_Option",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NIST_CySeMainFeatures_NIST_Option_remoteUserInterfaceId",
                        column: x => x.remoteUserInterfaceId,
                        principalTable: "NIST_Option",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NIST_CySeMainFeatures_NIST_Option_userAccountLockingAccordingToRequirementsId",
                        column: x => x.userAccountLockingAccordingToRequirementsId,
                        principalTable: "NIST_Option",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NIST_CySeMainFeatures_NIST_Option_userAccountsId",
                        column: x => x.userAccountsId,
                        principalTable: "NIST_Option",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NIST_CySeMainFeatures_NIST_Option_wirelessCommunicationId",
                        column: x => x.wirelessCommunicationId,
                        principalTable: "NIST_Option",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NIST_CySeMainFeatures_communicatesAcrossNetworksId",
                table: "NIST_CySeMainFeatures",
                column: "communicatesAcrossNetworksId");

            migrationBuilder.CreateIndex(
                name: "IX_NIST_CySeMainFeatures_computerId",
                table: "NIST_CySeMainFeatures",
                column: "computerId");

            migrationBuilder.CreateIndex(
                name: "IX_NIST_CySeMainFeatures_localUserInterfaceId",
                table: "NIST_CySeMainFeatures",
                column: "localUserInterfaceId");

            migrationBuilder.CreateIndex(
                name: "IX_NIST_CySeMainFeatures_logFilesSupportedId",
                table: "NIST_CySeMainFeatures",
                column: "logFilesSupportedId");

            migrationBuilder.CreateIndex(
                name: "IX_NIST_CySeMainFeatures_multipleIPConnectionsId",
                table: "NIST_CySeMainFeatures",
                column: "multipleIPConnectionsId");

            migrationBuilder.CreateIndex(
                name: "IX_NIST_CySeMainFeatures_networkConnectedId",
                table: "NIST_CySeMainFeatures",
                column: "networkConnectedId");

            migrationBuilder.CreateIndex(
                name: "IX_NIST_CySeMainFeatures_networkLevelId",
                table: "NIST_CySeMainFeatures",
                column: "networkLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_NIST_CySeMainFeatures_remoteUserInterfaceId",
                table: "NIST_CySeMainFeatures",
                column: "remoteUserInterfaceId");

            migrationBuilder.CreateIndex(
                name: "IX_NIST_CySeMainFeatures_userAccountLockingAccordingToRequirementsId",
                table: "NIST_CySeMainFeatures",
                column: "userAccountLockingAccordingToRequirementsId");

            migrationBuilder.CreateIndex(
                name: "IX_NIST_CySeMainFeatures_userAccountsId",
                table: "NIST_CySeMainFeatures",
                column: "userAccountsId");

            migrationBuilder.CreateIndex(
                name: "IX_NIST_CySeMainFeatures_wirelessCommunicationId",
                table: "NIST_CySeMainFeatures",
                column: "wirelessCommunicationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NIST_CySeMainFeatures");

            migrationBuilder.DropTable(
                name: "NIST_Option");
        }
    }
}
