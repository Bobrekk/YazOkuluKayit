<%@ Page Title="" Language="C#" MasterPageFile="~/Utilisateur.Master" AutoEventWireup="true" CodeBehind="ListeDeEtudiants.aspx.cs" Inherits="YazOkuluKayıt.ListeDeEtudiants" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci ID</th>
            <th>Öğrenci Ad</th>
            <th>Öğrenci Soyad</th>
            <th>Öğrenci Numara</th>
            <th>Öğrenci Şifre</th>
            <th>Öğrenci Fotoğraf</th>
            <th>Bakiye</th>
            <th>İşlemler</th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("OGRID")%></td>
                        <td><%#Eval("OGRAD")%></td>
                        <td><%#Eval("OGRSOYAD")%></td>
                        <td><%#Eval("OGRNUMARA")%></td>
                        <td><%#Eval("OGRSIFRE")%></td>
                        <td><%#Eval("OGRFOTO")%></td>
                        <td><%#Eval("OGRBAKIYE")%></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"SupprimerEtudiant.aspx?OGRID=" + Eval("OGRID")%>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#"MettreAJourEtudiant.aspx?OGRID=" + Eval("OGRID")%>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>

</asp:Content>
