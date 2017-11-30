<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/myMasterPage.master"  CodeFile="FirstWebHW.aspx.cs" Inherits="FirstWebHW" %>
 
 <asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link href="StyleSheet2.css" rel="stylesheet" />
        </asp:Content>



 <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <asp:Label ID="name" runat="server" Text="Enter Product Name"></asp:Label>
        <asp:TextBox ID="name1" runat="server" required="required" EnableViewState="False" ViewStateMode="Disabled"></asp:TextBox>   
    </div>
         <br />
    <div>
        <asp:Label ID="price" runat="server" Text="Enter Product Price"></asp:Label>
        <asp:TextBox ID="price1" runat="server" required="required" EnableViewState="False" ViewStateMode="Disabled"></asp:TextBox>
    </div> 
        <br />
    <div>
        <asp:Label ID="Categor" runat="server" text="Choose Category"></asp:Label>
        <asp:DropDownList ID="Categor1" runat="server" >

        <asp:ListItem Text="Please Select" Value="-1"></asp:ListItem>

        <asp:ListItem Value="1">Shoes</asp:ListItem>

        <asp:ListItem Value="2">T-Shirts</asp:ListItem>

        <asp:ListItem Value="3">Dresses</asp:ListItem>

        <asp:ListItem Value="4">Jeans</asp:ListItem>

        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ErrorMessage="Must choose" InitialValue="-1"  ControlToValidate="Categor1"></asp:RequiredFieldValidator>

          </div>
        <br />
        <div>
        <asp:Label ID="Description" runat="server" Text="Enter Description"></asp:Label>
            <asp:TextBox id="Description1" cols="20" rows="2" runat="server"  required="required" EnableViewState="False" ViewStateMode="Disabled"/>
            
        </div>
        <br />
        <div>
        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" />
            <br />
    </div>
          </asp:Content>