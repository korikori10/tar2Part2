<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/myMasterPage.master" CodeFile="Payment.aspx.cs" Inherits="Payment" %>

    <asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="StyleSheet2.css" rel="stylesheet" />
        <script src="JavaScript.js"></script>
          </asp:Content>
 <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

       Name:<asp:TextBox ID="Name" runat="server" required="required" EnableViewState="False" ViewStateMode="Disabled"  ></asp:TextBox>
        <br />
        Address:<asp:TextBox ID="Address" runat="server" EnableViewState="False" ViewStateMode="Disabled"   required="required"></asp:TextBox>
        <br />
     Email:<asp:TextBox  TextMode="Email" ID="Email" runat="server" EnableViewState="False" ViewStateMode="Disabled"   required="required"></asp:TextBox>
       
        <br />
      Shipping Date: <asp:Calendar ID="Calendar1" runat="server"   ></asp:Calendar>
        <asp:CustomValidator id="CustomValidator1" runat="server" Display="Dynamic"  ErrorMessage="please click a day"  OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
       <br />
      Credit   <asp:CheckBox ID="ChBCredit" runat="server" AutoPostBack="true" EnableViewState="False"  ViewStateMode="Disabled" OnCheckedChanged="ChBCredit_CheckedChanged" />
      Phone   <asp:CheckBox ID="CHbPhone" runat="server" AutoPostBack="true" EnableViewState="False"  ViewStateMode="Disabled" OnCheckedChanged="CHbPhone_CheckedChanged" />
         <asp:PlaceHolder ID="PH" runat="server"></asp:PlaceHolder>

        <asp:CustomValidator ID="CBV" runat="server" ErrorMessage="Must select 1"  ClientValidationFunction="CBV" > </asp:CustomValidator>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"  />
     </asp:Content>