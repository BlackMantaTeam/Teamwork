namespace JustPlay.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class MenuItem
    {
        [Key]
        public int Id { get; set; }

        public string IconFile { get; set; }

        public string Category { get; set; }
    }
}