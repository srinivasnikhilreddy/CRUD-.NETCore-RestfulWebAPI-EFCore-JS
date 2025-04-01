using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace WebApplication1_Angular_HttpCLient.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int progress { get; set; }
        public string gender { get; set; }
        public int rating { get; set; }
        public string col { get; set; }
        public DateTime dob { get; set; }
        public bool car { get; set; }
    }
}
