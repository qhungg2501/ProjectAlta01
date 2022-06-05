
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataLib.Entities
{

    public  class TestCategory
    {
        public TestCategory()
        {
            Tests = new HashSet<Test>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int testCateId { get; set; }

     
        public string? testCateName { get; set; }

        public bool? Status { get; set; }
        public  ICollection<Test> Tests { get; set; }

    }
}
