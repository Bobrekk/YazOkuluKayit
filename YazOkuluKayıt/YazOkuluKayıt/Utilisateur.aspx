<%@ Page Title="" Language="C#" MasterPageFile="~/Utilisateur.Master" AutoEventWireup="true" CodeBehind="Utilisateur.aspx.cs" Inherits="YazOkuluKayıt.Utilisateur1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">

        <div class="form-group">

            <div>
                <strong>
                <asp:Label for="TxtBoxAd" runat="server" Text="Ad"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtBoxAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div>
                <strong>
                <asp:Label for="TxtBoxSoyad" runat="server" Text="Soyad"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtBoxSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div>
                <strong>
                <asp:Label for="TxtBoxNumara" runat="server" Text="Numara"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtBoxNumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div>
                <strong>
                <asp:Label for="TxtBoxSifre" runat="server" Text="Şifre"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtBoxSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div>
                <strong>
                <asp:Label for="TxtBoxFoto" runat="server" Text="Fotoğraf"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtBoxFoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

        </div>
        <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" CssClass="btn btn-info" />
    </form>
</asp:Content>
