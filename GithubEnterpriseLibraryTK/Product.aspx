<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="GithubEnterpriseLibraryTK.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Products List</h2>
    <asp:GridView ID="grvProduct" runat="server"></asp:GridView>
</asp:Content>
