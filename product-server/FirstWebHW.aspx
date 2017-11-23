<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/myMasterPage.master"  CodeFile="FirstWebHW.aspx.cs" Inherits="FirstWebHW" %>
 
 <asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link href="StyleSheet2.css" rel="stylesheet" />
        </asp:Content>



 <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <asp:Label ID="name" runat="server" Text="Enter Product Name"></asp:Label>
        <asp:TextBox ID="name1" runat="server"></asp:TextBox>   
    </div>
         <br />
    <div>
        <asp:Label ID="price" runat="server" Text="Enter Product Price"></asp:Label>
        <asp:TextBox ID="price1" runat="server"></asp:TextBox>
    </div> 
        <br />
    <div>
        <asp:Label ID="Categor" runat="server" Text="Choose Category"></asp:Label>
        <asp:DropDownList ID="Categor1" runat="server">
        <asp:ListItem Selected="True">Please Select</asp:ListItem>

        <asp:ListItem>Shoes</asp:ListItem>

        <asp:ListItem>T-Shirts</asp:ListItem>

        <asp:ListItem>Dresses</asp:ListItem>

        <asp:ListItem>Jeans</asp:ListItem>

        </asp:DropDownList>
           </div>
        <br />
        <div>
        <asp:Label ID="Description" runat="server" Text="Enter Description"></asp:Label>
            <asp:TextBox id="Description1" cols="20" rows="2" runat="server" />
            
        </div>
        <br />
        <div>
        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" />
            <br />
    </div>
          </asp:Content>