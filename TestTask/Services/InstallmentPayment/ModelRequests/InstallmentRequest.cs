namespace TestTask.Services.InstallmentPayment.ModelRequests
{
    public class InstallmentRequest
    {
        public int ProductId { get; set; }

        public double Amount { get; set; }

        public string PhoneNumber { get; set; }

        public int InstallmentRange { get; set; }
    }
}
