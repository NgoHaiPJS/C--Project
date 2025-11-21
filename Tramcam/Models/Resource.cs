namespace Tramcam.Models
{
    public class Resource
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty; // Video, Document, Audio, etc.
        public string Language { get; set; } = "vi"; // Default to Vietnamese
        public DateTime CreatedDate { get; set; }
        public bool IsApproved { get; set; }
    }
}