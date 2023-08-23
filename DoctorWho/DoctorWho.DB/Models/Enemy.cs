
namespace DoctorWho.DB.Models
{
    public class Enemy { 
    
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public IEnumerable<Episode> Episodes { get; set; } = new List<Episode>();
    }
}
