using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public enum LevelNames
    {
        Basic,
        Intermediate,
        Advance
    }

    public class Course : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;

        public string LongDescription { get; set; } = string.Empty;

        public string Target { get; set; } = string.Empty;

        public string Goals { get; set; } = string.Empty;

        public string Requirements { get; set; } = string.Empty;

        public LevelNames Level { get; set;}

    }
}
