
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataLib.Entities
{

    public  class Grade
    {
        public Grade()
        {
            Classes = new HashSet<Class>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int gradeId { get; set; }

        public string gradeName { get; set; }

        public bool? Status { get; set; }

        public  ICollection<Class> Classes { get; set; }

    }
}
