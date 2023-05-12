<%@ Page Title="" Language="C#" MasterPageFile="~/Utilisateur.Master" AutoEventWireup="true" CodeBehind="Lecons.aspx.cs" Inherits="YazOkuluKayıt.Lecons" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
        
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ders Seçin"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
    
        <div>
            <asp:Label ID="Label2" runat="server" Text="Öğrenci ID"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <asp:Button ID="Button1" runat="server" Text="Ders Talep Oluştur" CssClass="btn btn-warning" OnClick="Button1_Click"/>

    </form>

</asp:Content>


