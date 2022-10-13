<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Personel.aspx.cs" Inherits="OOPstok.Personel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>PERSONEL ID</th>
            <th>PERSONEL ADI</th>
            <th>PERSONEL SOYADI</th>
            <th>PERSONEL DEPARTMANI</th>
            <th>PERSONEL MAAŞ</th>
            
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>             
            <tr>
             <td><%#Eval("PERSONELID") %></td>
             <td><%#Eval("PERSONELAD") %></td>
             <td><%#Eval("PERSONELSOYAD") %></td>
             <td><%#Eval("personeldep") %></td>
             <td><%#Eval("PERSONELMAAS") %></td>
            
            </tr>
            </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
<a href="PersonelEkle.aspx" class="btn btn-info">Yeni Personel Kaydı Ekle</a>



</asp:Content>
