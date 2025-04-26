// Controllers/ExternalUsersController.cs
using System.Text.Json;

using Microsoft.AspNetCore.Mvc;
using MiPrimeraApi.ExternalServices;
using System.Threading.Tasks;
using MiPrimeraApi.Models.ExternalUsers; // Asegúrate de que este namespace esté correcto

[ApiController]
[Route("api/external-users")]
public class ExternalUsersController : ControllerBase
{
    private readonly ExternalUserService _externalUserService;

    public ExternalUsersController(ExternalUserService externalUserService)
    {
        _externalUserService = externalUserService;
    }

    [HttpGet]
    public async Task<IActionResult> GetExternalUsers()
    {
        try
        {
            var usersResponse = await _externalUserService.GetUsersAsync();
            return Ok(usersResponse);
        }
        catch (HttpRequestException ex)
        {
            return StatusCode(502, $"Error al contactar la API externa: {ex.Message}");
        }
        catch (JsonException ex)
        {
            return StatusCode(500, $"Error al procesar los datos recibidos: {ex.Message}");
        }
        catch (System.Exception ex)
        {
            return StatusCode(500, $"Error inesperado: {ex.Message}");
        }
    }
}
