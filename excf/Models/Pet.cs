
using System.ComponentModel.DataAnnotations;

namespace excf.Models
{
    public class Pet
    {
        [Key]
        public int pid { get; set; }
        public string pname { get; set; }
        public string pcategory { get; set; }
        public int page { get; set; }
        public string pbreed { get; set; }
    }
}
