using System.Runtime.Serialization;

namespace WebServices
{
	[DataContract]
	public class Product
	{
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string Name { get; set; }
		[DataMember]
		public decimal Price { get; set; }
		[DataMember]
		public ProductSubCategory SubCategory { get; set; }
		[DataMember]
		public string SubCategoryName
		{
			get { return SubCategory.ToString(); }
			set { }
		}
	}
}