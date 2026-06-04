using System.ComponentModel.DataAnnotations;

namespace Proyecto_Web_Q2.DTOs;

public class ConfirmAgreementDto
{
    [Required]
    public string AgreementId = string.Empty;

    [Required]
    public bool Confirmed = false;
}
