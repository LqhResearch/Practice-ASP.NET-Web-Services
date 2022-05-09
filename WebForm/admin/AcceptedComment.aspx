<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="AcceptedComment.aspx.cs" Inherits="WebForm.admin.AcceptedComment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Duyệt bình luận</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card">
        <div class="card-body">
            <h3 class="text-center text-success pb-2">Duyệt bình luận</h3>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Mã sản phẩm</th>
                        <th>Tên sản phẩm</th>
                        <th>Hình ảnh</th>
                        <th>Người dùng</th>
                        <th>Nội dung</th>
                        <th>Công cụ</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="rptCommentList" runat="server">
                        <ItemTemplate>
                            <tr>
                                <th><%# Eval("ProductID") %></th>
                                <td><%# Eval("ProductName") %></td>
                                <td><img src="<%# Eval("Thumbnail") %>" alt="" style="height: 60px;" /></td>
                                <td><%# Eval("Username") %></td>
                                <td><%# Eval("Content") %></td>
                                <td><a class="btn btn-success" href="?comment-id=<%# Eval("CommentID") %>">Duyệt</a></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>
