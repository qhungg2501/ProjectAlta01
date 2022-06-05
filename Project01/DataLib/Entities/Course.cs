
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataLib.Entities
{

    public class Course
    {
        public Course()
        {
            Class_Course = new HashSet<Class_Course>();
         
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int courseId { get; set; }

        public DateTime? startDate { get; set; }

       
        public DateTime? endDate { get; set; }

   
        public string linkOnline { get; set; }

        public int? Subject { get; set; }

        public bool? Status { get; set; }
    

        public  Subject Subject1 { get; set; }

        public ICollection<Class_Course> Class_Course { get; set; }


    }
}
