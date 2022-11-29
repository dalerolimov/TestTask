using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestTask.Services.InstallmentPayment.ModelRequests;
using TestTask.Services.InstallmentPayment.ModelResponses;
using TestTask.Services.InstallmentPayment.Service;

namespace TestTask.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InstallmentPaymentController : ControllerBase
    {
        private readonly IInstallmentPayment _installmentPayment;

        public InstallmentPaymentController(IInstallmentPayment installmentPayment)
        {
            _installmentPayment = installmentPayment;
        }

        [HttpPost]
        public InstallmentResponse Amount(InstallmentRequest request)
        {
            return _installmentPayment.InstallmentAmount(request);
        }
    }
}
