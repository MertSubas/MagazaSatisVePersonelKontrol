<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MusteriEkle.aspx.cs" Inherits="OOPstok.MusteriEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
        <div>
         <%--   <asp:Label ID="Label1" runat="server" Text="Departman Adı" Font-Bold="true"></asp:Label>--%>
           
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Müşteri Adını Giriniz..."></asp:TextBox>
            <div>
                <br />
            </div>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Müşteri Soydını Giriniz..."></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Müşteriyi Kaydet" CssClass="btn btn-primary" OnClick="Button1_Click"/>
        </div>
    </form>
</asp:Content>
