<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunEkle.aspx.cs" Inherits="OOPstok.UrunEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server" class="form-group">
        <div>
         <%--   <asp:Label ID="Label1" runat="server" Text="Departman Adı" Font-Bold="true"></asp:Label>--%>
           
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Ürün Adını Giriniz..."></asp:TextBox>
            <div>
                <br />
            </div>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Ürün Fiyatını Giriniz..."></asp:TextBox>
            <div>
                <br />
            </div>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Ürün Adedini Giriniz..."></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Müşteriyi Kaydet" CssClass="btn btn-primary" OnClick="Button1_Click" />
        </div>
    </form>
</asp:Content>
