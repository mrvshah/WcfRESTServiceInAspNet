using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace WebServices
{
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
	public class ProductService : IProductService
	{
		public IEnumerable<Product> GetProducts(string category)
		{
			return new List<Product>
			       	{
			       		new Product {Id = 1, Name = "Book1", Price = 30.5m, SubCategory = ProductSubCategory.Intermediate},
			       		new Product {Id = 2, Name = "Book2", Price = 17.2m, SubCategory = ProductSubCategory.Beginner},
			       		new Product {Id = 3, Name = "Book3", Price = 10.99m, SubCategory = ProductSubCategory.Advanced},
			       		new Product {Id = 4, Name = "Book4", Price = 6.75m, SubCategory = ProductSubCategory.Beginner},
			       		new Product {Id = 5, Name = "Book5", Price = 22.13m, SubCategory = ProductSubCategory.Intermediate},
			       		new Product {Id = 6, Name = "Book6", Price = 19.99m, SubCategory = ProductSubCategory.Advanced},
			       		new Product {Id = 7, Name = "Book7", Price = 25m, SubCategory = ProductSubCategory.Intermediate},
			       		new Product {Id = 8, Name = "Book8", Price = 55.50m, SubCategory = ProductSubCategory.Advanced},
			       		new Product {Id = 9, Name = "Book9", Price = 32.09m, SubCategory = ProductSubCategory.Advanced},
			       		new Product {Id = new Random().Next(100, 1000), Name = "Book10", Price = 40.00m, SubCategory = ProductSubCategory.Intermediate},
			       	};
		}
	}
}