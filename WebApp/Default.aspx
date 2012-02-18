<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebApp._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
      <div data-bind="template: {name:'productTemplate', foreach:filteredProducts}"></div>
      <script type="text/html" id="productTemplate">
         <div>
            <div style="float: left;padding-right: 10px">${Id}</div>
            <div style="float: left;padding-right: 10px">${Name}</div>
            <div style="float: left;padding-right: 10px">${SubCategoryName}</div>
            <div style="float: none;">${Price}</div>
         </div>
      </script>
      
      
   <div id="output"/>
</asp:Content>
