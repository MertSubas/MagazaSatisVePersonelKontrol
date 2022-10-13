<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="PersonelEkle.aspx.cs" Inherits="OOPstok.PersonelEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">
        <div>
         <%--   <asp:Label ID="Label1" runat="server" Text="Departman Adı" Font-Bold="true"></asp:Label>--%>
           
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Personel Adını Giriniz..."></asp:TextBox>
            <div>
                <br />
            </div>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Personel Soyadını Giriniz..." OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <div>
                <br />
            </div>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Personel Maaşını Giriniz..."></asp:TextBox>
        </div>
        <br />
        <div>
           
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
             <br />
            <asp:Button ID="Button1" runat="server" Text="Personeli Kaydet" CssClass="btn btn-primary" OnClick="Button1_Click"  />
        </div>
        
    </form>
</asp:Content>
