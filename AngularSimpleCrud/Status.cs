using System.ComponentModel.DataAnnotations;

namespace AngularSimpleCrud
{
    public class Status
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string StatusOption { get; set; } = String.Empty;
    }
}
