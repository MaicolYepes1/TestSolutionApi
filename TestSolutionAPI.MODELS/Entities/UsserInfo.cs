using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestSolutionAPI.MODELS.Entities
{
    public class UsserInfo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Mail { get; set; }
        [MaxLength(30)]
        public string Department { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
    }
}
