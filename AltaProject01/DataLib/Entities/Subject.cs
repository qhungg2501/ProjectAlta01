
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataLib.Entities
{
    public  class Subject
    {
        public Subject()
        {
            Admins = new HashSet<Admin>();
            Courses = new HashSet<Course>();
            Documents = new HashSet<Document>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int subjectId { get; set; }

       
        public string? subjectName { get; set; }

       
        public string? description { get; set; }

        public bool? Status { get; set; }


      
        public  ICollection<Admin> Admins { get; set; }

    
        public  ICollection<Course> Courses { get; set; }

  
        public  ICollection<Document> Documents { get; set; }


    }
}
