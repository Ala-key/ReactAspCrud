using System.ComponentModel.DataAnnotations;

namespace ReactAspCrud.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }

        public string? Name { get; set; }


        public string Phone { get; set; }


        public string Cource { get; set; }

    }
}
