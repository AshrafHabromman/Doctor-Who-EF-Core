﻿
namespace DoctorWho.DB.Models
{
    public class EpisodeCompanion
    {
        public int Id { get; set; }
        public int EpisodeId { get; set; }
        public int CompanionId { get; set; }
        public Episode? Episode { get; set; }
        public Companion? Companion { get; set; }
    }
}
