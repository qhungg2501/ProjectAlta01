
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataLib.Entities
{
  
    public class Admin
    {
        [Key]
        public string teacherId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime? birthDay { get; set; }
        public bool? gender { get; set; }
        public string address { get; set; }
        public int? Position { get; set; }
        public int? Subject { get; set; }
        public bool? Status { get; set; }
        public  Position Position1 { get; set; }

        public  Subject Subject1 { get; set; }

        public  AdminAccount AdminAccount { get; set; }
    }
}
