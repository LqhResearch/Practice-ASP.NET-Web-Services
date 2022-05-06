<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="WebForm.ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Đổi mật khẩu</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card shadow" style="width: 600px; margin: auto">
        <div class="card-header text-center bg-success text-white">
            <h2>Đổi mật khẩu</h2>
        </div>
        <div class="card-body">
            <div class="mb-3">
                <label class="form-label">Mật khẩu mới</label>
                <asp:TextBox ID="txtPassword1" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">Nhập lại mật khẩu mới</label>
                <asp:TextBox ID="txtPassword2" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Button ID="btnSave" CssClass="btn btn-outline-primary" runat="server" Text="Đổi mật khẩu" OnClick="btnSave_Click" />
            </div>
        </div>
    </div>
</asp:Content>
