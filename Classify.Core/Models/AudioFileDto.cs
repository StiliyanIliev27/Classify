namespace Classify.Core.Models
{
    public class AudioFileDto
    {
        public string? AudioFileName { get; set; }
        public string? AudioFileContentType { get; set; }
        public byte[]? AudioFile { get; set; }
        public int PieceId { get; set; }   
    }
}
