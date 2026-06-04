using Proyecto_Web_Q2.DTOs;

namespace Proyecto_Web_Q2.Services;

public class AgreementService
{
    private readonly FireBaseService _fireBaseService;
    private readonly string collectionName = "agreements";

    public AgreementService(FireBaseService fireBase)
    {
        _fireBaseService = fireBase;
    }

    public async Task<CreateAgreementDto> CreateAsync(CreateAgreementDto dto, string userId)
    {
        var caseDoc = await _fireBaseService
            .GetCollection("cases")
            .Document(dto.CaseId)
            .GetSnapshotAsync();

        if (!caseDoc.Exists)
            throw new Exception("No se encuentro ningun caso");

        string userMediatorId = caseDoc.GetValue<string>("MediadorId");

        var mediatorsDoc = await _fireBaseService
            .GetCollection("mediators")
            .Document(dto.CaseId)
            .GetSnapshotAsync();

        if (!mediatorsDoc.Exists)
            throw new Exception("El usuario no es un mediador asignado");
    }
}
