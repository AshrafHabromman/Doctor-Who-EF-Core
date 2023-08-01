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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP FUNCTION dbo.fnEnemies;");
        }
    }
}
