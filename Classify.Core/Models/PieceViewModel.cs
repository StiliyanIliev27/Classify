namespace Classify.Core.Models
{
    public class PieceViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string InstrumentType { get; set; } = null!;
        public string ComposerFullName { get; set; } = null!;
        public string ComposerImageUrl { get; set; } = null!;
        public string ComposerDescription { get; set; } = null!;
        public int ComposerYearnBorn { get; set; } 
        public string? AudioContentType { get; set; }
    }
}
