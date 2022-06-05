
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataLib.Entities
{


    public  class Student_Test
    {
        public Student_Test()
        {
            LearningOutcomes = new HashSet<LearningOutcome>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentTestId { get; set; }

        
        public string documentTest { get; set; }

        public double? testMath { get; set; }

       
        public string Student { get; set; }

        public int? Class_Test { get; set; }

        public bool? Status { get; set; }

        public  Class_Test Class_Test1 { get; set; }

        
        public  ICollection<LearningOutcome> LearningOutcomes { get; set; }

        public  Student Student1 { get; set; }


    }
}
