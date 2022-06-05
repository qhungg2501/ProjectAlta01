
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataLib.Entities
{


    public  class Class_Course
    {
       [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int classCourseId { get; set; }

        public DateTime? lession { get; set; }

        public string Class { get; set; }

        public int? Course { get; set; }

        public bool? Status { get; set; }
        public  Class Class1 { get; set; }

        public  Course Course1 { get; set; }

    }
}
