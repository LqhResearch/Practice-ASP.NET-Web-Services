<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="info.aspx.cs" Inherits="WebForm.products.info" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Chi tiết sản phẩm</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card">
        <div class="card-body">
            <h3 class="text-center text-success pb-2"><b>Thông tin chi tiết sản phẩm</b></h3>
            <div class="row">
                <div class="col-md-3">
                    <asp:Image ID="img" runat="server" Width="100%" />
                </div>
                <div class="col-md-9">
                    <div class="my-2">
                        <b>Tên sản phẩm: </b>
                        <asp:Label ID="txtName" runat="server" />
                    </div>
                    <div class="my-2">
                        <b>Giá: </b>
                        <asp:Label ID="txtPrice" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="card mt-4">
        <div class="card-body">
            <h3 class="text-center text-success pb-2"><b>Bình luận sản phẩm</b></h3>
            <asp:Repeater ID="rptCommentList" runat="server">
                <ItemTemplate>
                    <div class="row my-2">
                        <div class="col-md-2">
                            <img class="avatar_custom" src="<%# Eval("Avatar") %>" alt="" />
                            <label><%# Eval("Fullname") %></label>
                        </div>
                        <div class="col-md-10">
                            <label><%# Eval("Content") %></label>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

    <style>
        .starRating {
            font-size: 20px;
            cursor: pointer;
        }
    </style>
    <div class="card mt-4">
        <div class="card-body">
            <div class="mb-3">
                <label class="form-label">Đánh giá sao</label>
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <ajaxToolkit:Rating ID="Rating1" runat="server"
                            StarCssClass="starRating"
                            FilledStarCssClass="fas fa-star text-warning"
                            EmptyStarCssClass="fas fa-star text-secondary"
                            WaitingStarCssClass="fas fa-star text-primary"
                            CurrentRating="0"
                            MaxRating="5" />

                        <% if (Convert.ToBoolean(Session["Login"]))
                            { %>
                        <asp:Button ID="btnRating" CssClass="btn btn-primary" runat="server" Text="Đánh giá" OnClick="btnRating_Click" />
                        <% }
                            else
                            { %>
                        <label class="form-label">Vui lòng đăng nhập trước khi bình luận</label>
                        <% } %>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>

            <div class="mb-3">
                <label class="form-label">Nội dung bình luận</label>
                <asp:TextBox ID="txtComment" TextMode="MultiLine" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <% if (Convert.ToBoolean(Session["Login"]))
                { %>
            <asp:Button ID="btnComment" CssClass="btn btn-outline-primary" runat="server" Text="Bình luận" OnClick="btnComment_Click" />
            <% }
                else
                { %>
            <label class="form-label">Vui lòng đăng nhập trước khi bình luận</label>
            <% } %>
        </div>
    </div>
</asp:Content>
