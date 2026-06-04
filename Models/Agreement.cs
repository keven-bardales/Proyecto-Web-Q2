namespace Proyecto_Web_Q2.Models;

public class Agreement
{
    public string Id { get; set; } = string.Empty; // El Id  del Acuerdo
    public string CaseId { get; set; } = string.Empty; // El Id del Caso
    public string MediatorId { get; set; } = string.Empty; // El Id del mediador
    public List<AgreementPoint> Points { get; set; } = []; // Seria los puntos que se ven
    public bool ConfirmedByReporter = false; // Cuando llega a confirmar el que reporto
    public bool ConfirmedByRespondent = false; // Cuando llega a confirmar el acusado o el jodido xd
    public DateTime? FormalizedAt = null; // Cuando se llego a una conclusión del acuerdo
    public DateTime CreatedAt = DateTime.UtcNow; // Cuando se creo el acuerdo
}
