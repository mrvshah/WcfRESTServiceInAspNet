$(document).ready(function () {

   var viewModel = {
      products: new Array(),
      productCategories: new Array(),
      filteredProducts: ko.observableArray([])
   };

   $.ajax({
      type: "GET",
      contentType: "application/json; charset=utf-8",
      dataType: "json",
      url: "/WebServices/ProductService/GetProducts/" + "Books",
      //data: "/Books",
      async: false,
      error: function (msg) {
         console.log(msg);
      },
      success: function (msg) {
         viewModel.products = $.Enumerable.From(msg).OrderBy(function (x) { return x.Price; }).ToArray();
         viewModel.productCategories = $.Enumerable.From(msg).Distinct(function (x) { return x.SubCategoryName; }).OrderBy(function (x) { return x.SubCategory; }).ToArray();

         viewModel.filteredProducts(viewModel.products);
      }
   });

   ko.applyBindings(viewModel);
});