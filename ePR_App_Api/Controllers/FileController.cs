using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace ePR_App_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [JwtAuthorize]
    public class FileController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<FileController> _logger;
        private readonly string _basePath;
        public FileController(IConfiguration configuration, ILogger<FileController> logger)
        {
            _configuration = configuration;
            _logger = logger;
            _basePath = _configuration["FileStorage:BasePath"]
                       ?? Path.Combine(Directory.GetCurrentDirectory(), "UploadedFiles");
        }
        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded.");

            try
            {
                string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "UploadedFiles");
                if (!Directory.Exists(uploadPath))
                    Directory.CreateDirectory(uploadPath);

                string filePath = Path.Combine(uploadPath, file.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                _logger.LogInformation("File uploaded: {FileName}", file.FileName);
                return Ok(new { file.FileName, file.Length });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "File upload failed.");
                return StatusCode(500, "Internal server error.");
            }
        }
        [HttpGet("download/{userCode}/{fileName}")]
        public async Task<IActionResult> Download(string userCode, string fileName)
        {
            try
            {
                string safeUserCode = Path.GetFileName(userCode.Replace(".", string.Empty));
                string safeFileName = Path.GetFileName(fileName);

                // Build remote file URL
                string fileUrl = $"{_basePath.TrimEnd('/')}/{safeUserCode}/{safeFileName}";

                using var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(fileUrl);

                if (!response.IsSuccessStatusCode)
                {
                    return NotFound(new { message = "File not found on remote server." });
                }

                var stream = await response.Content.ReadAsStreamAsync();
                var contentType = response.Content.Headers.ContentType?.ToString() ?? "application/octet-stream";

                _logger.LogInformation("User {UserCode} downloaded {FileName} from remote server {Url} ({IP})",
                    userCode, fileName, fileUrl, HttpContext.Connection.RemoteIpAddress);

                return File(stream, contentType, safeFileName);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error downloading file {UserCode}/{FileName}", userCode, fileName);
                return StatusCode(500, new { success = false, message = "Internal server error." });
            }
        }


        [HttpDelete("delete/{fileName}")]
        public IActionResult Delete(string fileName)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "UploadedFiles", fileName);

            if (!System.IO.File.Exists(filePath))
                return NotFound("File not found.");

            System.IO.File.Delete(filePath);
            _logger.LogInformation("File deleted: {FileName}", fileName);

            return Ok("File deleted successfully.");
        }

    }
}
