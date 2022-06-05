
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataLib.Entities
{


    public  class Test
    {
        public Test()
        {
            Class_Test = new HashSet<Class_Test>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int testId { get; set; }

   
        public string title { get; set; }

        public int? TestCategory { get; set; }

        public bool? Status { get; set; }

        public  ICollection<Class_Test> Class_Test { get; set; }

        public  TestCategory TestCategory1 { get; set; }


    }
}
