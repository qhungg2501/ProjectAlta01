
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataLib.Entities
{

    public  class AdminAccount
    {
        [Key]
        public string userName { get; set; }

        public string passWord { get; set; }

        public bool? isLogin { get; set; }

        public string Admin { get; set; }

        public bool? Status { get; set; }
        public  Admin Admin1 { get; set; }

    }
}
