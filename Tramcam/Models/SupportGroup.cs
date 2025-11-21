namespace Tramcam.Models
{
    public class SupportGroup
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string MeetingTime { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string ContactPerson { get; set; } = string.Empty;
        public string ContactEmail { get; set; } = string.Empty;
        public string ContactPhone { get; set; } = string.Empty;
        public int MaxParticipants { get; set; }
        public bool IsActive { get; set; }
    }
}