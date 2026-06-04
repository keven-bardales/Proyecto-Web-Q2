namespace Proyecto_Web_Q2.Models;

public class AgreementPoint
{
    /*
     * Este seria como el reporte de lo que va escribir el mediador
     * del acuerdo que se llego con las personas sobre el caso
     */
    public string Description { get; set; } = string.Empty;

    // Este solo seria para el cierre del acuerdo
    public DateTime Deadline { get; set; } = DateTime.UtcNow;

    /*
      Los que vamos a usar en ComplianceStatus seran:
      - pendiente -> Es el default
      - cumplido
      - incumplido
     */
    public string ComplianceStatus { get; set; } = "pendiente";
}
