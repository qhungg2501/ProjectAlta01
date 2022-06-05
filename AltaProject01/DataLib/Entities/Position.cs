
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataLib.Entities
{

    public  class Position
    {
        public Position()
        {
            Admins = new HashSet<Admin>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int positionId { get; set; }
 
        public string? positionName { get; set; }

        public bool? Status { get; set; }

        public  ICollection<Admin> Admins { get; set; }

    }
}
