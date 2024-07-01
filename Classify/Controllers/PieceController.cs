using Classify.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Classify.Web.Controllers
{
    public class PieceController : Controller
    {
        private readonly IPieceService pieceService;
        private readonly IAudioService audioService;

        public PieceController(IPieceService pieceService, IAudioService audioService)
        {
            this.pieceService = pieceService;
            this.audioService = audioService;
        }
        public async Task<IActionResult> All(int id)
        {
            var model = await pieceService.AllById(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file, int pieceId)
        {
            _ = await audioService.UploadAsync(file, pieceId);

            return RedirectToAction(nameof(All), "Piece", new { id = pieceId });
        }
        public async Task<FileResult> Download(int id)
        {
            var file = await audioService.FindByIdAsync(id);
            if (file != null)
            {
                return File(file.AudioFile, file.AudioFileContentType, file.AudioFileName);
            }
            return null;
        }

        public async Task<IActionResult> Play(int id)
        {
            var file = await audioService.FindByIdAsync(id);
            if (file == null)
            {
                return NotFound();
            }

            var stream = new MemoryStream(file.AudioFile);
            Response.Headers.Add("Accept-Ranges", "bytes");

            return new FileStreamResult(stream, file.AudioFileContentType)
            {
                FileDownloadName = file.AudioFileName,
                EnableRangeProcessing = true
            };
        }
        public async Task<IActionResult> Remove(int id)
        {
            await audioService.RemoveAsync(id);

            return RedirectToAction(nameof(All), new { id });
        }
    }
}
