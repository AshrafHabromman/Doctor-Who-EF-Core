using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.DB.Migrations
{
    public partial class CreateProceduresMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE PROCEDURE dbo.spSummariseEpisodes 
                                    AS
                                    BEGIN
                                    (SELECT C.Name, tblCountsRes.Counts
                                    FROM Companions C
                                    INNER JOIN(
                                        SELECT TOP(3) EC.CompanionId, COUNT(EC.CompanionId) AS Counts
                                        FROM EpisodeCompanion EC
                                        GROUP BY EC.CompanionId
                                        ORDER BY Counts DESC) AS tblCountsRes
                                    ON C.Id = tblCountsRes.CompanionId)

                                    (SELECT E.Name, tblCountsRes.Counts
                                    FROM Enemies E
                                    INNER JOIN(
                                        SELECT TOP(3) EE.EnemyId, COUNT(EE.EnemyId) AS Counts
                                        FROM EpisodeEnemy EE
                                        GROUP BY EE.EnemyId
                                        ORDER BY Counts DESC) AS tblCountsRes
                                    ON E.Id = tblCountsRes.EnemyId)
                                END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE dbo.spSummariseEpisodes;");
        }
    }
}
