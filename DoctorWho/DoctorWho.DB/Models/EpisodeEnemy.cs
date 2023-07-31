
namespace DoctorWho.DB.Models
{
    public class EpisodeEnemy
    {
        public int Id { get; set; }
        public int EpisodeId { get; set; }
        public int EnemyId { get; set; }
        public Episode? Episode { get; set; }
        public Enemy? Enemy { get; set; }

    }
}
