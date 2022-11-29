using TestTask.Services.InstallmentPayment.ModelRequests;
using TestTask.Services.InstallmentPayment.ModelResponses;

namespace TestTask.Services.InstallmentPayment.Service
{
    public class InstallmentPayment : IInstallmentPayment
    {
        private readonly List<int> ranges = new() { 3, 6, 9, 12, 18, 24 };
        private readonly List<Product> products = new()
        {
            new Product()
            {
                Id = 1,
                Name = "Smartphone",
                MinRange = 3,
                MaxRange = 9,
                AddPercent = 3,
            },
            new Product()
            {
                Id = 2,
                Name = "Computer",
                MinRange = 3,
                MaxRange = 12,
                AddPercent = 4,
            },
            new Product()
            {
                Id = 3,
                Name = "TV",
                MinRange = 3,
                MaxRange = 18,
                AddPercent = 5,
            }
        };
        public InstallmentResponse InstallmentAmount(InstallmentRequest request)
        {
            var totalAmount = 0;
            var local = 0;
            var product = products.FirstOrDefault(x => x.Id == request.ProductId);
            if (product != null)
            {
                if (product.MaxRange < ranges.FirstOrDefault(x => x == request.InstallmentRange))
                {
                    for (var i = 1; i < ranges.Count; i++)
                    {
                        totalAmount = ++totalAmount;
                        if(ranges[i] == product.MaxRange)
                        {
                            for(var j = totalAmount + 1; j < ranges.Count; j++)
                            {
                                local = ++local;
                                if(ranges[j] == request.InstallmentRange)
                                {
                                    Console.WriteLine(local);
                                    break;
                                }
                            }
                        }
                    }
                    InstallmentResponse response = new()
                    {
                        ProductName = product.Name,
                        Amount = request.Amount + (request.Amount * (product.AddPercent * local) / 100),
                        Percent = product.AddPercent * local,
                    };
                    return response;
                }
            }
            return null;
        }
    }

}
