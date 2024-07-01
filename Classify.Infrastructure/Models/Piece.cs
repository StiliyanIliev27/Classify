using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Classify.Infrastructure.Enums;

namespace Classify.Infrastructure.Models
{
    public class Piece
    {
        [Required]
        public int Id { get; set; }

        [Required]  
        public string Title { get; set; } = null!;

        [Required]
        public PieceType Type { get; set; }

        [Required]
        public InstrumentType InstrumentType { get; set; }

        [Required]
        [ForeignKey(nameof(ComposerId))]
        public int ComposerId { get; set; }
        public Composer Composer { get; set; } = null!;

        public string? AudioFileName { get; set; }   
        public string? AudioFileContentType { get; set; }
        public byte[]? AudioFile { get; set; }
    }
}
