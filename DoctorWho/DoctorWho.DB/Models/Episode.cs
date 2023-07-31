using DoctorWho.DB.Enums;

namespace DoctorWho.DB.Models
{
    public class Episode
    {
        public int Id { get; set; }
        public int SeriesNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public EpisodeType EpisodeType { get; set; } = EpisodeType.Regular;
        public string Title { get; set; } = string.Empty;
        public DateTime EpisodeDate { get; set; }
        public int AuthorId { get; set; }
        public int DoctorId { get; set; }
        public string Notes { get; set; } = string.Empty;

        public IEnumerable<Enemy> Enemies { get; set; } = new List<Enemy>();
        public IEnumerable<Companion> Companions { get; set; } = new List<Companion>();
    }
}
