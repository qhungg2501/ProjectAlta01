
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataLib.Entities
{

    public class StudentAccount
    {
        [Key]
        public string userName { get; set; }

        public string passWord { get; set; }

        public bool? isLogin { get; set; }

       
        public string Student { get; set; }

        public bool? Status { get; set; }
        public  Student Student1 { get; set; }

    }
}
