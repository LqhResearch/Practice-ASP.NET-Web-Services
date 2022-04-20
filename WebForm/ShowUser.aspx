<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="ShowUser.aspx.cs" Inherits="WebForm.ShowUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Thông tin người dùng</title>
    <link rel="stylesheet" href="/assets/css/style.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card shadow">
        <div class="row">
            <div class="col-md-3 d-flex-center">
                <asp:Image ID="imgAvatar" runat="server" CssClass="img-fluid" />
            </div>
            <div class="col-md-9">
                <table class="table" style="margin: 0">
                    <tbody>
                        <tr>
                            <td>ID: </td>
                            <td>
                                <asp:Label ID="lblID" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Email: </td>
                            <td>
                                <asp:Label ID="lblEmail" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Giới tính: </td>
                            <td>
                                <asp:Label ID="lblGender" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Tên: </td>
                            <td>
                                <asp:Label ID="lblName" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Vị trí: </td>
                            <td>
                                <asp:Label ID="lblLocate" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
