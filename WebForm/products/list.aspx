<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="WebForm.products.list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Sản phẩm</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card">
        <div class="card-body">
            <div class="row">
                <asp:Repeater ID="rptList" runat="server">
                    <ItemTemplate>
                        <div class="col-md-3">
                            <div class="card">
                                <img src="<%# Eval("Thumbnail") %>" class="card-img-top" alt="" style="height: 300px">
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval("ProductName") %></h5>
                                    <p class="card-text"><b>Giá:</b> <%# Eval("Price") %></p>
                                    <a href="info.aspx?product-id=<%# Eval("ProductID") %>" class="btn btn-primary">Xem chi tiết</a>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
