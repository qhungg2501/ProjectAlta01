
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataLib.Entities
{

    public  class LearningOutcome
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Student { get; set; }

        public int? Semester { get; set; }

        public int? Student_Test { get; set; }

        public bool? Status { get; set; }

        

        public  Student Student1 { get; set; }

        public  Student_Test Student_Test1 { get; set; }

    }
}
