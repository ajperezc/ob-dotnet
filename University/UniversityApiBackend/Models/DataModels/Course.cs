using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public enum LevelNames
    {
        Basic,
        Intermediate,
        Advanced,
        Expert
    }

    public class Course : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public LevelNames Level { get; set;} = LevelNames.Basic;

        [Required]
        public ICollection<Category> Categories { get; set; } = new List<Category>();

        [Required]
        public Chapter Chapter { get; set; } = new Chapter();

        public ICollection<Student> Students { get; set; } = new List<Student>();

    }
}
