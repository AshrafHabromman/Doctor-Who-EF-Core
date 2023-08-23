using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.DB.Migrations
{
    public partial class CreateFunctionsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE FUNCTION dbo.fnEnemies(@EpisodeId INT)
                                    RETURNS VARCHAR(255)
                                    AS
                                    BEGIN 
	                                    DECLARE @enemies VARCHAR(255)
	                                    SET @enemies = ''
	                                    SELECT @enemies = COALESCE(@enemies + ', ', '') +  E.Name 
	                                    FROM Enemies E
	                                    WHERE E.Id IN (
		                                    SELECT DISTINCT EE.EnemyId
		                                    FROM EpisodeEnemy EE
		                                    WHERE EE.EpisodeId = @EpisodeId
	                                    )

	                                    RETURN @enemies
                                    END");

            migrationBuilder.Sql(@"CREATE FUNCTION dbo.fnCompanions(@EpisodeId INT)
                                    RETURNS NVARCHAR(MAX)
                                    AS
                                    BEGIN
                                        DECLARE @companions NVARCHAR(MAX);
                                        SET @companions = N'';

                                        SELECT @companions = @companions + COALESCE(Name, N'') + N', '
                                        FROM Companions
                                        WHERE Id IN (
                                            SELECT CompanionId
                                            FROM EpisodeCompanion
                                            WHERE EpisodeId = @EpisodeId
                                        );

                                        SET @companions = LEFT(@companions, LEN(@companions) - 1);

                                        RETURN @companions;
                                    END;");
        }
  

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP FUNCTION dbo.fnEnemies;");
        }
    }
}
