namespace TestTask.Services.InstallmentPayment.ModelRequests
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        public int AddPercent { get; set; }
    }
}
