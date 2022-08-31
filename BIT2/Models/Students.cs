using System.ComponentModel.DataAnnotations;

namespace BIT2.Models
{
    public class Students
    {
        [Key]
        public int MatricNum { get; set; }
        public string StudentName { get; set; }
        public string Department { get; set; }
        public int Level { get; set; }
    }
}
