<%@ Page Title="" Language="C#" MasterPageFile="~/Utilisateur.Master" AutoEventWireup="true" CodeBehind="MettreAJourEtudiant.aspx.cs" Inherits="YazOkuluKayıt.MettreAJour" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">

        <div class="form-group">

            <div>
                <strong>
                    <asp:Label for="TxtBoxId" runat="server" Text="Öğrenci Id"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtBoxId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

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
        <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-warning" OnClick="Button1_Click" />
    </form>
</asp:Content>
