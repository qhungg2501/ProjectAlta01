
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataLib.Entities
{



    public  class Class_Test
    {

        public Class_Test()
        {
            Student_Test = new HashSet<Student_Test>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int classTestId { get; set; }

        public int? isComplete { get; set; }

    
        public DateTime? testDate { get; set; }

        public int? testDuration { get; set; }

    
        public string Class { get; set; }

        public int? Test { get; set; }

        public bool? Status { get; set; }
        public  Class Class1 { get; set; }

        public  Test Test1 { get; set; }
    
        public  ICollection<Student_Test> Student_Test { get; set; }


    }
}
