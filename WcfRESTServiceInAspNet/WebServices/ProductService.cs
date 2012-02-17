using System.Collections.Generic;
using System.ServiceModel.Activation;

namespace WebServices
{
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class ProductService : IProductService
	{
		public IEnumerable<Product> GetProducts(string category)
		{
			return new List<Product>
			       	{
			       		new Product {Id = 1, Name = "Book1", Price = 30.5m, SubCategory = ProductSubCategory.Intermediate},
			       		new Product {Id = 1, Name = "Book2", Price = 17.2m, SubCategory = ProductSubCategory.Beginner},
			       		new Product {Id = 1, Name = "Book3", Price = 10.99m, SubCategory = ProductSubCategory.Advanced},
			       		new Product {Id = 1, Name = "Book4", Price = 6.75m, SubCategory = ProductSubCategory.Beginner},
			       		new Product {Id = 1, Name = "Book5", Price = 22.13m, SubCategory = ProductSubCategory.Intermediate},
			       		new Product {Id = 1, Name = "Book6", Price = 19.99m, SubCategory = ProductSubCategory.Advanced},
			       		new Product {Id = 1, Name = "Book7", Price = 25m, SubCategory = ProductSubCategory.Intermediate},
			       		new Product {Id = 1, Name = "Book8", Price = 55.50m, SubCategory = ProductSubCategory.Advanced},
			       		new Product {Id = 1, Name = "Book9", Price = 32.09m, SubCategory = ProductSubCategory.Advanced},
			       		new Product {Id = 1, Name = "Book10", Price = 40.00m, SubCategory = ProductSubCategory.Intermediate},
			       	};
		}
	}
}