
namespace DoctorWho.DB.Models
{
    public class Companion
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string WhoPlayed { get; set; } = string.Empty; 
        public IEnumerable<Episode> Episodes { get; set; } = new List<Episode>();   
       
    }
}
