using System.ComponentModel.DataAnnotations;

namespace Proyecto_Web_Q2.DTOs;

public class CreateAgreementDto
{
    [Required]
    public string CaseId = string.Empty;

    [Required]
    public string AgreementText = string.Empty;

    [Required]
    [MinLength(1)]
    public List<CreateAgreementPointDto> Points = [];
}

// TODO: Le debo consultar al Ingeniero si muevo esto aun Dto aparte o lo dejo aca insanamente
public class CreateAgreementPointDto
{
    [Required]
    public string Description = string.Empty;

    [Required]
    public DateTime Deadline = DateTime.UtcNow;
}
