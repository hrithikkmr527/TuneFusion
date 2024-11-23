namespace TuneFusion.Entities
{
    public class Song
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Duration { get; set; }

        public string Artist { get; set; } 
    }
}
