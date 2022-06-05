
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataLib.Entities
{

    public partial class Document
    {
     
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int docId { get; set; }

       
        public string? title { get; set; }

       
        public string? description { get; set; }

       
        public string? docPath { get; set; }

        public int? Subject { get; set; }

        public bool? Status { get; set; }

        public  Subject Subject1 { get; set; }


    }
}
