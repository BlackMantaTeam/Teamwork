namespace JustPlay.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Sound
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Genre { get; set; }

        public string AudioSource { get; set; }
        public string ImageSource { get; set; }

        public string Artist { get; set; }
        public string Name { get; set; }

        public double Rating { get; set; }
    }
}