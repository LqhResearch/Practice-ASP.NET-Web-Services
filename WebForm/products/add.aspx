<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="WebForm.products.add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Thêm sản phẩm</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card">
        <div class="card-body">
            <h3 class="text-center text-success pb-2">Thêm sản phẩm</h3>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
            <div class="row">
                <div class="col-md-6 mb-3">
                    <label class="form-label">Tên sản phẩm: </label>
                    <asp:TextBox ID="txtName" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-6 mb-3">
                    <label class="form-label">Giá: </label>
                    <asp:TextBox ID="txtPrice" CssClass="form-control" TextMode="Number" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-6 mb-3">
                    <label class="form-label">Hình ảnh: </label>
                    <asp:FileUpload ID="fThumnail" CssClass="form-control" runat="server" />
                </div>
                <div class="col-md-12 mb-3">
                    <asp:Button ID="btnAdd" CssClass="btn btn-primary" runat="server" Text="Thêm" OnClick="btnAdd_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
