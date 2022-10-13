﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Musteriler.aspx.cs" Inherits="OOPstok.Musteriler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>MÜŞTERİ ID</th>
            <th>MÜŞTERİ ADI</th>
            <th>MÜŞTERİ SOYADI</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>             
            <tr>
             <td><%#Eval("MUSTERIID") %></td>
             <td><%#Eval("MUSTERIAD") %></td>
             <td><%#Eval("MUSTERISOYAD") %></td>
                <td><asp:HyperLink  ID="HyperLink1" NavigateUrl='<%#"~/MusteriSil.Aspx?MUSTERIID=" + Eval("MUSTERIID") %>' runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink></td>
                <td><asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"~/MusteriGuncelle.Aspx?MUSTERIID=" + Eval("MUSTERIID") %>'  runat="server" CssClass="btn btn-warning">GÜNCELLE </asp:HyperLink></td>
            </tr>
            </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <a href="MusteriEkle.aspx" class="btn btn-info">Yeni Müşteri Ekle</a>
        
</asp:Content>
