using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.DB.Migrations
{
    public partial class CreateViewEpisodes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW [dbo].[viewEpisodes] AS 
                                    SELECT  A.Name AS AuthorName, D.Name As DoctorName,
                                    dbo.fnCompanions(E.Id) AS CompanionsNames, 
                                    dbo.fnEnemies(E.Id) AS EnemiesNames

                                    FROM Episodes E 
                                    INNER JOIN Authors A on E.AuthorId = A.Id
                                    INNER JOIN Doctors D on E.DoctorId = D.Id
                                ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW dbo.viewEpisodes");
        }
    }
}
