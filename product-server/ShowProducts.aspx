<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MyMasterPage.master" CodeFile="ShowProducts.aspx.cs" Inherits="ShowProducts" %>

    <asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
           <link href="StyleSheet2.css" rel="stylesheet" />
        <style>
            .myClass {
                 display:inline-table;
                 flex-wrap: wrap;
                 margin: 0 0 3em 0;
                 padding: 0;
                 white-space:normal;
                 width: 20%;  
                 text-align: center;
            }
        </style>
     
  </asp:Content>
 <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
        <asp:PlaceHolder ID="productsPH" runat="server"></asp:PlaceHolder>
     <br />
      <br />
      <br />
        <asp:Button ID="Button1" runat="server" Text="Create List" OnClick="Button1_Click" />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

</asp:Content>
