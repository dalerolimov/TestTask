using TestTask.Services.InstallmentPayment.ModelRequests;
using TestTask.Services.InstallmentPayment.ModelResponses;

namespace TestTask.Services.InstallmentPayment.Service
{
    public interface IInstallmentPayment
    {
        public InstallmentResponse InstallmentAmount(InstallmentRequest request);
    }
}
