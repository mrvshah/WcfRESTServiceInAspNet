using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WebServices
{
	[ServiceContract]
	public interface IProductService
	{
		[AspNetCacheProfile("GetProductsWebServiceCacheProfile")]
		[WebGet(UriTemplate = "GetProducts/{category}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		[OperationContract]
		IEnumerable<Product> GetProducts(string category);
	}
}