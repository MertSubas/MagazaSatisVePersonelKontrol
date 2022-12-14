<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="OOPstok.Urunler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered">
        <tr>
            <th>URUN ID</th>
            <th>URUN ADI</th>
            <th>URUN FİYATI</th>
            <th>URUN STOK</th>
            
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>             
            <tr>
             <td><%#Eval("URUNID") %></td>
             <td><%#Eval("URUNAD") %></td>
             <td><%#Eval("URUNFIYAT") %></td>
             <td><%#Eval("URUNADET") %></td>
            </tr>
            </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <a href="UrunEkle.aspx" class="btn btn-info">Yeni Ürün Ekle</a>
</asp:Content>
