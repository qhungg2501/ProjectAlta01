
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataLib.Entities
{


    public  class Student
    {
        public Student()
        {
            LearningOutcomes = new HashSet<LearningOutcome>();
            Student_Test = new HashSet<Student_Test>();
           
        }

        [Key]
        public string studentId { get; set; }

        public string? firstName { get; set; }

        public string? lastName { get; set; }

        public bool? gender { get; set; }

        public DateTime? birthDay { get; set; }

        public string? Class { get; set; }

        public bool? Status { get; set; }

        public  Class Class1 { get; set; }

       
        public  ICollection<LearningOutcome> LearningOutcomes { get; set; }

       
        public  ICollection<Student_Test> Student_Test { get; set; }

       
        public  StudentAccount StudentAccount { get; set; }

    }
}
